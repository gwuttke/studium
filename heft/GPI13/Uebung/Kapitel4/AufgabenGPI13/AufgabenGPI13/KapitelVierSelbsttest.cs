using System;
using System.Collections.Generic;
using System.Text;

namespace AufgabenGPI13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sList = new List<string>();
            sList.Add("Hallo");
            sList.Add("Georg");
            sList.Add("Wie");
            sList.Add("Geht");
            sList.Add("es");
            sList.Add("dir");
            Console.WriteLine(listToString(sList));
            Console.ReadKey();
        }

        protected static string listToString(List<string> listStrings)
        {
            listStrings.Reverse();
            return String.Join(" ", listStrings);
        }
    }
}
