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
using Wiesend.DataTypes.Patterns.BaseClasses;

namespace Wiesend.Gaming.GlobalConfiguration
{
    /// <summary>
    /// Global Logging class (Singleton) to 
    /// log errors and information.
    /// </summary>
    internal class Logging : Singleton<Logging>, IDisposable
    {
        /// <summary>
        /// Flag: Has Dispose already been called?
        /// </summary>
        private bool disposed = false;

        /// <summary>
        /// [LibraryLogger] is a private member which holds the [Log] which 
        /// we use to log the messages of the library.
        /// </summary>
        private Wiesend.Logging.Logger LibraryLogger = null;

        /// <summary>
        /// [LibraryLog] is a internal member of type [Log] and 
        /// is used to log the messages of the library.
        /// </summary>
        internal Wiesend.Logging.Log LibraryLog { get; private set; }

        /// <summary>
        /// [LoggingConfiguration] is the constructor to initilize this class and
        /// sets all private members of it.
        /// </summary>
        protected Logging()
        {
            // <summary>
            // Create the [LibraryLogger] and add the 
            // [LibraryLog] to the logger.
            // </summary>
            LibraryLogger = new Wiesend.Logging.Logger();
            LibraryLogger.AddLog("LibraryLog");
            LibraryLog = (Wiesend.Logging.Log)LibraryLogger.GetLog("LibraryLog");
        }

        /// <summary>
        /// The destructor of [Logging] which is needed because he class implements a class which 
        /// needs to be disposed (inherits [IDisposable]).
        /// </summary>
        ~Logging()
        {
            // <summary>
            // Finalizer calls Dispose(false)  
            // </summary>
            Dispose(false);
        }

        /// <summary>
        /// The dispose function which is called only when you dispose the instance manually by calling
        /// [instanceName.Dispose()]. The dispose function is needed because we have a class member which 
        /// is an [Disposable] and needs to be disposed.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The dispose function which is called by the finalizer and when you dispose the instance manually by calling
        /// [instanceName.Dispose()]. This is needed because we don't want that this class will be disposed when it is 
        /// called by the finalizer.
        /// </summary>
        /// <param name="disposing">Dispose all members of this class? (object instances), finalizer (false), manually (true)</param>
        protected virtual void Dispose(bool disposing)
        {
            // <summary>
            // Was dispose already called once?
            // </summary>
            if (disposed)
                return;

            // <summary>
            // Free all managed resources (all classes which inherits [IDisposable].)
            // </summary>
            if (disposing)
            {
                // <summary>
                // Free the [LibraryLogger] resource.
                // </summary>
                if (this.LibraryLogger != null)
                {
                    this.LibraryLogger.Dispose();
                    this.LibraryLogger = null;
                }

                // <summary>
                // Free all native resources.
                // </summary>
                this.LibraryLog = null;

                // <summary>
                // Set object as disposed.
                // </summary>
                this.disposed = true;
            }
        }
    }
}
