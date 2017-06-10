using System;
public class Aufgabe3{
	public static void Main(String[] args){
		int zahl;
		while(true){
			Console.WriteLine("Bitte wählen Sie (1, 2, 3 oder 9 für Ende): ");
			zahl = Int32.Parse(Console.ReadLine());
			
			switch(zahl){
				case 1:{
					Console.WriteLine("Die Zahl ist eine eins.");
					break;
				}
				case 2:{
					Console.WriteLine("Die Zahl ist eine zwei.");
					break;
				}
				case 3:{
					Console.WriteLine("Die Zahl ist eine drei.");
					break;
				}
				case 9:{
					Console.WriteLine("Programm-Ende.");
					return;
				}
				default:{
					Console.WriteLine("Falsche Eingabe, bitte wiederholen.");
					break;
				}
			}
		}
	}
}