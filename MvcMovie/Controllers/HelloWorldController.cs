using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return View();
        // change string   return "This is my <b>default</b> action...";
        }

        public string Welcome()
        {
            return "This is Welcome action method";
        }

        public string Hello(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + " NumTimes is: "+numTimes);
        }

        public string Link(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + " ID: " + ID);
            //https://localhost:44301/HelloWorld/Link/1?name=Jay
            //https://localhost:44301/HelloWorld/Link/jay/2
        }


    }
}