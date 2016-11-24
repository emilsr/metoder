using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder_och_funktioner
{
    class Program
    {
        //övning1 
        /*
        static void Main(string[] args)
        {
            
            double temp = int.Parse(Console.ReadLine());
            Console.WriteLine(CelsiusTillFarenheit(temp) + " grader i Farenheit");
            Console.ReadKey();
            
        }
        static double CelsiusTillFarenheit(double temp)
        {
            return (temp / 5.0) * 9 + 32;
        }
        


        //övning2
        static void Main(string[] args)
        {

            double radie = int.Parse(Console.ReadLine());
            Console.WriteLine(Arie(radie) + " aria");
            Console.WriteLine(omkrets(radie) + " omkrets");
            Console.ReadKey();

        }
        static double Arie(double radie)
        {
            return (radie * radie * Math.PI);
        }
        static double omkrets(double radie)
        {
            return (radie * 2* Math.PI);

        }
        
        //övning3
        static void Main(string[] args)
        {

            Console.Write("Antal tärnings kast: ");
            int antalKast = int.Parse(Console.ReadLine());
            Console.Write("värde: ");
            Console.WriteLine (Tärning(antalKast));
            Console.ReadKey();
        }
        static int Tärning(int antalKast)
        {
            Random rnd = new Random();
            int resultat;
            int sum = 0;
            for (int i = 0; i < antalKast; i++)
            {
                resultat = rnd.Next(1, 7);
                sum += resultat;
            }
            return sum;



        }
    }
            
            
        //övning 4
        static void Main(string[] args)
        {
            Console.Write("skriv in antal sidor på tärning: ");
            int antalSidor = int.Parse(Console.ReadLine());
            Console.Write("skriv in antall kast: ");
            int antalKast = int.Parse(Console.ReadLine());
            Tärning(antalSidor, antalKast);
            Console.WriteLine("Resultat: " + Tärning(antalSidor, antalKast));
            Console.ReadKey();
        }
          static int Tärning(int kast)
        {
            Random rnd = new Random();
            int resultat;
            int sum = 0;
            for (int i = 0; i < kast; i++)
            {
                resultat = rnd.Next(1, 7);
                sum += resultat;
            }
            return sum;
        }
        static int Tärning(int antalSidor, int antalKast)
        {
            Random rnd = new Random();
            int total = 0;
            for (int i = 0; i < antalKast; i++)
                total += rnd.Next(1, antalSidor + 1);
            return total;
            }
    */

    }

    }
    

