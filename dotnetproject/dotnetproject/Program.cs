using System;

namespace dotnetproject
{
		public class Program
		{
			public static void Main()
			{
				Math math = new Math();
			Console.WriteLine("Please enter a number name:");
			math.OneNumber = Convert.ToInt32(Console.ReadLine());				
			Console.WriteLine("Please enter a number name:");
			math.TwoNumber = Convert.ToInt32(Console.ReadLine());

				int area = math.OneNumber * math.TwoNumber;
				Console.WriteLine(area);
			}
		}
	}