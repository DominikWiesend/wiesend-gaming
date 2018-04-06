using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiesend.DataTypes;
using Wiesend.DataTypes.Comparison;
using Wiesend.Gaming.CounterStrike;
using Wiesend.Gaming.DatabaseManagement.Databases;

namespace Wiesend.Gaming
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pDominikWiesend = new Person("Dominik", "Wiesend");
            Person pBenediktWiesend = new Person("Benedikt", "Wiesend");

            SteamAccount saDominikWiesend = new SteamAccount("STEAM:0:05642354");
            SteamAccount saBenediktWiesend = new SteamAccount("STEAM:0:213124354");
            Player plDominikWiesend = new Player()
            {
                Person = pDominikWiesend,
                SteamAccounts = new List<SteamAccount>() { saDominikWiesend }
            };
            Player plBenediktWiesend = new Player()
            {
                Person = pBenediktWiesend,
                SteamAccounts = new List<SteamAccount>() { saBenediktWiesend }
            };

            // <summary>
            // Create Team #1
            // </summary>
            Team team1 = new Team();
            team1.TeamFlag = "DE";
            team1.TeamName = "DominikWiesend";
            team1.TeamTag = "DW";
            team1.Logo = string.Empty;
            team1.Players = new List<Player>() { plDominikWiesend };

            // <summary>
            // Create Team #2
            // </summary>
            Team team2 = new Team();
            team2.TeamFlag = "DE";
            team2.TeamName = "BenediktWiesend";
            team2.TeamTag = "BW";
            team2.Logo = string.Empty;
            team2.Players = new List<Player>() { plBenediktWiesend };

            // <summary>
            // Create a new spectators team.
            // </summary>
            Spectators spectators = new Spectators()
            {
                Players = new List<Player>()
                {
                    plDominikWiesend,
                    plBenediktWiesend
                }
            };

            // <summary>
            // Create a new Match
            // </summary>
            Match match = new Match();
            match.Team1 = team1;
            match.Team2 = team2;
            match.Spectators = spectators;
            match.MatchName = "Dominik [vs] Benedikt";

            // <summary>
            // Save the Match to the database.
            // </summary>
            using (CSGOServerDatabase dbContext = new CSGOServerDatabase())
            {

                dbContext.Persons.Add(pDominikWiesend);
                dbContext.Persons.Add(pBenediktWiesend);
                dbContext.SteamAccounts.Add(saDominikWiesend);
                dbContext.SteamAccounts.Add(saBenediktWiesend);
                dbContext.Players.Add(plDominikWiesend);
                dbContext.Players.Add(plBenediktWiesend);
                dbContext.Spectators.Add(spectators);
                dbContext.Teams.Add(team1);
                dbContext.Teams.Add(team2);
                dbContext.Matches.Add(match);
                dbContext.SaveChanges();
            }

            // <summary>
            // Get all match config(s) from Database.
            // </summary>
            #region
            // <summary>
            // Create a new database context connection.
            // </summary>
            using (CSGOServerDatabase dbContext = new CSGOServerDatabase())
            {
                List<Match> matches = dbContext.Matches.ToList();
                foreach (Match myMatch in matches)
                {
                    string json = JsonConvert.SerializeObject(myMatch, Formatting.Indented);
                    Console.WriteLine(json);
                    Console.ReadKey();
                }
            }
            #endregion
        }
    }
}
