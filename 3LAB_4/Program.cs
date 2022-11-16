using System;
using System.Linq;

namespace _3LAB_4
{
	public class Program
	{
     	delegate int Arr(int x);
			[STAThread]
		public static void Main (string[] args)
		{
			int[] array1 = { 5, 6, 7, 8 };  
			int[] array2 = { 9, 0, 1, 2 };

		 if  (	array1.ToList().All(x => array2.Contains(x)))  //lamda expression
            {
				Console.WriteLine("arrays are equal");
			}
			else
            {
				Console.WriteLine("arrays are not equal");
			}

			var trafficexcess = new Trafficexcess() { Name = " internet provider" };
			var InternetService = new InternetService();   //publisher
			var customer = new Customer(); // subscriber
			var host = new InternetHost(); // another subscriber

			//subscribing to the event
			InternetService.InternetServiced += customer.OnInternetServiced;
			InternetService.InternetServiced += host.OnInternetServiced;

			InternetService.Internet(trafficexcess);

		}
	} 
}

