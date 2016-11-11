using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        /** Övning 1
        static int CelsiusTillFarenHeit (int celsius)
        {
            return ((celsius / 5) * 9 + 32);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Mata in i Celcius: ");
            int grader = int.Parse(Console.ReadLine()); 
            Console.WriteLine(CelsiusTillFarenHeit(grader));
        }
        **/
        /** Övning 2
        static double Area(double radie)
        {
            return (radie * radie * Math.PI);
        }

        static double Omkrets(double radie)
        {
            return (radie * 2 * Math.PI);
        }

        static void Main(string[] args)
        {
            Console.Write("Mata in radie: ");
            double radien = double.Parse(Console.ReadLine());
            Console.WriteLine("Arean är: " + Math.Round(Area(radien)));
            Console.WriteLine("Omkretsen är: " + Math.Round( Omkrets(radien)));
        }
        **/

        /** Övning 3
        static int KastaTärning(int kast)
        {
           Random random = new Random();

            int[] lista = new int [kast];
            int summa = 0;

            for (int i = 0; i < kast; i++)
                
                {

                    lista[i] = random.Next(1,6);
                    summa += lista[i];

                }
           

            return summa ;  
        }

        static void Main(string[] args)
        {
            Console.Write("Mata in antal kast: ");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine ((KastaTärning(antal)));
            
        }

        **/

    }
}
