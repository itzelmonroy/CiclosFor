using System;

namespace CiclosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine(" Imprimir los numeros de la x hasta la y");
            Console.WriteLine("Ingrese su primer valor");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su segundo valor"); 
            y= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto irà?");
            z= Convert.ToInt32(Console.ReadLine());

            if (x>y)
            {
                for (int i=x;i>y;i-=z)
                {
                    Console.WriteLine("i=" + i);
                }
                
            }
            else if (x < y)
            {
                for (int i = x; i<=y; i += z)
                {
                    Console.WriteLine("i=" + i);
                }
            }

        }
    }
}
