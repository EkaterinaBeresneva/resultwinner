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
       
            double[,] masrezult = new double[5,3];
            double[] masbest = new double[5];
            
            Random random = new Random();
            
            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("\n Участник {0}", i+1);
                for (int j = 0; j <= 2; j++)
                {
                    masrezult[i, j] = random.NextDouble() + 1.5;
                    Console.Write("\t[{0:F2}]", masrezult[i, j]);
                }              
            }
            double max = 1;
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if(max<masrezult[i,j])
                    {
                        masbest[i]= masrezult[i, j];
                        max = masrezult[i, j];
                    }
                }
                
            }
            max = masbest[0];
            int p = 0;
            for (int i = 0; i <= 4; i++)
            {               
                if (max < masbest[i])
                {
                    max = masbest[i];
                    p = i;
                }
            }
            Console.Write("\n Лучший результат в соревновании по прыжкам с места у Участника {1} [{0:F2}]", max, p+1);
            Console.ReadLine();
        }
    }
}
