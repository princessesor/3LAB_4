using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _3LAB_4
{
    class Customer
    { 
        public void OnInternetServiced(object source, TrafficexcessEventArgs e)
        {
            Console.WriteLine("Customer: Trying to access tariff plan.." + e.Trafficexcess.Name);
            
        }
    }
}
