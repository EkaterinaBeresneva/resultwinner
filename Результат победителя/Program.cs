using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Результат_победителя
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] masimen = new string[5];
            double[,] masrez = new double[5,3];
            double[] maslutsh = new double[5];
            Random random = new Random();
            double max = 1;
            for(int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    masrez[i, j] = random.NextDouble() + 1.3;
                    Console.Write("\t[{0:F2}]", masrez[i, j]);
                }
                Console.WriteLine("\n");
            }

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if(max<masrez[i,j])
                    {
                        maslutsh[i]= masrez[i, j];
                        max = masrez[i, j];
                    }
                }
                
            }
            max = maslutsh[0];
            for (int i = 0; i <= 4; i++)
            {               
                if (max < maslutsh[i])
                {
                    max = maslutsh[i];
                }
            }
            Console.Write("Лучший результат[{0:F2}]", max);
            Console.ReadLine();
        }
    }
}
