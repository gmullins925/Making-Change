using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Change
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Cost of the product -> ");
			decimal salesPrice = decimal.Parse(Console.ReadLine());

			Console.Write("Money collected from customer -> ");
			decimal cashRecvd = decimal.Parse(Console.ReadLine());

			decimal custChange = cashRecvd - salesPrice;

			Console.WriteLine($"The customer's change is {custChange:C}");

			Change change = new Change(custChange);

			Console.WriteLine($"100s: {change.HundredDollarBills}");
			Console.WriteLine($"50s: {change.FiveDollarBills}");
			Console.WriteLine($"20s: {change.TwentyDollarBills}");
			Console.WriteLine($"10s: {change.TenDollarBills}");
			Console.WriteLine($"5s: {change.FiveDollarBills}");
			Console.WriteLine($"1s: {change.DollarBills}");
			Console.WriteLine($"Quarters: {change.Quarters}");
			Console.WriteLine($"Dimes: {change.Dimes}");
			Console.WriteLine($"Nickels: {change.Nickels}");
			Console.WriteLine($"Pennies: {change.Pennies}");

			Console.ReadKey();
		}
	}

	public class Change
	{
		public int HundredDollarBills { get; }
		public int FiftyDollarBills { get; }
		public int TwentyDollarBills { get; }
		public int TenDollarBills { get; }
		public int FiveDollarBills { get; }
		public int DollarBills { get; }
		public int Quarters { get; }
		public int Dimes { get; }
		public int Nickels { get; }
		public int Pennies { get; }

		public Change(decimal price)
		{
			HundredDollarBills = (int)(price / 100);
			price %= 100;

			FiftyDollarBills = (int)(price / 50);
			price %= 50;

			TwentyDollarBills = (int)(price / 20);
			price %= 20;

			TenDollarBills = (int)(price / 10);
			price %= 10;

			FiveDollarBills = (int)(price / 5);
			price %= 5;

			DollarBills = (int)(price / 1);
			price %= 1;

			Quarters = (int)(price / .25m);
			price %= .25m;

			Dimes = (int)(price / .10m);
			price %= .10m;

			Nickels = (int)(price / .05m);
			price %= .05m;

			Pennies = (int)(price / .01m);
		}
	}
}
