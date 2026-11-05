using System;

namespace UEBUNG11

{
	class Program
	{
		static void Main(string[] args)
		{	
			/* Zunächst deklariere ich die integer Variable i. Im nächsten Schritt wird ein For Loop 
			initialisiert. Wir beginnen den Loop bei 0, der Loop wird dann abgebrochen sobald i den 
			Wert 34 einnimmt und bei jedem Durchgang der Schleife wird i um 1 erhöht.
			Wir nutzen den Modulo Operator um jene Zahlen nicht auszugeben, die durch 5 teilbar sind. 
			Bei jedem Durchgang dividieren wir i durch 5. Ergibt der Rest 0, wissen wir, dass i durch 5 
			teilbar ist und daher nicht ausgegeben werden darf.*/
	
			int i;

			for (i = 0; i < 35; i++)
			{	 
				if (i % 5 != 0)
				{
					Console.WriteLine(i);
				}
			}
		}	
	}
}