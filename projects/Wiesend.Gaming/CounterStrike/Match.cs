#region Project Description [About this]
// =================================================================================
//            The whole Project is Licensed under the MIT License
// =================================================================================
// =================================================================================
//    Wiesend Gaming - Library is a project to make it easily to interact 
//    with the 'GET5' server plugin, to easily maintain competitive matches.
//
//    I tried my very best to mention all of the original copyright holders. 
//    I hope that all code which I've copied from others is mentioned and all 
//    their copyrights are given. The copied code (or code snippets) could 
//    already be modified by me or others.
// =================================================================================
#endregion of Project Description
#region Original Source Code [Links to all original source code]
// =================================================================================
//          Original Source Code [Links to all original source code]
// =================================================================================
// =================================================================================
//    I wrote this source totally on my own, so this piece of code is 
//    totally mine, fuck yeah, I'm the best!
// =================================================================================
#endregion of where is the original source code
#region Licenses [MIT Licenses]
#region MIT License [Dominik Wiesend]
// =================================================================================
//    Copyright(c) 2018 Dominik Wiesend. All rights reserved.
//    
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:
//    
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
//    
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.
// =================================================================================
#endregion of MIT License [Dominik Wiesend] 
#endregion of Licenses [MIT Licenses]

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wiesend.Gaming.CounterStrike.Enums;
using System.Collections.Generic;
using Newtonsoft.Json;
using Wiesend.DataTypes;
using Wiesend.Gaming.CounterStrike.Enums.JsonConverter;

namespace Wiesend.Gaming.CounterStrike
{
    /// <summary>
    /// This is a competitive 
    /// match configuration.
    /// </summary>
    [Table("Match")]
    public partial class Match
    {
        /// <summary>
        /// Unique identifier of a competitive match.
        /// </summary>
        [Key]
        [Required]
        [Column(Order = 0)]
        [JsonProperty("matchid", Required = Required.Always, Order = 0)]
        public Guid MatchId { get; private set; }

        /// <summary>
        /// The name of the Match (ServerName);
        /// Default: "MatchMaking"
        /// </summary>
        [Required]
        [StringLength(50)]
        [Column(Order = 1)]
        [JsonIgnoreAttribute]
        public string MatchName { get; set; }

        /// <summary>
        /// Team #1 of the Match which 
        /// will play against Team #2.
        /// </summary>
        [Required]
        [Column(Order = 2)]
        [JsonProperty("team1", Required = Required.Always, Order = 10)]
        public virtual Team Team1 { get; set; }

        /// <summary>
        /// Team #2 of the Match which 
        /// will play against Team #1.
        /// </summary>
        [Required]
        [Column(Order = 3)]
        [JsonProperty("team2", Required = Required.Always, Order = 11)]
        public virtual Team Team2 { get; set; }

        /// <summary>
        /// Amount of players per team.
        /// Default: "5"
        /// </summary>
        [Required]
        [Column(Order = 4)]
        [JsonProperty("players_per_team", Required = Required.Always, Order = 2)]
        public int PlayersPerTeam { get; set; }

        /// <summary>
        /// Minimum players to start (force).
        /// Default: "1"
        /// </summary>
        [Required]
        [Column(Order = 5)]
        [JsonProperty("min_players_to_ready", Required = Required.Always, Order = 3)]
        public int MinPlayersToStart { get; set; }

        /// <summary>
        /// Minimum spectators to start (admins).
        /// Default: "0"
        /// </summary>
        [Required]
        [Column(Order = 6)]
        [JsonProperty("min_spectators_to_ready", Required = Required.Always, Order = 4)]
        public int MinSpectatorsToStart { get; set; }

        /// <summary>
        /// Amount of maps to win (should be a odd number).
        /// You can use 1, 3 or 5 as an example (BestOf).
        /// Default: "3"
        /// </summary>
        [Required]
        [Column(Order = 7)]
        [JsonProperty("num_maps", Required = Required.Always, Order = 1)]
        public int MapsToWin { get; set; }

        /// <summary>
        /// The Maps to play (Vetoable)
        /// Default: "de_cache;de_cbble;de_inferno;de_mirage;de_nuke;de_overpass;de_train"
        /// </summary>
        [Required]
        [Column(Order = 8)]
        [JsonProperty("maplist", Required = Required.Always, Order = 9)]
        public List<string> MapList { get; set; }

        /// <summary>
        /// Which side type should be used.
        /// Default: "Standard"
        /// </summary>
        [Required]
        [Column(Order = 9)]
        [JsonProperty("side_type", Required = Required.Always, Order = 7)]
        [JsonConverter(typeof(SideTypesConverter))]
        public SideTypes SideType { get; set; }

        /// <summary>
        /// Which team is voting first. 
        /// Default: "Team #1"
        /// </summary>
        [Required]
        [Column(Order = 10)]
        [JsonProperty("veto_first", Required = Required.Always, Order = 6)]
        [JsonConverter(typeof(VetoFirstConverter))]
        public VetoFirst VetoFirst { get; set; }

        /// <summary>
        /// Disable that the teams can veto 
        /// (choose) the maps to play.
        /// Default: "False"
        /// </summary>
        [Required]
        [Column(Order = 11)]
        [JsonProperty("skip_veto", Required = Required.Always, Order = 5)]
        public bool DisableMapVeto { get; set; }

        /// <summary>
        /// Spectators of the Match (Live) .
        /// </summary>
        [Required]
        [Column(Order = 12)]
        [JsonProperty("spectators", Required = Required.Always, Order = 8)]
        public virtual Spectators Spectators { get; set; }

        /// <summary>
        /// Custom [Cvars] of this match.
        /// </summary>
        [NotMapped]
        [JsonProperty("cvars", Required = Required.Always, Order = 12)]
        Dictionary<string, string> Cvars
        {
            get
            {
                Dictionary<string, string> value = new Dictionary<string, string>();
                value.Add("hostname", this.MatchName);
                return value;
            }
        }

        /// <summary>
        /// Constructor of Match.
        /// </summary>
        public Match()
        {
            // <summary>
            // Create a new unique identifier of the match.
            // </summary>
            this.MatchId = Guid.NewGuid();

            // <summary>
            // Setting up match defaults.
            // </summary>
            this.MatchName = "MatchMaking";
            this.MapsToWin = 3;
            this.PlayersPerTeam = 5;
            this.MinPlayersToStart = 1;
            this.MinSpectatorsToStart = 0;
            this.VetoFirst = VetoFirst.Team1;
            this.SideType = SideTypes.Standard;

            // <summary>
            // Default map list.
            // </summary>
            this.MapList = new List<string>()
            {
                "de_cache",
                "de_cbble",
                "de_inferno",
                "de_mirage",
                "de_nuke",
                "de_overpass",
                "de_train"
            };
        }
    }        
}
