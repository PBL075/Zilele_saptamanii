using System;
using System.Runtime.CompilerServices;

namespace ziua_saptamanii
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Alege dupa numar o zi din saptamana");
            int alegere = Convert.ToInt32 (Console.ReadLine ());

            switch (alegere)
            {
                case 1:
                Console.WriteLine("Aceasta zi este luni");
                break;
                case 2:
                Console.WriteLine("Aceasta zi este marti");
                break;
                case 3:
                Console.WriteLine("Aceasta zi este miercuri");
                break;
                case 4:
                Console.WriteLine("Aceasta zi este joi");
                break;
                case 5:
                Console.WriteLine("Aceasta zi este vineri");
                break;
                case 6:
                Console.WriteLine("Aceasta zi este sambata");
                break;
                case 7:
                Console.WriteLine("Aceasta zi este duminica");
                break;
                default:
                Console.WriteLine("Tu esti pe alta planeta , saptamana are 7 zile");
                break;
                
            }
        }
    }
}