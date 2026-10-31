// Christopher Yoon 
// Hausübung Switch/Case
// LV Programmierung Einführung
// Campus02

using System;

namespace TASCHENRECHNER
{
	class Program
	{
		static void Main(string[] args)
		{	
			// Declaring variables
			char key;
			float num_1 = 0;
			float num_2 = 0;
			float result;
			bool isValidInput1 = false;
			bool isValidInput2 = false;
			
			// Print program header
			Console.WriteLine("----------------------------");
			Console.WriteLine("Hausübung Taschenrecher");
			Console.WriteLine("Christopher Yoon");
			Console.WriteLine("LV Programmierung Einführung");
			Console.WriteLine("31. Oktober 2026");
			Console.WriteLine("----------------------------\n");

			// Read user input
			Console.WriteLine("Geben Sie zwei Zahlen ein:");

			do
			{
				try
				{
					Console.Write("x = ");
					num_1 = Convert.ToSingle(Console.ReadLine());
					isValidInput1 = true;		
				}
				catch
				{
					Console.WriteLine("\nUngültige Eingabe! Geben Sie bitte eine Zahl ein.");
				}
			} while (isValidInput1 == false);

			do
			{
				try
				{
					Console.Write("y = ");
					num_2 = Convert.ToSingle(Console.ReadLine());		
					isValidInput2 = true;
				}
				catch
				{
					Console.WriteLine("\nUngültige Eingabe! Geben Sie bitte eine Zahl ein.");
				}
			} while (isValidInput2 == false);			

			Console.Write("\n");

			// Select math operation and print result			
			do
			{
				Console.WriteLine("\nWählen Sie eine Rechenoperation: ");
				Console.WriteLine("1: +");
				Console.WriteLine("2: -");
				Console.WriteLine("3: *");
				Console.WriteLine("4: /");
				ConsoleKeyInfo cki;
				cki = Console.ReadKey(true);
				key = cki.KeyChar;
			} while (key < '1' || key > '4');

			Console.Write("\n");

			switch (key)
			{
				case '1':
					result = Addition(num_1, num_2);
					Console.WriteLine($"{num_1} + {num_2} = {result}"); 
					break;
				case '2':
					result = Subtraction(num_1, num_2);
					Console.WriteLine($"{num_1} - {num_2} = {result}");
					break;
				case '3': 
					result = Multiplication(num_1, num_2);
					Console.WriteLine($"{num_1} * {num_2} = {result}");
					break;
				case '4':
					result = Division(num_1, num_2);
					Console.WriteLine($"{num_1} : {num_2} = {result}");
					break;
				default:
					Console.WriteLine("Bitte eine passende Zahl eingeben!");
					break;
			} 

		}

		// Function for addition
		static float Addition(float x, float y)
		{
			return x + y;
		}

		// Function for subtraction
		static float Subtraction(float x, float y) 
		{
			return x - y;
		}

		// Function for multiplication
		static float Multiplication(float x, float y)
		{
			return x * y;
		}

		// Function for division
		static float Division(float x, float y)
		{
			if (y == 0)
			{
				System.Console.WriteLine("Fehler: Division durch 0 nicht möglich!");
				return float.NaN;
			} else {
				return x / y;
			}
		}
	}
}