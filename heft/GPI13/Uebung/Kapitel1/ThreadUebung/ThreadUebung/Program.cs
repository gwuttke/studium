using System;
using System.Threading;

class Program
{
    private  static char ZEICHEN = '&';
    static void Main(string[] args)
    {
        Program p = new Program();
        Thread lesen = new Thread(new ThreadStart(p.eingaben));
        Thread drucken = new Thread(new ThreadStart(p.drucken));
        lesen.Name = "lesen";
        drucken.Name = "drucken";
        Console.WriteLine("Es wird immer ein Thread auf Ihre Eingabe warten mi einem Zeichen,");
        Console.WriteLine("Ein anderer wird immer dass Zeichen {0} ausgeben, bis Sie ein Zeichen eingegeben haben welches dann ausgegeben wird",ZEICHEN);

        lesen.Start();
        drucken.Start();

    }

    private void eingaben()
    {
        do
        {
            ZEICHEN = Console.ReadKey().KeyChar;
        } while (true);
    }

    private void drucken()
    {
        do
        {
            Console.Write(ZEICHEN);
            // damit das Programm nicht zu schnell ausgeführt wird
            Thread.Sleep(5);
        } while (true);
    }
}