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
            var leaderboard = COD.GetUserProfile("v2", "wwii", "psn", "Cronotrigga8");
            var myLeaderBoard = COD.GetLeaderBoardByUsername("v2", "wwii", "psn", "alltime", "core", "career", "YOUTUBE__Kor3aYn");
            var pageLeaderBoard = COD.GetLeaderBoardByPage("v2", "wwii", "psn", "alltime", "core", "career", 4);
            var matches = COD.GetRecentMatches("v2", "wwii", "psn", "YOUTUBE__Kor3aYn", 1);
            return View();
        }

        public JsonResult GetUserProfile(string username)
        {
            return new JsonResult()
            {
                Data = COD.GetUserProfile("v2", "wwii", "psn", username)
            };
        }

        public JsonResult GetRecentMatches(string username, int days)
        {
            return new JsonResult()
            {
                Data = COD.GetRecentMatches("v2", "wwii", "psn", username ?? "YOUTUBE__Kor3aYn", days)
            };
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