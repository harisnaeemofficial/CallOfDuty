using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CallOfDuty.Lib;

namespace CallOfDuty.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userProfile = COD.GetUserProfile("v2", "wwii", "psn", "cronotrigga8");
            var myLeaderBoard = COD.GetLeaderBoardByUsername("v2", "wwii", "psn", "alltime", "core", "career", "cronotrigga8");
            var pageLeaderBoard = COD.GetLeaderBoardByPage("v2", "wwii", "psn", "alltime", "core", "career", 1);
            return View();
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