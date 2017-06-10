using System;
public class Aufgabe5{
	public static void Main(String[] args){
		uint tag = 32, monat = 10;
		Console.WriteLine(tierkreis(tag, monat));
		
	}
	private static String tierkreis(uint tag, uint monat){
		uint zahl = (100*monat+tag);
		if((tag >31 || tag == 0)&& (monat>12 || monat == 0 )){
			return "Keine richtige Eingabe!!";
		}else if (zahl <= 119 || zahl >= 1223){
			return "Steinbock";
		}else if(zahl<219 && zahl >= 120){
			return "Wassermann";
		}else if (zahl <= 320 && zahl  >= 220){
			return "Fisch";
		}else if (zahl <= 419 && zahl >=  321){
			return "Widder";
		}else if (zahl <= 520 && zahl >= 420){
			return "Stier";
		}else if (zahl <= 620 && zahl >= 521){
			return "Zwilling";
		}else if (zahl <= 721 && zahl >= 621){
			return "Krebs";
		}else if (zahl <= 822 && zahl >=  722){
			return "Löwe";
		}else if (zahl <= 922 && zahl >=  823){
			return "Jungfrau";
		}else if (zahl <= 1022 && zahl >=  923){
			return "Waage";
		}else if (zahl <= 1121 && zahl >=  1023){
			return "Skorpion";
		}else{
			return "Schütze";
		}
	}
}