using System;
public class Aufgabe6{
	public static void Main(String[] args){
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