using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Szamolo
    {
        public float elsoszam; 
        public float masodikszam; 

        public Szamolo(float elsoszam, float masodikszam)
        {
            this.elsoszam = elsoszam;
            this.masodikszam = masodikszam;
        }
        static void Main(string[] args)
        {
            
                  while (true)
                {
                try
                {
                    Console.WriteLine("Enter the first number: ");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the second number: ");
                    float b = float.Parse(Console.ReadLine());
                    Szamolo peniszu = new Szamolo(a, b);
                    int choice = peniszu.Menu();
                    if (choice == 1)
                    {
                        Console.WriteLine(peniszu.Osszeadas(a, b));
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine(peniszu.Kivonas(a, b));
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine(peniszu.Szorzas(a, b));
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine(peniszu.Osztas(a, b));
                    }
                    Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Jokker");
                }
            }
            
            

        }
        public float Osszeadas(float a, float b) => a + b;
        public float Kivonas(float a, float b) => a - b;
        public float Szorzas(float a, float b) => a * b;
        public float Osztas(float a, float b) => a / b;

        public  int Menu()
        {
          Console.WriteLine("1. Osszadas\r\n 2. Kivonas\r\n 3. Szorzas\r\n 4. Osztas\r\n");
          Console.WriteLine("Enter yout choice: ");
          return int.Parse(Console.ReadLine());

        
        }







    }
}

