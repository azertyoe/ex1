using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // déclarations
            float moyenne;

            Console.Write("saisisez la moyenne : ");
            moyenne = float.Parse(Console.ReadLine());

            // appréciations
            if(moyenne <10)
            {
                
                Console.WriteLine("vous étes recaler ");

            }
            else
            {
                if (moyenne < 12)
                {
                    Console.WriteLine(" passable");
                }

                else
                {
                    if (moyenne < 14) 
                    {
                        Console.WriteLine("assez bien");
                    }

                    else
                    {
                        if (moyenne < 16) 
                        {
                            Console.WriteLine("bien");
                        }
                        else
                            {
                            Console.WriteLine(" très bien");
                            }
                    }
                }


            }
            Console.ReadLine();
        }
    }
}
