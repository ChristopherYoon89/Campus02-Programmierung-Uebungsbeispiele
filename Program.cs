using System;
using Microsoft.Win32.SafeHandles;

namespace UEBUNG01

{
	class Program 
	{
		static void Main(string[] args)
		{	
			Console.WriteLine("+++++++++++++++++++++++++++++++++");
			Console.WriteLine("Übung Programmierung Einführung");
			Console.WriteLine("Christopher Yoon");
			Console.WriteLine("17. Oktober 2026");
			Console.WriteLine("+++++++++++++++++++++++++++++++++");
			Console.WriteLine("\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel 1: Rechenoperationen");
			Console.WriteLine("#################################");

			// Variablen deklarieren

			float var_x = 100.34f;
			float var_y = 43.79f;

			Console.WriteLine($"Variable X: {var_x}");
			Console.WriteLine($"Variable Y: {var_y}\n");

			// Berechnungen durchführen
			float res_addition = var_x + var_y;
			float res_subtraction = var_x - var_y;
			float res_division = var_x / var_y;
			float res_multiplication = var_x * var_y; 

			// Berechnungen ausgeben
			Console.WriteLine($"Result addition: {res_addition}");
			Console.WriteLine($"Result subtraction: {res_subtraction}");
			Console.WriteLine($"Redult Multiplication: {res_multiplication}");
			Console.WriteLine($"Result division: {res_division}\n");

			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Übung 9: maximale Werte zuweisen");
			Console.WriteLine("#################################");
			Console.WriteLine("\n");

			// Maximale Werte herausfinden
			Console.WriteLine(byte.MaxValue);
			Console.WriteLine(int.MaxValue);
			Console.WriteLine(float.MaxValue);
			Console.WriteLine(decimal.MaxValue);

			// Werte zuweisen			
			bool is_online = true; 
			byte byte_max = 255;
			int int_max = 2147483647;
			float float_max = 3.4028235E+38F;
			char char_max = 'c';
			
			// Werte in Konsole ausgeben
			Console.WriteLine("Die maximalen Werte sind:");
			Console.WriteLine(byte_max);
			Console.WriteLine(is_online);
			Console.WriteLine(int_max);
			Console.WriteLine(float_max);
			Console.WriteLine(char_max);

			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: if-Anweisung");
			Console.WriteLine("#################################");
			Console.WriteLine("\n");
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
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: while-Schleife von 1-10");
			Console.WriteLine("#################################");

			int i = 1;

			while (i < 11) {
				Console.Write(i + " ");
				++i;
			}

			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: while-Schleife 10-1");
			Console.WriteLine("#################################");

			i = 10;

			while (i > 0) {
				Console.Write(i + " ");
				i--;
			}

			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: while-Schleife 12-0");
			Console.WriteLine("#################################");
			
			i = 12;

			while (i >= 0) {
				Console.Write(i + " ");
				i--;
			}



			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: do while Schleife 0-9");
			Console.WriteLine("#################################");
			
			i = 0;

			do
			{
				Console.Write(i + " ");
				i++;
			} while (i < 10);


			
			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: do while Schleife 10-1");
			Console.WriteLine("#################################");
			
			i = 10;

			do
			{
				Console.Write(i + " ");
				i--;
			} while (i > 0);



			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: do while Schleife 12-0");
			Console.WriteLine("#################################");
			
			i = 12;

			do
			{
				Console.Write(i + " ");
				i--;
			} while (i >= 0);


			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: for loop 1-10");
			Console.WriteLine("#################################");

			for (i = 1; i < 11; i++)
			{
				Console.Write(i + " ");
			}



			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: for loop 10-1");
			Console.WriteLine("#################################");

			for (i = 10; i > 0; i--)
			{
				Console.Write(i + " ");
			}


			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Beispiel: for loop 12-0");
			Console.WriteLine("#################################");

			for (i = 12; i >= 0; i--)
			{
				Console.Write(i + " ");
			}

			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Übung 11: Gerade Zahlen 2-16 in");
			Console.WriteLine("Loops");
			Console.WriteLine("#################################");

			for (i = 2; i < 17; i++)
			{
				if (i % 2 == 0)
				{
					Console.Write(i + " ");
				} else
				{
					continue;
				}
			}

			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Übung 11: Gerade Zahlen 2-16 in");
			Console.WriteLine("Loops ohne Zahlen die durch 5");
			Console.WriteLine("teilbar sind");
			Console.WriteLine("#################################");

			for (i=2; i<17; i++) {
				if (i % 2 != 0 || i % 5 == 0)
				{
					continue;
				} else
				{
					Console.Write(i + " ");
				}
			}


			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Übung 11: 3 types of loop 27-19");
			Console.WriteLine("#################################");

			Console.WriteLine("While Loop:");

			i = 27;

			while (i > 18)
			{
				Console.Write(i + " ");
				i--;
			}

			Console.WriteLine("\nFor Loop:");

			for (i = 27; i > 18; i--)
			{
				Console.Write(i + " ");
			}

			Console.WriteLine("\nDo While Loop:");
			
			i = 27;

			do
			{
				Console.Write(i + " ");
				i--;
			} while (i > 18);


			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Übung 12: Zahlenausgabe DIN 660001");
			Console.WriteLine("#################################");

			for (i=1; i <= 100; i++)
			{	
				if (i == 39)
				{
					i = 61;
				}
				Console.Write(i + " ");
			}


			Console.Write("\n\n");
			Console.WriteLine("#################################");
			Console.WriteLine("Übung 12: ggT nach Euklid");
			Console.WriteLine("#################################");

			int var_a = 45;
			int var_b = 35;

			Console.WriteLine("Zahl 1: " + var_a);
			Console.WriteLine("Zahl 2: " + var_b);

			while (var_a > 0 && var_b > 0)
			{
				if (var_a > var_b) {
					var_a = var_a - var_b;
				} else {
					var_b = var_b - var_a;
				}
			}

			if (var_b == 0)
			{
				Console.WriteLine("Result: " + var_a);
			} else
			{
				Console.WriteLine("Result: " + var_b);
			}

			Console.WriteLine("\n\n");
		}
	}
}


