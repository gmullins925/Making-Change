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

			decimal change = cashRecvd - salesPrice;

			decimal quarters = 0, dimes = 0, nickels = 0, pennies = 0;

			while (change >= 0.25m)
			{
				quarters = Math.Truncate((change / 0.25m));
				change = change % 0.25m;
			}

			while (change >= 0.10m)
			{
				dimes = Math.Truncate((change / 0.10m));
				change = change % 0.10m;
			}

			while (change >= 0.05m)
			{
				nickels = Math.Truncate((change / 0.05m));
				change = change % 0.05m;
			}

			while (change >= 0.01m)
			{
				pennies = Math.Truncate((change / 0.01m));
				change = change % 0.01m;
			}

			Console.WriteLine("{0} quarters, {1} dimes, {2} nickels, {3} pennies", quarters,
				dimes, nickels, pennies);

			Console.ReadLine();
		}
	}
}
