using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Função NAND usando o neurônio Mcculloch-Pitts.");
            Console.WriteLine("Entrando com os pesos e valor de limiar.");

            Console.WriteLine("Entre com o pesos:");
            int w1 = int.Parse(Console.ReadLine());            
            int w2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o valor de limiar");
            double theta = double.Parse(Console.ReadLine());

            Calcular(w1, w1, theta);
            Console.ReadLine();
        }

        public static void Calcular(int w1, int w2, double theta)
        {
            int[] y = new int[] { 0, 0, 0, 0 };
            int[] x1 = new int[] { 0, 0, 1, 1 };
            int[] x2 = new int[] { 0, 1, 0, 1 };
            int[] z = new int[] { 1, 1, 1, 0 };
            //
            //
            //
            int con = 1;
            while (con == 1)
            {
                //var zin = (x1[1] * w1) + (x2[1] * w2);
                int zin = 0;

                foreach (var xa in x1)                
                    zin += (xa * w1);                

                foreach (var xb in x2)                
                    zin += (xb * w2);                
                //

                for (int i = 1; i < 4; i++)
                {
                    if (zin >= theta)
                        y[i] = 1;
                    else
                        y[i] = 0;
                }

                Console.WriteLine("Saída da Rede:");

                foreach (var yy in y)                
                    Console.WriteLine(yy);

                if (y == z)
                    con = 0;
                else
                {
                    Console.WriteLine("A rede não esta aprendendo. Entre com outro conjunto de valores para pesos e limiar.");
                    Console.WriteLine("Entre com o pesos:");
                    w1 = int.Parse(Console.ReadLine());
                    w2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Entre com o valor de limiar");
                    theta = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Rede Mcculloch-Pitts para função NAND");
            Console.WriteLine("Pesos do Neurônio");
            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine("Valor de Limiar");
            Console.WriteLine(theta);
        }               
    }
}
