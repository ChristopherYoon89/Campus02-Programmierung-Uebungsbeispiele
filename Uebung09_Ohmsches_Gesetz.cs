using System;

namespace UEBUNG9

{
	class Program
	{
		static void Main(string[] args)
		{
			// Print program header
			Console.WriteLine("------------------------");
			Console.WriteLine("Übung 9");
			Console.WriteLine("Christopher Yoon");
			Console.WriteLine("Ohmsche App");
			Console.WriteLine("------------------------");
			Console.Write("\n");

			// Declare variables and asign values
			float current = 0;
			uint resistance = 0;

			string current_input = "";
			string resistance_input = "";

			double res_current = 0;
			double res_power = 0;			

			// Get input from user and convert input
			Console.WriteLine("Berechnung der Spannung:\n");
			Console.Write("Stromstärke (in Ampere) = ");
			current_input = Console.ReadLine();
			current = Convert.ToSingle(current_input);
			
			Console.Write("\nWiderstand (in Ohm) = ");
			resistance_input = Console.ReadLine();
			resistance = Convert.ToUInt32(resistance_input);

			// Calculate results
			res_current = current * resistance;
			Console.WriteLine($"\nSpannung (in Volt) = {res_current}");
			
			res_power = current * current * resistance;
			Console.WriteLine($"\nLeistung (in Watt) = {res_power}");
		}
	}
}