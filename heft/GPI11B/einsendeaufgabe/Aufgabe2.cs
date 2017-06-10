using System;
public class Aufgabe2{
	public static void Main(String[] args){
		Console.WriteLine("Bitte geben Sie eine Zeichenfolge aus natürlichen Ziffern ein.");
		String line = Console.ReadLine();
		Console.WriteLine("Die Eingabe der Zeichenfolge lautet: '{0}'",line);
		long zahl = Int64.Parse(line);
		Console.WriteLine("Die Eingabe als Zahlausgabe ist {0:d}",zahl);
		uint quersumme = 0;
		long z = zahl;
		do {
			quersumme += (uint) z%10;
			z=z/10;
		}while(z>0);
				
		Console.WriteLine("Die Quersumme aus {0:d} ist: {1:d}",zahl, quersumme);
	}
}