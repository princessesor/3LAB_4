using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _3LAB_4
{
    public class TrafficexcessEventArgs : EventArgs
    {
        public Trafficexcess Trafficexcess { get; set; }
    }
   public class InternetService
    {
      
      
        public delegate void InternetServiceEventHandler(object source, TrafficexcessEventArgs args);

        public event InternetServiceEventHandler InternetServiced; 
        public void Internet(Trafficexcess trafficexcess )
        {
            Console.WriteLine("Granting access to user...");
            Thread.Sleep(2500);

            OnInternetServiced(trafficexcess);
        }

        protected virtual void OnInternetServiced(Trafficexcess trafficexcess)
        {
            if (InternetServiced != null)
                InternetServiced(this, new TrafficexcessEventArgs() { Trafficexcess = trafficexcess });
        }
    }
}
