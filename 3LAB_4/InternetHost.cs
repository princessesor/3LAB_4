using System;
using System.Collections.Generic;
using System.Text;

namespace _3LAB_4
{
    class InternetHost
    {
        public void OnInternetServiced(object source, TrafficexcessEventArgs e)
        {
            Console.WriteLine("Internethost: Gathering internet usage..." + e.Trafficexcess.Name);

        }
    }
}
