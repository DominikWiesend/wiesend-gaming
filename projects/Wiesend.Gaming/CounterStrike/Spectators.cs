﻿#region Project Description [About this]
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
    /// Spectators of the Match (Live).
    /// </summary>
    [Table("Spectators")]
    public class Spectators
    {
        /// <summary>
        /// SpectatorsId is the unique identifiert of 
        /// the team in the database.
        /// </summary>
        [Key]
        [Required]
        [Column(Order = 0)]
        [JsonIgnore]
        public Guid SpectatorsId { get; private set; }

        /// <summary>
        /// List of users (SteamIds) which can 
        /// connect to the "Spectators".
        /// </summary>
        [Required]
        [Column(Order = 1)]
        [JsonIgnore]
        public virtual ICollection<Player> Players { get; set; }

        /// <summary>
        /// The SteamIDs (Unique identifiers) of the Players which are allowed 
        /// to join the "Spectators" of this match.
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
        /// Constructor of Spectators.
        /// </summary>
        public Spectators()
        {
            // <summary>
            // Create a new unique identifier of the Spectators.
            // </summary>
            this.SpectatorsId = Guid.NewGuid();
        }
    }
}