using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CallOfDuty.Lib
{
    public class UserProfile
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("data")]
        public Data PlayerData { get; set; }

        public class Data
        {
            [JsonProperty("title")]
            public string Title { get; set; }
            [JsonProperty("platform")]
            public string Platform { get; set; }
            [JsonProperty("username")]
            public string Username { get; set; }
            [JsonProperty("mp")]
            public Mp MultiPlayerMode { get; set; }
            [JsonProperty("zombies")]
            public Zombies ZombiesMode { get; set; }
            [JsonProperty("engagement")]
            public object Engagement { get; set; }

            public class Mp
            {
                [JsonProperty("lifetime")]
                public Lifetime LifetimeStats { get; set; }
                [JsonProperty("weekly")]
                public Weekly WeeklyStats { get; set; }
                [JsonProperty("level")]
                public double Level { get; set; }
                [JsonProperty("maxLevel")]
                public double MaxLevel { get; set; }
                [JsonProperty("levelXpRemainder")]
                public double LevelXpRemainder { get; set; }
                [JsonProperty("levelXpGained")]
                public double LevelXpGained { get; set; }
                [JsonProperty("prestige")]
                public double Prestige { get; set; }
                [JsonProperty("prestigeId")]
                public double PrestigeId { get; set; }
                [JsonProperty("maxPrestige")]
                public double MaxPrestige { get; set; }

                public class Lifetime
                {
                    [JsonProperty("all")]
                    public All Career { get; set; }
                    [JsonProperty("mode")]
                    public Mode GameMode { get; set; }

                    public class All
                    {
                        [JsonProperty("kills")]
                        public double Kills { get; set; }
                        [JsonProperty("accuracy")]
                        public double Accuracy { get; set; }
                        [JsonProperty("losses")]
                        public double Losses { get; set; }
                        [JsonProperty("timePlayedAllies")]
                        public double TimePlayedAllies { get; set; }
                        [JsonProperty("points")]
                        public double Points { get; set; }
                        [JsonProperty("score")]
                        public double Score { get; set; }
                        [JsonProperty("totalXp")]
                        public double TotalXp { get; set; }
                        [JsonProperty("headshots")]
                        public double Headshots { get; set; }
                        [JsonProperty("plants")]
                        public double Plants { get; set; }
                        [JsonProperty("deaths")]
                        public double Deaths { get; set; }
                        [JsonProperty("wins")]
                        public double Wins { get; set; }
                        [JsonProperty("killStreak")]
                        public double KillStreak { get; set; }
                        [JsonProperty("kdRatio")]
                        public double KdRatio { get; set; }
                        [JsonProperty("destructions")]
                        public double Destructions { get; set; }
                        [JsonProperty("captures")]
                        public double Captures { get; set; }
                        [JsonProperty("bestScore")]
                        public double BestScore { get; set; }
                        [JsonProperty("winStreak")]
                        public double WinStreak { get; set; }
                        [JsonProperty("bestKills")]
                        public double BestKills { get; set; }
                        [JsonProperty("timePlayed")]
                        public double TimePlayed { get; set; }
                        [JsonProperty("matchesPlayed")]
                        public double MatchesPlayed { get; set; }
                        [JsonProperty("suicides")]
                        public double Suicides { get; set; }
                        [JsonProperty("money")]
                        public double Money { get; set; }
                        [JsonProperty("currentWinStreak")]
                        public double CurrentWinStreak { get; set; }
                        [JsonProperty("prestigeShopTokens")]
                        public double PrestigeShopTokens { get; set; }
                        [JsonProperty("matchesCompleted")]
                        public double MatchesCompleted { get; set; }
                        [JsonProperty("unlockPoints")]
                        public double UnlockPoints { get; set; }
                    }
                    public class Mode
                    {
                        [JsonProperty("dm")]
                        public Dm FreeForAll { get; set; }                     
                        [JsonProperty("dom_hc")]
                        public DomHc FreeForAllHC { get; set; }
                        [JsonProperty("gun")]
                        public Gun GunGame { get; set; }
                        [JsonProperty("dom")]
                        public Dom Domination { get; set; }
                        [JsonProperty("dm_hc")]
                        public DmHc DominationHC { get; set; }
                        [JsonProperty("hp")]
                        public Hp HardPoint { get; set; }
                        [JsonProperty("ball")]
                        public Ball Gridiron { get; set; }
                        [JsonProperty("sd_hc")]
                        public SdHc SearchAndDestroydHC { get; set; }
                        [JsonProperty("sd")]
                        public Sd SearchAndDestroy { get; set; }
                        [JsonProperty("ctf")]
                        public Ctf CaptureTheFlag { get; set; }
                        [JsonProperty("conf_hc")]
                        public ConfHc KillConfirmedHC { get; set; }
                        [JsonProperty("conf")]
                        public Conf KillConfirmed { get; set; }
                        [JsonProperty("war")]
                        public War TeamDeathMatch { get; set; }
                        [JsonProperty("war_hc")]
                        public WarHc TeamDeathMatchHC { get; set; }

                        public class Gun
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("stabs")]
                            public double Stabs { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("mostStabs")]
                            public double MostStabs { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("mostGunPromotions")]
                            public double MostGunPromotions { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                            [JsonProperty("gunPromotions")]
                            public double GunPromotions { get; set; }
                        }
                        public class Dom
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("mostdefends")]
                            public double Mostdefends { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("mostcaptures")]
                            public double Mostcaptures { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("defends")]
                            public double Defends { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("captures")]
                            public double Captures { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class DmHc
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("headshots")]
                            public double Headshots { get; set; }
                            [JsonProperty("mostkills")]
                            public double Mostkills { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("bestkdr")]
                            public double Bestkdr { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("assists")]
                            public double Assists { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class ConfHc
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("denies")]
                            public double Denies { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("mostconfirms")]
                            public double Mostconfirms { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("confirms")]
                            public double Confirms { get; set; }
                            [JsonProperty("mostdenies")]
                            public double Mostdenies { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class Hp
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("mostdefends")]
                            public double Mostdefends { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("mostcaptures")]
                            public double Mostcaptures { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("defends")]
                            public double Defends { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("captures")]
                            public double Captures { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("totalHPTime")]
                            public double TotalHPTime { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class War
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("headshots")]
                            public double Headshots { get; set; }
                            [JsonProperty("mostkills")]
                            public double Mostkills { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("bestkdr")]
                            public double Bestkdr { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("assists")]
                            public double Assists { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class Dm
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("headshots")]
                            public double Headshots { get; set; }
                            [JsonProperty("mostkills")]
                            public double Mostkills { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("bestkdr")]
                            public double Bestkdr { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("assists")]
                            public double Assists { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class Conf
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("denies")]
                            public double Denies { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("mostconfirms")]
                            public double Mostconfirms { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("confirms")]
                            public double Confirms { get; set; }
                            [JsonProperty("mostdenies")]
                            public double Mostdenies { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class SdHc
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("plants")]
                            public double Plants { get; set; }
                            [JsonProperty("detonates")]
                            public double Detonates { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("mostdefuses")]
                            public double Mostdefuses { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("defuses")]
                            public double Defuses { get; set; }
                            [JsonProperty("mostplants")]
                            public double Mostplants { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                            [JsonProperty("mostdetonates")]
                            public double Mostdetonates { get; set; }
                        }
                        public class DomHc
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("mostdefends")]
                            public double Mostdefends { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("mostcaptures")]
                            public double Mostcaptures { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("defends")]
                            public double Defends { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("captures")]
                            public double Captures { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class WarHc
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("headshots")]
                            public double Headshots { get; set; }
                            [JsonProperty("mostkills")]
                            public double Mostkills { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("bestkdr")]
                            public double Bestkdr { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("assists")]
                            public double Assists { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class Ball
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("killedBallCarrier")]
                            public double KilledBallCarrier { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("mostKilledBallCarrier")]
                            public double MostKilledBallCarrier { get; set; }
                            [JsonProperty("mostPointsScored")]
                            public double MostPointsScored { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("pointsScored")]
                            public double PointsScored { get; set; }
                            [JsonProperty("carries")]
                            public double Carries { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                        public class Sd
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("plants")]
                            public double Plants { get; set; }
                            [JsonProperty("detonates")]
                            public double Detonates { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("mostdefuses")]
                            public double Mostdefuses { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("defuses")]
                            public double Defuses { get; set; }
                            [JsonProperty("mostplants")]
                            public double Mostplants { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                            [JsonProperty("mostdetonates")]
                            public double Mostdetonates { get; set; }
                        }
                        public class Ctf
                        {
                            [JsonProperty("timePlayed")]
                            public double TimePlayed { get; set; }
                            [JsonProperty("xpEarned")]
                            public double XpEarned { get; set; }
                            [JsonProperty("mostreturns")]
                            public double Mostreturns { get; set; }
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("timeStampLastGame")]
                            public double TimeStampLastGame { get; set; }
                            [JsonProperty("mostcaptures")]
                            public double Mostcaptures { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
                            [JsonProperty("losses")]
                            public double Losses { get; set; }
                            [JsonProperty("returns")]
                            public double Returns { get; set; }
                            [JsonProperty("score")]
                            public double Score { get; set; }
                            [JsonProperty("deaths")]
                            public double Deaths { get; set; }
                            [JsonProperty("numMatches")]
                            public double NumMatches { get; set; }
                            [JsonProperty("captures")]
                            public double Captures { get; set; }
                            [JsonProperty("ties")]
                            public double Ties { get; set; }
                            [JsonProperty("timeStampFirstGame")]
                            public double TimeStampFirstGame { get; set; }
                        }
                    }
                }

                public class Weekly
                {
                    [JsonProperty("all")]
                    public All Stats { get; set; }
                    [JsonProperty("mode")]
                    public Mode ModeStats { get; set; }
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
                    public class Mode
                    {
                        [JsonProperty("dm hc")]
                        public Dmhc FreeForAllHC { get; set; }
                        [JsonProperty("ball")]
                        public Ball Gridiron { get; set; }
                        [JsonProperty("dom")]
                        public Dom Domination { get; set; }
                        [JsonProperty("ctf")]
                        public Ctf CaptureTheFlag { get; set; }
                        [JsonProperty("conf hc")]
                        public Confhc KillConfirmedHC { get; set; }
                        [JsonProperty("hp")]
                        public Hp HardPoint { get; set; }
                        [JsonProperty("war hc")]
                        public WarModeHC TeamDeathMatchHC { get; set; }
                        [JsonProperty("war")]
                        public WarMode TeamDeathMatch { get; set; }
                        [JsonProperty("conf")]
                        public Conf KillConfirmed { get; set; }
                        [JsonProperty("dom hc")]
                        public Domhc DominationHC { get; set; }
                        [JsonProperty("raid")]
                        public Raid War { get; set; }

                        public class Dmhc
                        {
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
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
                        public class Ball
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
                        public class Dom
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
                        public class Confhc
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
                        public class Hp
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
                        public class WarModeHC
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
                        public class WarMode
                        {
                            [JsonProperty("kills")]
                            public double Kills { get; set; }
                            [JsonProperty("wins")]
                            public double Wins { get; set; }
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
                        public class Conf
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
                        public class Domhc
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
                        public class Raid
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
                    }
                }
            }

            public class Zombies
            {
                [JsonProperty("lifetime")]
                public Lifetime LifetimeStats { get; set; }
                [JsonProperty("weekly")]
                public Weekly WeeklyStats { get; set; }

                public class Lifetime
                {
                    [JsonProperty("all")]
                    public Dictionary<string, string> All { get; set; }
                    [JsonProperty("mode")]
                    public Dictionary<string, string> Mode { get; set; }
                }
                public class Weekly
                {
                    [JsonProperty("all")]
                    public Dictionary<string, string> All { get; set; }
                    [JsonProperty("mode")]
                    public Dictionary<string, string> Mode { get; set; }
                }
            }
        }
    }

}
