using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServicePelangi_1198
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
        public string Pelangi(int warnaUrut)
        {
            switch (warnaUrut)
            {
                case 1:
                    return "Merah";
                case 2:
                    return "Jingga";
                case 3:
                    return "Kuning";
                case 4:
                    return "Hijau";
                case 5:
                    return "Biru";
                case 6:
                    return "Nila";
                case 7:
                    return "Ungu";
                default:
                    return "Nomor antara 1-7";
            }
        }
    }
}
