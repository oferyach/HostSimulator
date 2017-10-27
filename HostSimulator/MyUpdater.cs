using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace HostSimulator
{
    class MyUpdater
    {
        public bool HasData = false;
        public bool HasAnswer = false;
        public string indata = "";
        public string databack = "";
        public MyUpdater()
        {

        }
        public void Worker()
        {
            ServiceHost host;
            Type serviceType = typeof(HostService);
            host = new ServiceHost(serviceType);
            host.Open();
             
            while (true)
            {               
                /*
                if (HasData)
                {
                    HasData = false;
                    UpdateTextDelegate handler = TextUpdater;
                    if (handler != null)
                    {
                        handler(this, new UpdateTextEventArgs(indata));
                    }
                    databack = "Back to you";
                    HasAnswer = true;

                    return; //end this thread
                }
                 */ 
                 
                Thread.Sleep(10);
            }
        }
        public static UpdateTextDelegate TextUpdater { get; set; }
    
    }
}
