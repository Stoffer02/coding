using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Lektion2
    {
        public static void Run()
        {

            Console.WriteLine("Indtast x");
            string X = Console.ReadLine();
            int talX;
            if (int.TryParse(X, out talX) == false)
            {
                Console.WriteLine("Fejl, g�r tilbage");
                return;
            } 
            
            Console.WriteLine("Indtast y");
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

            Console.WriteLine("x + y er:");
            Console.WriteLine(talX + talY);
        }
    }
}
