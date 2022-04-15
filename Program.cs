using System;

namespace Triangles
{
    class Program
    {
        static void Main(string[] args)
        {             
            while (true)
            {
                Console.WriteLine("Height");
                bool HeightParse = int.TryParse(Console.ReadLine(), out int height);
                Console.Clear();

                if (HeightParse)
                {
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {                               
                                Console.Write("#");                                
                        }                           
                            Console.WriteLine("#");                        
                    }

                    Console.WriteLine();

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = height; j > (i + 1); j--)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine("#");
                    }

                    Console.WriteLine();

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = height; j > (i + 1); j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; i > k; k++)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine("#");
                    }

                    Console.WriteLine();
                    
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = height; k >= (i + 1); k--)
                        {
                            Console.Write("#");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("Incorrect input");                    
                }

                Console.WriteLine("Press [Enter] to repeat");
                Console.WriteLine("Press [E] to exit");

                //Exit programm
                string exit = Console.ReadLine();
                if (exit == "e" || exit == "E")
                {
                    break;
                }
                Console.Clear();
            }            
        }
    }
}