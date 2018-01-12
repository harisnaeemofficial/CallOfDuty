using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Lib
{
    public class LeaderBoard
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("data")]
        public Data StatData { get; set; }

        public class Data
        {
            [JsonProperty("title")]
            public string Title { get; set; }
            [JsonProperty("platform")]
            public string Platform { get; set; }
            [JsonProperty("leaderboardType")]
            public string LeaderboardType { get; set; }
            [JsonProperty("gameMode")]
            public string GameMode { get; set; }
            [JsonProperty("page")]
            public int Page { get; set; }
            [JsonProperty("resultsRequested")]
            public int ResultsRequested { get; set; }
            [JsonProperty("totalPages")]
            public int TotalPages { get; set; }
            [JsonProperty("sort")]
            public object Sort { get; set; }
            [JsonProperty("columns")]
            public List<string> Columns { get; set; }
            [JsonProperty("entries")]
            public List<Entry> Entries { get; set; }

            public class Entry
            {
                [JsonProperty("rank")]
                public double Rank { get; set; }
                [JsonProperty("username")]
                public string Username { get; set; }
                [JsonProperty("updateTime")]
                public double UpdateTime { get; set; }
                [JsonProperty("rating")]
                public double Rating { get; set; }
                [JsonProperty("values")]
                public EntryValues Values { get; set; }
                public class EntryValues
                {
                    [JsonProperty("wins")]
                    public double Wins { get; set; }
                    [JsonProperty("kills")]
                    public double Kills { get; set; }
                    [JsonProperty("kdRatio")]
                    public double KdRatio { get; set; }
                    [JsonProperty("level")]
                    public double Level { get; set; }
                    [JsonProperty("losses")]
                    public double Losses { get; set; }
                    [JsonProperty("prestige")]
                    public double Prestige { get; set; }
                    [JsonProperty("totalXp")]
                    public double TotalXp { get; set; }
                    [JsonProperty("score")]
                    public double Score { get; set; }
                    [JsonProperty("timePlayed")]
                    public double TimePlayed { get; set; }
                    [JsonProperty("averageTime")]
                    public double AverageTime { get; set; }
                    [JsonProperty("gamesPlayed")]
                    public double GamesPlayed { get; set; }
                    [JsonProperty("scorePerMinute")]
                    public double ScorePerMinute { get; set; }
                    [JsonProperty("deaths")]
                    public double Deaths { get; set; }
                }
            }
        }
    }
}
