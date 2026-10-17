using System;

namespace UEBUNG01

{
	class Program 
	{
		static void Main(string[] args)
		{	
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Übung Programmierung Einführung");
			Console.WriteLine("Christopher Yoon");
			Console.WriteLine("17. Oktober 2026");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("\n");

			float var_x = 100.34f;
			float var_y = 43.79f;

			Console.WriteLine($"Variable X: {var_x}");
			Console.WriteLine($"Variable Y: {var_y}\n");

			float res_addition = var_x + var_y;
			float res_subtraction = var_x - var_y;
			float res_division = var_x / var_y;
			float res_multiplication = var_x * var_y; 

			Console.WriteLine($"Result addition: {res_addition}");
			Console.WriteLine($"Result subtraction: {res_subtraction}");
			Console.WriteLine($"Redult Multiplication: {res_multiplication}");
			Console.WriteLine($"Result division: {res_division}\n");

			Console.WriteLine("-------------------------------");

			bool is_online = true; 
			byte byte_max = 255;
			int int_max = 2147483647;
			Console.WriteLine(float.MaxValue);

			Console.WriteLine(int.MaxValue);
			Console.WriteLine(byte_max);
			Console.WriteLine(is_online);
			Console.WriteLine(int_max);

			Console.WriteLine("-------------------------------");

			Console.WriteLine("Beispiel: if-Anweisung");
			// Console.Write("Bitte geben Sie eine Zahl an: ");

			string command_line_value = "35";
			int number = 0;
			string result = "";

			// command_line_value = Console.ReadLine();
			number = Convert.ToInt32(command_line_value);

			if (number > 0) 
			{
				result = "ist eine positive Zahl";
			} 
			else if (number < 0) 
			{
				result = "ist eine negative Zahl";
			}
			else {
				result = "ist Null";
			}

			Console.WriteLine($"{number} {result}");
			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: while-Schleife von 1-10");
			Console.WriteLine("-------------------------------");

			int i = 1;

			while (i < 11) {
				Console.WriteLine(i);
				++i;
			}

			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: while-Schleife 10-1");
			Console.WriteLine("-------------------------------");

			i = 10;

			while (i > 0) {
				Console.WriteLine(i);
				i--;
			}

			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: while-Schleife 12-0");
			Console.WriteLine("-------------------------------");
			
			i = 12;

			while (i >= 0) {
				Console.WriteLine(i);
				i--;
			}



			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: do while Schleife 0-9");
			Console.WriteLine("-------------------------------");
			
			i = 0;

			do
			{
				Console.WriteLine(i);
				i++;
			} while (i < 10);


			
			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: do while Schleife 10-1");
			Console.WriteLine("-------------------------------");
			
			i = 10;

			do
			{
				Console.WriteLine(i);
				i--;
			} while (i > 0);



			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: do while Schleife 12-0");
			Console.WriteLine("-------------------------------");
			
			i = 12;

			do
			{
				Console.WriteLine(i);
				i--;
			} while (i >= 0);


			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: for loop 1-10");
			Console.WriteLine("-------------------------------");

			for (i = 1; i < 11; i++)
			{
				Console.WriteLine(i);
			}



			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: for loop 10-1");
			Console.WriteLine("-------------------------------");

			for (i = 10; i > 0; i--)
			{
				Console.WriteLine(i);
			}


			Console.Write("\n\n");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Beispiel: for loop 12-0");
			Console.WriteLine("-------------------------------");

			for (i = 12; i >= 0; i--)
			{
				Console.WriteLine(i);
			}

		}
	}
}


