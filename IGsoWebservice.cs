using System.Collections.Generic;
using System.ServiceModel;
namespace Ivory.GSO.WebService.App
{
    [ServiceContract]
    public interface IGsoWebservice
    {
        [OperationContract]
        string Test(string s);

        [OperationContract]
        IEnumerable<MMFParameter> MMF(string userName, string password);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);

    }
}