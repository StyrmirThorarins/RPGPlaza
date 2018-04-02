using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Services
{
    /// <summary>
    /// Keep alive template from https://weblog.west-wind.com/posts/2007/May/10/Forcing-an-ASPNET-Application-to-stay-alive.
    /// </summary>
    public class KeepAlive2
    {
        ///  
        /// This is the manager class that handles running the email operation on a background thread
        ///  
        public class Scheduler : IDisposable
        {
            ///  
            /// Determines the status fo the Scheduler
            ///          
            public bool Cancelled
            {
                get { return _Cancelled; }
                set { _Cancelled = value; }
            }
            private bool _Cancelled = false;
            ///  
            /// The frequency of checks against hte POP3 box are 
            /// performed in Seconds.
            ///  
            private int CheckFrequency = 180;
            EmailForwarder Forwarder = new EmailForwarder();
            AutoResetEvent WaitHandle = new AutoResetEvent(false);
            object SyncLock = new Object();
            public Scheduler()
            {
            }
            ///  
            /// Starts the background thread processing       
            ///  
            ///  Frequency that checks are performed in seconds
            public void Start(int checkFrequency)
            {
                this.Forwarder.DeleteMessages = App.Configuration.DeletePop3Messages;
                // *** Ensure that any waiting instances are shut down
                //this.WaitHandle.Set();
                this.CheckFrequency = checkFrequency;
                this.Cancelled = false;
                Thread t = new Thread(Run);
                t.Start();
            }
            ///  
            /// Causes the processing to stop. If the operation is still
            /// active it will stop after the current message processing
            /// completes
            ///  
            public void Stop()
            {
                lock (this.SyncLock)
                {
                    if (Cancelled)
                        return;
                    this.Cancelled = true;
                    this.WaitHandle.Set();
                }
            }
            ///  
            /// Runs the actual processing loop by checking the mail box
            ///  
            private void Run()
            {
                this.Forwarder.LogMessage("...Starting Service", true);
                // *** Start out  waiting
                this.WaitHandle.WaitOne(this.CheckFrequency * 1000, true);
                while (!Cancelled)
                {
                    if (App.Configuration.LogDetail)
                        this.Forwarder.LogMessage("...Checking mailbox...", true);
                    if (!this.Forwarder.ProcessMessages())
                        this.Forwarder.LogMessage("...Processing failed: " + Forwarder.ErrorMessage, false);
                    else
                    {
                        if (App.Configuration.LogDetail)
                            this.Forwarder.LogMessage("...Processing completed", true);
                    }
                    // *** Http Ping to force the server to stay alive 
                    this.PingServer();
                    // *** Put in 
                    this.WaitHandle.WaitOne(this.CheckFrequency * 1000, true);
                }
                this.Forwarder.LogMessage("...Shutting down service", true);
            }
            public void PingServer()
            {
                try
                {
                    WebClient http = new WebClient();
                    string Result = http.DownloadString(App.Configuration.PingUrl);
                }
                catch (Exception ex)
                {
                    string Message = ex.Message;
                }
            }
            #region IDisposable Members
            public void Dispose()
            {
                this.Stop();
            }
            #endregion
        }
    }
}
