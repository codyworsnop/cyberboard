using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Json;
using System.Web.Mvc;
using Newtonsoft.Json;
using OAuthTwitterWrapper.JsonTypes;
using System.Net;

namespace CyberBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var tweet = new OAuthTwitterWrapper.OAuthTwitterWrapper();
            var json = tweet.GetMyTimeline();
            var tweets = JsonConvert.DeserializeObject<List<TimeLine>>(json);

            return View(tweets);
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