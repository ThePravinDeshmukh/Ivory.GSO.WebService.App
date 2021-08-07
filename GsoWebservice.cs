using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Ivory.GSO.WebService.App;

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
    public void XmlMethod(XElement xml)
    {
        Console.WriteLine(xml.ToString());
    }
}

