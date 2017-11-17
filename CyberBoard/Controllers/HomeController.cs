using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Json;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Net;
using OAuthTwitterWrapper.JsonTypes;

namespace CyberBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string search = Request.QueryString["search"];
            if(search == null || search == "")
            {
                System.Diagnostics.Debug.WriteLine("empty");
                search = "Cyber Security";
            }
            var wrapper = new OAuthTwitterWrapper.OAuthTwitterWrapper();
            wrapper.SearchSettings.SearchQuery = search;

            var results = wrapper.GetSearch();

            var tweets = results == null ? null : JsonConvert.DeserializeObject<Search>(results);

            return View(tweets.Results);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}