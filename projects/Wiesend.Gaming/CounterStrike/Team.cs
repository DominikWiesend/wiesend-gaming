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

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wiesend.DataTypes;

namespace Wiesend.Gaming.CounterStrike
{
    /// <summary>
    /// Team config of a competitive match.
    /// </summary>
    [Table("Team")]
    public partial class Team
    {
        /// <summary>
        /// TeamId is the unique identifiert of 
        /// the team in the database.
        /// </summary>
        [Key]
        [Required]
        [JsonIgnore]
        public Guid TeamId { get; private set; }

        /// <summary>
        /// Team name is the name of the team.
        /// </summary>
        [Required]
        [JsonProperty("name", Required = Required.Always)]
        public string TeamName { get; set; }

        /// <summary>
        /// Team tag is the tag 
        /// (short name) of the Team.
        /// </summary>
        [Required]
        [JsonProperty("tag", Required = Required.Always)]
        public string TeamTag { get; set; }

        /// <summary>
        /// Team Flag is the flag of 
        /// the team (National flag).
        /// </summary>
        [Required]
        [StringLength(2)]
        [JsonProperty("flag", Required = Required.Always)]
        public string TeamFlag { get; set; }

        /// <summary>
        /// Team Logo is the logo of the team.
        /// </summary>
        [JsonProperty("logo", Required = Required.AllowNull)]
        public string Logo { get; set; }

        /// <summary>
        /// Team members is a list of players 
        /// which are member of the team.
        /// </summary>
        [Required]
        [JsonIgnore]
        public virtual ICollection<Player> Players { get; set; }

        /// <summary>
        /// The SteamIDs (Unique identifiers) of the Player 
        /// (Main account and maybe there additional accounts).
        /// --> Serialize for the config file!
        /// </summary>
        [NotMapped]
        [JsonProperty("players", Required = Required.Always)]
        private List<string> SteamAccounts
        {
            get
            {
                List<string> value = new List<string>();
                foreach (Player player in this.Players)
                    foreach (SteamAccount account in player.SteamAccounts)
                        value.Add(account.SteamId);
                return value;
            }
        }

        /// <summary>
        /// Constructor of Team.
        /// </summary>
        public Team()
        {
            // <summary>
            // Create a new unique identifier of the Team.
            // </summary>
            this.TeamId = Guid.NewGuid();
        }
    }
}
