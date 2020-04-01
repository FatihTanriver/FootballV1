using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballPopup.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";
        //}

        public string Welcome(string name, int numTimes = 1)
        {
            ////Security Note: The code above uses HttpUtility.HtmlEncode to protect the application from malicious input (namely JavaScript). 
            ////For more information see How to: Protect Against Script Exploits in a Web Application by Applying HTML Encoding to Strings.
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }

    }
}