/*
Name: Wuttke				Vorname: Georg
Postleitzahl und Ort: 67433, Neustadt an der Weinstraße
Straße: Marktplatz 5A
Matrikelnummer: 900279		Studiengang-Nr.: 1131
GPI11BXX	| 2				Auflage: 1114 K03

Einsendeaufgabencode: GPI11B-XX2-K03
*/
using System;
public class GPI{
	private static void aufgabe(uint aufgabe){
		Console.WriteLine("+++++++++++++++++++++++++ Sie haben Aufgabe {0} gewählt +++++++++++++++++++++++++",aufgabe);
	}
	
	public static void Main(String[] args){
		int zahl;
		while(true){
			Console.WriteLine("Bitte wählen Sie für die Aufgabe, die jeweilige Nummer(1, 2, 3, 4, 5, 6, 7 oder 9 für Ende): ");
			zahl = Int32.Parse(Console.ReadLine());
			
			switch(zahl){
				case 1:{
					aufgabe(1);
					Aufgabe1.run();
					break;
				}
				case 2:{
					aufgabe(2);
					Aufgabe2.run();
					break;
				}
				case 3:{
					aufgabe(3);
					Aufgabe3.run();
					break;
				}
				case 4:{
					aufgabe(4);
					Aufgabe4.run();
					break;
				}
				case 5:{
					aufgabe(5);
					Aufgabe5.run();
					break;
				}
				case 6:{
					aufgabe(6);
					Aufgabe6.run();
					break;
				}
				case 7:{
					aufgabe(7);
					Aufgabe7.run();
					break;
				}
				case 9:{
					goto ende;
				}
				default:{
					Console.WriteLine("Falsche Eingabe, bitte wiederholen.");
					break;
				}
			}
			Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
		}
		ende:
		Console.WriteLine("Hauptprogramm-Ende.");
	}
}
public class Aufgabe1{
	public static void run(){
		schleifeFor(7,64);	
		schleifeWhile(7,64);
		schleifeDoWhile(7,64);
		Console.WriteLine("Berechnung durch rekusion");
		uint erg = rekusion(7,64);
		ausgabe(erg);
	}
	
	private static void schleifeFor(uint begin, uint end){
		Console.WriteLine("Berechnung durch for-Schleife");
		uint erg = 0;
		for(uint i = begin;i <=end;i++){
			erg += i;
		}
		ausgabe(erg);
	}
	
	private static void schleifeWhile(uint begin, uint end){
		Console.WriteLine("Berechnung durch while-Schleife");
		uint erg = 0;
		uint i = begin;
		while(i<=end){
			erg += i++;
		};
		ausgabe(erg);
	}
	
	private static void schleifeDoWhile(uint begin, uint end){
		Console.WriteLine("Berechnung durch do-while-Schleife");
		uint erg = 0;
		uint i = begin;
		do{
			erg += i++;
		}while(i<=end);
		ausgabe(erg);
	}
	
	private static uint rekusion(uint begin, uint end){
		if(begin == end){
			return end;
		}
		return begin + rekusion(++begin, end);
	}		

	private static void ausgabe(uint ergebnis){
		Console.WriteLine("Ergebnis: "+ ergebnis);
		Console.WriteLine("############################");
	}
}
public class Aufgabe2{
	public static void run(){
		Console.WriteLine("Bitte geben Sie eine Zeichenfolge aus Natürlichen Ziffern ein.");
		String line = Console.ReadLine();
		Console.WriteLine("Die Eingabe der Zeichenfolge lautet: '{0}'",line);
		Int64 z = convertToLong(line);
		uint quersumme = calcQuersumme(z);
		Console.WriteLine("Die Quersumme aus {0} ist: {1}",z, quersumme);
	}
	
	private static uint calcQuersumme(Int64 z){
		uint ergebnis = 0;
		foreach(char c in z.ToString().ToCharArray()){
			try {
				ushort zahl = Convert.ToUInt16(c.ToString());
				ergebnis += zahl;
			} catch (OverflowException) {
				Console.WriteLine("nicht erlaubte Umformung des wertes u+{0} in einen Typ 'int'.", 
                Convert.ToUInt16(c).ToString("X4"));
			}
		}
		return ergebnis;
	}
	
	private static Int64 convertToLong(String line){
		Int64 z = 0L;
		try{
			z = Int64.Parse(line);
			Console.WriteLine("Umformung von '{0}' zu {1}.", line, (long) z);
		}
		catch (FormatException){
			Console.WriteLine("Umformung der Zeile '{0}' nicht möglich.", line);
		} catch (OverflowException) {
			Console.WriteLine("'{0}' ist ausserhalb des bereiches von '{1}'", line, Int64.MaxValue);
		}
		return z;
	}
}
public class Aufgabe3{
	public static void run(){
		eigene();
	}
	private static void eigene(){
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
					goto ende;
				}
				default:{
					Console.WriteLine("Falsche Eingabe, bitte wiederholen.");
					break;
				}
			}
		}
		ende:
		Console.WriteLine("eigenes Programm-Ende.");
	}
	private static void vorgabe(){
		int zahl;
		while(true){
			Console.WriteLine("Bitte wählen Sie (1, 2, 3 oder 9 für Ende): ");
			zahl = Int32.Parse(Console.ReadLine());
			
			if(zahl == 1){
				Console.WriteLine("Die Zahl ist eine eins.");
				continue;
			}
			if(zahl == 2){
				Console.WriteLine("Die Zahl ist eine zwei.");
				continue;
			}
			if(zahl == 3){
				Console.WriteLine("Die Zahl ist eine drei.");
				continue;
			}
			if(zahl == 9){
				break;
			}
			Console.WriteLine("Falsche Eingabe, bitte wiederholen.");
		}
		Console.WriteLine("vorgabe Programm-Ende.");
	}
}
public class Aufgabe4{
	
	public static void run(){
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
public class Aufgabe5{
	
	public static void run(){
		Console.WriteLine(tierkreis(22,10));
	}
	
	public static String tierkreis(uint tag, uint monat){
		switch (monat){
			case 1:{
				return (tag<19)?"Steinbock":"Wassermann";
			} 
			case 2:{
				return (tag<19)?"Wassermann":"Fisch";
			}
			case 3:{
				return (tag<20)?"Fisch":"Widder";
			}
			case 4:{
				return (tag<20)?"Widder":"Stier";
			}
			case 5:{
				return (tag<21)?"Stier":"Zwilling";
				
			}
			case 6:{
				return (tag<21)?"Zwilling":"Krebs";
			}
			case 7:{
				return (tag<22)?"Krebs":"Löwe";
			}
			case 8:{
				return (tag<23)?"Löwe":"Jungfrau";
			}
			case 9:{
				return (tag<23)?"Jungfrau":"Waage";
			}
			case 10:{
				return (tag<23)?"Waage": "Skorpion";
			}
			case 11:{
				return (tag<23)?"Skorpion":"Schütze";
			}
			case 12:{
				return(tag<23)?"Schütze":"Steinbock";
			}
			default:{
				return "keinee richtige Eingabe";
			}
		}
	}
}
public class Aufgabe6{
	public static void run(){
		for(uint i = 1; i<=10;i++){
			float anfangNaeherung = 1f;
			Console.WriteLine("Für die Qatratwurzel: {0} sind die ersten 5 Näherungswert folgende:",i);
			for (uint j = 0; j<5;j++){
				float endeNaeherung = ((anfangNaeherung+(i/anfangNaeherung))/2);
				Console.WriteLine("\tFür den {0}-ten Näherungswert gilt: {1} < Wurzel {2} < {3}",j+1, anfangNaeherung,i,endeNaeherung);
				anfangNaeherung = endeNaeherung;
			}
		}
	}
}
public class Aufgabe7{
	public static void run(){
		Console.WriteLine("Bitte geben Sie ein Jahr ein, dass größer oder gleich 1582 ist.");
		uint jahr = UInt32.Parse(Console.ReadLine());
		if(jahr<=1582){
			throw new ArgumentOutOfRangeException("jahr","Das Jahr muss größer oder gleich 1582 sein");
		}
		osterSonntag(jahr);
	}	
	private static void osterSonntag(uint jahr){
		uint k = jahr/100;
		uint m = 15+(3*k+3)/4-(8*k+13)/25;
		uint s = 2-(3*k+3)/4;
		uint a = jahr%19;
		uint d = (19*a+m)%30;
		uint r = d/29+(d/28-d/29)*a/11;
		uint og = 21+d-r;
		uint sz = 7-((jahr+jahr/4+s)%7);
		uint oe = 7-((og-sz)%7);
		uint osTag = og+oe;
		uint osMonat = 3;
		if(osTag>31){
			osMonat++;
			osTag -= 31;
		}
		Console.WriteLine("Der Ostersontag im Jahre {0,4} ist für den {1,2}.{2,2} angesetzt.", jahr, osTag, osMonat);
	}
}