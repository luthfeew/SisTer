using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceSuhu_1198
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public double CelciusToReamur(int c)
        {
            return (0.8) * c;
        }

        [WebMethod]
        public double CelciusToFahrenheit(int c)
        {
            return (1.8) * c + 32;
        }

        [WebMethod]
        public int CelciusToKelvin(int c)
        {
            return c + 273;
        }
    }
}
