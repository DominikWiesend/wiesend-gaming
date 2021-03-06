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

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wiesend.Gaming.CounterStrike
{
    /// <summary>
    /// Steam account is a class which 
    /// shows the SteamId of an account.
    /// </summary>
    [Table("SteamAccount")]
    public class SteamAccount
    {
        /// <summary>
        /// SteamAccountId is the unique identifiert of the 
        /// steam account in the database (not the SteamId).
        /// </summary>
        [Key]
        [Required]
        public Guid SteamAccountId { get; private set; }

        /// <summary>
        /// The SteamIDs (Unique identifiers) of the Player 
        /// (Main account and maybe one of his additional accounts).
        /// </summary>
        [Required]
        public string SteamId { get; set; }

        /// <summary>
        /// Constructor of SteamAccount.
        /// </summary>
        private SteamAccount()
        {
            // <summary>
            // Create a new unique identifier of the SteamAccount.
            // </summary>
            this.SteamAccountId = Guid.NewGuid();
        }

        /// <summary>
        /// Constructor of SteamAccount.
        /// </summary>
        public SteamAccount(string SteamId)
        {
            // <summary>
            // Create a new unique identifier of the SteamAccount.
            // </summary>
            this.SteamAccountId = Guid.NewGuid();

            // <summary>
            // Set the values from the constructor.
            // </summary>
            this.SteamId = SteamId;
        }
    }
}
