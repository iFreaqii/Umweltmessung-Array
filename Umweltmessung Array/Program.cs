using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umweltmessung_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int[] anzTage = new int[365];

                string fortsetzen = "j";

                Console.WriteLine("Bitte geben Sie die Anzahl an Tage an, für die Werte berechnet werden soll.");

   
            } while(fortsetzen == "j");
        }
    }
}




/*namespace array_beispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# - Array verwenden

            int[] feld = new int[4]; //Deklaration Aarry mit new!!!

            Console.WriteLine("Bitte Ganzzahlen in Array eingeben: ");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Wert " + (i + 1) + ": ");
                feld[i] = Convert.ToInt32(Console.ReadLine());  //Zahl in jedes Arrayelement einlesen + ausgeben
            }

            Console.WriteLine("\n\nAusgabe des Arrays: \n");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Wert " + (i + 1) + ": ");
                Console.WriteLine(feld[i] + "\n");              //Auslesen des i-ten Arrayelementes
            }

            Console.ReadKey();
        }
    }
}
*/