using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Ivory.GSO.WebService.App;
using Ivory.GSO.WebService.Repository.Model;

public class GsoWebservice : IGsoWebservice
{
    public string Test(string s)
    {
        Console.WriteLine("Test Method Executed!");
        return s;
    }
    public IEnumerable<MMFParameter> MMF(string userName, string password)
    {

        Console.WriteLine("MMF Method Executed!");
        return new List<MMFParameter>
        {
            new MMFParameter
            {
                MeasurementTime = DateTime.Now,
                MMF1 = 1000.12,
                MMF2 = 1000.14,
                MMF3 = 1000.11,
                Unit = "hPa"
            },
            new MMFParameter
            {
                MeasurementTime = DateTime.Now,
                MMF1 = 1000.12,
                MMF2 = 1000.14,
                MMF3 = 1000.11,
                Unit = "hPa"
            },
        };
    }

    public ActivePowerProductionResponse ActivePowerProduction(string userName, string password)
    {
        List<PlantForecastIntervalNode> x = new List<PlantForecastIntervalNode>();
        ActivePowerProductionResponse activePowerProductionResponse = new ActivePowerProductionResponse
        {
            PlantDescription = "*PlantName*"
        };

        XNamespace soapNameSpace
          = XNamespace.Get("https://webservice.meteologica.com/api/MeteologicaDataExchangeService.php");
                var document = XDocument.Parse(File.ReadAllText("../../docs/forecasted_data.xml"));

                var soapMessage = document?.Root?.Descendants()?.Where(p =>
                            p.Name.LocalName.Equals("forecastData") // && p.Name.Namespace == soapNameSpace
                            ).FirstOrDefault()?.Value?.ToString();

        foreach (string s in soapMessage.Trim(':').Split(':'))
        {

            x.Add(new PlantForecastIntervalNode
            {
                ForecastResultParameter = "ActivePowerProduction",
                IntervalEndTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(s.Split('~')[0])).DateTime,
                IntervalStartTime = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(s.Split('~')[0])).DateTime.AddMinutes(-15),
                IntervalLength = 15,
                ForecastValue = Convert.ToDecimal(s.Split('~')[1]),
                ValueUnit = "MW"

            });

        }

        activePowerProductionResponse.PlantForecastIntervals = x.ToArray();

        return activePowerProductionResponse;

    }

    public void XmlMethod(XElement xml)
    {
        Console.WriteLine(xml.ToString());
    }
}

