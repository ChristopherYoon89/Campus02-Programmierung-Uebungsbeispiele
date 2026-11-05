using System;

namespace UEBUNG10

{
	class Program
	{
		static void Main(string[] args)
		{
			// Print program header
			Console.WriteLine("------------------------------------");
			Console.WriteLine("Übung 10");
			Console.WriteLine("Christopher Yoon");
			Console.WriteLine("Ohmsche App 2");
			Console.WriteLine("LV Programmierung Einführung");
			Console.WriteLine("------------------------------------");
			Console.Write("\n");

			// Declare variables and asign values
			char key;
			float voltage = 0;
			float current = 0;
			uint resistance = 0;

			float resCurrent = 0;
			float resVoltage = 0;
			float resResistance = 0;

			do {
				// Print console menu
				Console.WriteLine("Wählen Sie eine Berechnung: ");
				Console.WriteLine("1: Berechnung der Spannung (V)");
				Console.WriteLine("2: Berechnung der Stromstärke (A)");
				Console.WriteLine("3: Berechnung des Widerstandes (Ohm)");

				// Get key for selecting options
				ConsoleKeyInfo cki;
				cki = Console.ReadKey(true);
				key = cki.KeyChar;
			} while (key < '1' || key > '3');

			// Navigating through the menu
			switch (key)
			{
				case '1':
					Console.WriteLine("\nBerechnung der Spannung:\n");
					current = InputCurrent();
					resistance = InputResistance();
					resVoltage = CalculateVoltage(current, resistance);
					Console.WriteLine($"\nSpannung (in Volt) = {resVoltage}");
					break;

				case '2':
					Console.WriteLine("\nBerechnung der Stromstärke:\n");
					voltage = InputVoltage();
					resistance = InputResistance();
					resCurrent = CalculateCurrent(voltage, resistance);
					Console.WriteLine($"\nStromstärke (in Ampere) = {resCurrent}");
					break;

				case '3':
					Console.WriteLine("\nBerechnung des Widerstandes: \n");
					voltage = InputVoltage();
					current = InputCurrent();
					resResistance = CalculateResistance(voltage, current);
					Console.WriteLine($"\nWiderstand (in Ohm) = {resResistance}");
					break;
				default: 
					Console.WriteLine("\nGeben Sie eine korrekte Menüauswahl ein (Zahl 1-3)");
					break;
			}
		}


		static float InputCurrent()
		// Function that converts the current input
		{
			string currentInput = "";
			
			Console.Write("Stromstärke (in Ampere) = ");
			currentInput = Console.ReadLine();
			return Convert.ToSingle(currentInput);
		}


		static uint InputResistance()
		// Function that converts the resistance input
		{
			string resistanceInput = "";

			Console.Write("\nWiderstand (in Ohm) = ");
			resistanceInput = Console.ReadLine();
			return Convert.ToUInt32(resistanceInput);
		}


		static float InputVoltage()
		// Function that converts the voltage input
		{
			string voltageInput = "";

			Console.Write("\nSpannung (in Volt) = ");
			voltageInput = Console.ReadLine();
			return Convert.ToSingle(voltageInput);
		}


		static float CalculateVoltage(float current, float resistance)
		// Function that calculates voltage
		{	
			if (resistance <= 0)
			{
				Console.WriteLine("Der Widerstand darf nicht 0 oder kleiner 0 sein.");
				return float.NaN;
			} else {
			return current * resistance;
			}
		} 


		static float CalculateCurrent(float voltage, uint resistance)
		// Function that calculates current
		{
			if (resistance <= 0)
			{
				Console.WriteLine("Der Widerstand darf nicht 0 oder kleiner 0 sein");
				return float.NaN;
			} else
			{
				return voltage / resistance;	
			}
		}


		static float CalculateResistance(float voltage, float current)
		// Function that calculates resistance
		{
			if (current <= 0)
			{
				Console.WriteLine("Die Stromstärke darf nicht 0 oder kleiner 0 sein");
				return float.NaN;
			} else
			{
				return voltage / current;	
			}
		}
	}
}