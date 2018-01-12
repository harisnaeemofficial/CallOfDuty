using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CallOfDuty.Lib
{
    public class COD
    {
        private static WebClientEx _webClient = new WebClientEx(new CookieContainer());

        private static string _baseUrl = "https://my.callofduty.com/api/papi-client/";

        public static UserProfile GetUserProfile(string apiVersion, string game, string platform, string username)
            => Request<UserProfile>(new string[] { "crm", "cod", apiVersion, "title", game, "platform", platform, "gamer", username, "profile" });

        public static LeaderBoard GetLeaderBoardByUsername(string apiVersion, string game, string platform, string time, string type, string mode, string username)
            => Request<LeaderBoard>(new string[] { "leaderboards", apiVersion, "title", game, "platform", platform, "time", time, "type", type, "mode", mode, "gamer", username });
        
        public static LeaderBoard GetLeaderBoardByPage(string apiVersion, string game, string platform, string time, string type, string mode, int page)
        => Request<LeaderBoard>(new string[] { "leaderboards", apiVersion, "title", game, "platform", platform, "time", time, "type", type, "mode", mode, "page", page.ToString() });

        private static T Request<T>(string[] urlParams)
        {
            var url = _baseUrl + string.Join("/", urlParams);
            string pageSource = _webClient.DownloadString(url);
            return JsonConvert.DeserializeObject<T>(pageSource);
        }
    }
}
