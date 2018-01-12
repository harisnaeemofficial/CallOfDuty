using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CallOfDuty.Lib
{
    public class Matches
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("data")]
        public Data MatchData { get; set; }

        public class Data
        {
            [JsonProperty("matches")]
            public List<Match> Matches { get; set; }
            [JsonProperty("summary")]
            public Summary PlayerSummary { get; set; }

            public class Summary
            {
                [JsonProperty("all")]
                public All AllGameModes { get; set; }
                [JsonProperty("ctf")]
                public Ctf CaptureTheFlag { get; set; }
                [JsonProperty("war")]
                public War TeamDeathMatch { get; set; }
                [JsonProperty("conf")]
                public Conf KillConfirmed { get; set; }
                public class All
                {
                    [JsonProperty("kills")]
                    public double Kills { get; set; }
                    [JsonProperty("distanceTravelled")]
                    public double DistanceTravelled { get; set; }
                    [JsonProperty("divisionXpMountain")]
                    public double DivisionXpMountain { get; set; }
                    [JsonProperty("accuracy")]
                    public double Accuracy { get; set; }
                    [JsonProperty("divisionXpExpeditionary")]
                    public double DivisionXpExpeditionary { get; set; }
                    [JsonProperty("losses")]
                    public double Losses { get; set; }
                    [JsonProperty("shotsLanded")]
                    public double ShotsLanded { get; set; }
                    [JsonProperty("score")]
                    public double Score { get; set; }
                    [JsonProperty("totalXp")]
                    public double TotalXp { get; set; }
                    [JsonProperty("headshots")]
                    public double Headshots { get; set; }
                    [JsonProperty("assists")]
                    public double Assists { get; set; }
                    [JsonProperty("scorePerMinute")]
                    public double ScorePerMinute { get; set; }
                    [JsonProperty("deaths")]
                    public double Deaths { get; set; }
                    [JsonProperty("wins")]
                    public double Wins { get; set; }
                    [JsonProperty("shotsMissed")]
                    public double ShotsMissed { get; set; }
                    [JsonProperty("kdRatio")]
                    public double KdRatio { get; set; }
                    [JsonProperty("divisionXpInfantry")]
                    public double DivisionXpInfantry { get; set; }
                    [JsonProperty("divisionXpArmored")]
                    public double DivisionXpArmored { get; set; }
                    [JsonProperty("divisionXpAirborne")]
                    public double DivisionXpAirborne { get; set; }
                    [JsonProperty("avgSpeed")]
                    public double AvgSpeed { get; set; }
                    [JsonProperty("avgKillDistance")]
                    public double AvgKillDistance { get; set; }
                    [JsonProperty("timePlayed")]
                    public double TimePlayed { get; set; }
                    [JsonProperty("matchesPlayed")]
                    public double MatchesPlayed { get; set; }
                    [JsonProperty("divisionXpNone")]
                    public double DivisionXpNone { get; set; }
                    [JsonProperty("shotsFired")]
                    public double ShotsFired { get; set; }
                }
                public class Ctf
                {
                    [JsonProperty("kills")]
                    public double Kills { get; set; }
                    [JsonProperty("shotsMissed")]
                    public double ShotsMissed { get; set; }
                    [JsonProperty("kdRatio")]
                    public double KdRatio { get; set; }
                    [JsonProperty("distanceTravelled")]
                    public double DistanceTravelled { get; set; }
                    [JsonProperty("divisionXpMountain")]
                    public double DivisionXpMountain { get; set; }
                    [JsonProperty("accuracy")]
                    public double Accuracy { get; set; }
                    [JsonProperty("divisionXpExpeditionary")]
                    public double DivisionXpExpeditionary { get; set; }
                    [JsonProperty("divisionXpInfantry")]
                    public double DivisionXpInfantry { get; set; }
                    [JsonProperty("divisionXpArmored")]
                    public double DivisionXpArmored { get; set; }
                    [JsonProperty("losses")]
                    public double Losses { get; set; }
                    [JsonProperty("shotsLanded")]
                    public double ShotsLanded { get; set; }
                    [JsonProperty("divisionXpAirborne")]
                    public double DivisionXpAirborne { get; set; }
                    [JsonProperty("avgSpeed")]
                    public double AvgSpeed { get; set; }
                    [JsonProperty("avgKillDistance")]
                    public double AvgKillDistance { get; set; }
                    [JsonProperty("score")]
                    public double Score { get; set; }
                    [JsonProperty("totalXp")]
                    public double TotalXp { get; set; }
                    [JsonProperty("timePlayed")]
                    public double TimePlayed { get; set; }
                    [JsonProperty("matchesPlayed")]
                    public double MatchesPlayed { get; set; }
                    [JsonProperty("headshots")]
                    public double Headshots { get; set; }
                    [JsonProperty("divisionXpNone")]
                    public double DivisionXpNone { get; set; }
                    [JsonProperty("assists")]
                    public double Assists { get; set; }
                    [JsonProperty("scorePerMinute")]
                    public double ScorePerMinute { get; set; }
                    [JsonProperty("shotsFired")]
                    public double ShotsFired { get; set; }
                    [JsonProperty("deaths")]
                    public double Deaths { get; set; }
                }
                public class War
                {
                    [JsonProperty("kills")]
                    public double Kills { get; set; }
                    [JsonProperty("distanceTravelled")]
                    public double DistanceTravelled { get; set; }
                    [JsonProperty("divisionXpMountain")]
                    public double DivisionXpMountain { get; set; }
                    [JsonProperty("accuracy")]
                    public double Accuracy { get; set; }
                    [JsonProperty("divisionXpExpeditionary")]
                    public double DivisionXpExpeditionary { get; set; }
                    [JsonProperty("losses")]
                    public double Losses { get; set; }
                    [JsonProperty("shotsLanded")]
                    public double ShotsLanded { get; set; }
                    [JsonProperty("score")]
                    public double Score { get; set; }
                    [JsonProperty("totalXp")]
                    public double TotalXp { get; set; }
                    [JsonProperty("headshots")]
                    public double Headshots { get; set; }
                    [JsonProperty("assists")]
                    public double Assists { get; set; }
                    [JsonProperty("scorePerMinute")]
                    public double ScorePerMinute { get; set; }
                    [JsonProperty("deaths")]
                    public double Deaths { get; set; }
                    [JsonProperty("wins")]
                    public double Wins { get; set; }
                    [JsonProperty("shotsMissed")]
                    public double ShotsMissed { get; set; }
                    [JsonProperty("kdRatio")]
                    public double KdRatio { get; set; }
                    [JsonProperty("divisionXpInfantry")]
                    public double DivisionXpInfantry { get; set; }
                    [JsonProperty("divisionXpArmored")]
                    public double DivisionXpArmored { get; set; }
                    [JsonProperty("divisionXpAirborne")]
                    public double DivisionXpAirborne { get; set; }
                    [JsonProperty("avgSpeed")]
                    public double AvgSpeed { get; set; }
                    [JsonProperty("avgKillDistance")]
                    public double AvgKillDistance { get; set; }
                    [JsonProperty("timePlayed")]
                    public double TimePlayed { get; set; }
                    [JsonProperty("matchesPlayed")]
                    public double MatchesPlayed { get; set; }
                    [JsonProperty("divisionXpNone")]
                    public double DivisionXpNone { get; set; }
                    [JsonProperty("shotsFired")]
                    public double ShotsFired { get; set; }
                }
                public class Conf
                {
                    [JsonProperty("kills")]
                    public double Kills { get; set; }
                    [JsonProperty("shotsMissed")]
                    public double ShotsMissed { get; set; }
                    [JsonProperty("kdRatio")]
                    public double KdRatio { get; set; }
                    [JsonProperty("distanceTravelled")]
                    public double DistanceTravelled { get; set; }
                    [JsonProperty("divisionXpMountain")]
                    public double DivisionXpMountain { get; set; }
                    [JsonProperty("accuracy")]
                    public double Accuracy { get; set; }
                    [JsonProperty("divisionXpExpeditionary")]
                    public double DivisionXpExpeditionary { get; set; }
                    [JsonProperty("divisionXpInfantry")]
                    public double DivisionXpInfantry { get; set; }
                    [JsonProperty("divisionXpArmored")]
                    public double DivisionXpArmored { get; set; }
                    [JsonProperty("shotsLanded")]
                    public double ShotsLanded { get; set; }
                    [JsonProperty("divisionXpAirborne")]
                    public double DivisionXpAirborne { get; set; }
                    [JsonProperty("avgSpeed")]
                    public double AvgSpeed { get; set; }
                    [JsonProperty("avgKillDistance")]
                    public double AvgKillDistance { get; set; }
                    [JsonProperty("score")]
                    public double Score { get; set; }
                    [JsonProperty("totalXp")]
                    public double TotalXp { get; set; }
                    [JsonProperty("timePlayed")]
                    public double TimePlayed { get; set; }
                    [JsonProperty("matchesPlayed")]
                    public double MatchesPlayed { get; set; }
                    [JsonProperty("headshots")]
                    public double Headshots { get; set; }
                    [JsonProperty("divisionXpNone")]
                    public double DivisionXpNone { get; set; }
                    [JsonProperty("assists")]
                    public double Assists { get; set; }
                    [JsonProperty("scorePerMinute")]
                    public double ScorePerMinute { get; set; }
                    [JsonProperty("shotsFired")]
                    public double ShotsFired { get; set; }
                    [JsonProperty("deaths")]
                    public double Deaths { get; set; }
                }

            }
        }
    }
    
    public class Match
    {
        [JsonProperty("utcStartSeconds")]
        public int UtcStartSeconds { get; set; }
        [JsonProperty("utcEndSeconds")]
        public int UtcEndSeconds { get; set; }
        [JsonProperty("duration")]
        public int Duration { get; set; }
        [JsonProperty("map")]
        public string Map { get; set; }
        [JsonProperty("mode")]
        public string Mode { get; set; }
        [JsonProperty("result")]
        public string Result { get; set; }
        [JsonProperty("winningTeam")]
        public string WinningTeam { get; set; }
        [JsonProperty("privateMatch")]
        public bool PrivateMatch { get; set; }
        [JsonProperty("gameBattle")]
        public bool GameBattle { get; set; }
        [JsonProperty("playlistName")]
        public object PlaylistName { get; set; }
        [JsonProperty("player")]
        public Player MatchPlayer { get; set; }
        [JsonProperty("playerStats")]
        public PlayerStats MatchPlayerStats { get; set; }

        public class PlayerStats
        {
            [JsonProperty("kills")]
            public double Kills { get; set; }
            [JsonProperty("shotsMissed")]
            public double ShotsMissed { get; set; }
            [JsonProperty("kdRatio")]
            public double KdRatio { get; set; }
            [JsonProperty("distanceTravelled")]
            public double DistanceTravelled { get; set; }
            [JsonProperty("divisionXpMountain")]
            public double DivisionXpMountain { get; set; }
            [JsonProperty("accuracy")]
            public double Accuracy { get; set; }
            [JsonProperty("divisionXpExpeditionary")]
            public double DivisionXpExpeditionary { get; set; }
            [JsonProperty("divisionXpInfantry")]
            public double DivisionXpInfantry { get; set; }
            [JsonProperty("divisionXpArmored")]
            public double DivisionXpArmored { get; set; }
            [JsonProperty("shotsLanded")]
            public double ShotsLanded { get; set; }
            [JsonProperty("divisionXpAirborne")]
            public double DivisionXpAirborne { get; set; }
            [JsonProperty("avgSpeed")]
            public double AvgSpeed { get; set; }
            [JsonProperty("avgKillDistance")]
            public double AvgKillDistance { get; set; }
            [JsonProperty("score")]
            public double Score { get; set; }
            [JsonProperty("totalXp")]
            public double TotalXp { get; set; }
            [JsonProperty("timePlayed")]
            public double TimePlayed { get; set; }
            [JsonProperty("headshots")]
            public double Headshots { get; set; }
            [JsonProperty("divisionXpNone")]
            public double DivisionXpNone { get; set; }
            [JsonProperty("assists")]
            public double Assists { get; set; }
            [JsonProperty("shotsFired")]
            public double ShotsFired { get; set; }
            [JsonProperty("deaths")]
            public double Deaths { get; set; }
        }

        public class Player
        {
            [JsonProperty("awards")]
            public MatchAwards Awards { get; set; }
            [JsonProperty("team")]
            public string Team { get; set; }
            [JsonProperty("rank")]
            public double Rank { get; set; }
            [JsonProperty("prestige")]
            public double Prestige { get; set; }
            [JsonProperty("loadouts")]
            public List<MatchLoadout> Loadouts { get; set; }

            public class MatchAwards
            {
                [JsonProperty("longestKillstreak")]
                public double LongestKillstreak { get; set; }
                [JsonProperty("assists")]
                public double Assists { get; set; }
                [JsonProperty("killsConfirmed")]
                public double KillsConfirmed { get; set; }
                [JsonProperty("killsDenied")]
                public double KillsDenied { get; set; }
            }
            public class MatchLoadout
            {
                [JsonProperty("name")]
                public string Name { get; set; }
            }
        }
    }
}
