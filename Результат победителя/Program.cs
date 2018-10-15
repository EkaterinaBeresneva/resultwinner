using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinnerDinner
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 5, r = 3;
            double[,] masrezult = new double[n, r];
            

            inputData(masrezult);
            double max;
            int p;
            findMax(masrezult, out max, out p,n,r);
            Console.Write("\n Лучший результат в соревновании по прыжкам с места у Участника {1} [{0:F2}]", max, p + 1);
            Console.ReadLine();
        }

        public static void findMax(double[,] masrezult, out double max, out int p,int n,int r)
        {
            max = masrezult[0, 0];
            p = 0;
            
                for (int i = 0; i <= n-1; i++)
                    {
                        for (int j = 0; j <= r-1; j++)
                        {
                            if (Double.IsNaN(max) || max < masrezult[i, j])
                            {
                        
                                max = masrezult[i, j];
                                p = i;
                            }
                        }

                    }
            
           
            
           
        }

        private static void inputData(double[,] masrezult)
        {
            Random random = new Random();

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("\n Участник {0}", i + 1);
                for (int j = 0; j <= 2; j++)
                {
                    masrezult[i, j] = random.NextDouble() + 1.5;
                    Console.Write("\t[{0:F2}]", masrezult[i, j]);
                }
            }
        }
    }
}
