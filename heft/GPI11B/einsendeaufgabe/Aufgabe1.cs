using System;
public class Aufgabe1{
	public static void Main(String[] args){
		int begin, end, ergebnis, bTemp;
		Console.WriteLine("Bitte geben Sie die erste natürliche Zahl des Bereiches ein, welcher Summiert werden soll.");
		begin = Int32.Parse(Console.ReadLine());
		Console.WriteLine("Bitte geben Sie die letzte natürliche Zahl des Bereiches ein, welcher Summiert werden soll.");
		end = Int32.Parse(Console.ReadLine());
		ergebnis = 0;
		Console.WriteLine("Berechnung durch for-Schleife");
		for(bTemp = begin;bTemp <=end;bTemp++){
			ergebnis += bTemp;
		}
		Console.WriteLine("Ergebnis: "+ ergebnis);
		//-------------------
		ergebnis = 0;
		bTemp = begin;
		Console.WriteLine("Berechnung durch while-Schleife");
		while(bTemp<=end){
			ergebnis += bTemp++;
		};
		Console.WriteLine("Ergebnis: "+ ergebnis);
		//-------------------
		ergebnis = 0;
		Console.WriteLine("Berechnung durch do-while-Schleife");
		bTemp = begin;
		do{
			ergebnis += bTemp++;
		}while(bTemp<=end);
		Console.WriteLine("Ergebnis: "+ ergebnis);
		//-------------------
		Console.WriteLine("Berechnung mit der Formel");
		ergebnis = ((end*(end+1))/2) - ((begin*(begin+1))/2) + begin; 
		Console.WriteLine("Ergebnis: "+ ergebnis);
	}
}