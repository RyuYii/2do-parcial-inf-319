using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
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
        public String FibonacciRecursivo(int n)
        {
            
            String v = "";
            for (int i = 1; i < n; i++)
            {
                v = v + Library1.Calcu.fiboRecursivo(i).ToString() + ",";

            }
            return v + Library1.Calcu.fiboRecursivo(n).ToString();
        }

        [WebMethod]
        public String FibonacciEstructurado(int n)
        {
            String v = "";
            for (int i = 1; i < n; i++)
            {
                v = v + Library1.Calcu.fibo(i).ToString() + ",";

            }
            return v + Library1.Calcu.fiboRecursivo(n).ToString();

        }
    }
}
