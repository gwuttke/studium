using System;
public class Aufgabe6{
	public static void Main(String[] args){
		for(double i = 1; i<=10;i++){
			double anfangNaeherung = 1d;
			Console.WriteLine("Für die Qatratwurzel: {0} sind die ersten 5 Näherungswert folgende:",i);
			for (uint j = 0; j<5;j++){
				double endeNaeherung = ((anfangNaeherung+(i/anfangNaeherung))/2);
				Console.WriteLine("\tFür den {0}-ten Näherungswert gilt: {1} < Wurzel {2} < {3}",j+1, anfangNaeherung,i,endeNaeherung);
				anfangNaeherung = endeNaeherung;
			}
		}
	}
}