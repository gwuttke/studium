using System;
public class Aufgabe4{
	public static void Main(String[] args){
		uint zahl = 5;
		Console.WriteLine("Für die Zahl '{0}' ist das ergebnis nach Collatz: {1}",zahl, collatz(zahl));
	}
	
	private static uint collatz(uint zahl){
		if(zahl == 1){
			return 1;
		} else if((zahl % 2)==0){
			return collatz(zahl/2);
		} else {
			return collatz((3*zahl)+1);
		}
	}
}