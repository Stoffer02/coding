using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Lektion3
    {
        public static void Run()
        {

            Console.WriteLine("Indtast tal");
            string X = Console.ReadLine();
            int talX;
            if (int.TryParse(X, out talX) == false)
            {
                Console.WriteLine("Fejl, g�r tilbage");
                return;
            } 
            
            Console.WriteLine("Plus, Minus, Gange eller Dividere?" );
            string Kommando = Console.ReadLine();
            
            Console.WriteLine("Indtast tal");
            string Y = Console.ReadLine();
            int talY;
            if (int.TryParse(Y, out talY) == false)
            {
                Console.WriteLine("Fejl, g�r tilbage");
                Y = Console.ReadLine();
                if (int.TryParse(Y, out talY) == false);
                    {
                        Console.WriteLine("Fejl, g�r tilbage");
                        return;


                    }



            }

            if(Kommando == "Minus")
            {
                Console.WriteLine("x minus y er:");
                Console.WriteLine(talX - talY);
            }
            else if(Kommando == "Plus")
            {
                Console.WriteLine("x plus y er:");
                Console.WriteLine(talX + talY); 
            }
            else if(Kommando == "Gange")
            { 
                Console.WriteLine("x gange y er:");
                Console.WriteLine(talX * talY);
            }
            else if(Kommando == "Dividere")
            {
                Console.WriteLine("x divideret med y er:");
                Console.WriteLine(talX / talY);
            }
        }
    }
}
