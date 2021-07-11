using System;
using System.Linq;

namespace GMcriterion
{
    class Minimax
    {
        /// <summary>
        /// Выполняет вычисление лучшего проекта по
        /// минимаксному критерию
        /// </summary>
        /// <param проект 1="e1"></param>
        /// <param проект 2="e2"></param>
        /// <param проект 3="e3"></param>
        /// <returns> Строку выгодного проекта</returns>        
        public static string MinimaxСriterion(double[] ar1, double[] ar2, double[] ar3)
        {
            double maxE1 = ar1.Min();
            double maxE2 = ar2.Min();
            double maxE3 = ar3.Min();
            string max;


            Console.WriteLine("E1 Min ={0}" +
                              "\nE2 Min ={1}" +
                              "\nE3 Min ={2}", maxE1, maxE2, maxE3);
            Console.WriteLine();

            if (maxE1 > maxE2 && maxE1 > maxE3) max = "E1 эффективнее";
            else if (maxE2 > maxE1 && maxE2 > maxE3) max = "E2 эффективнее";
            else max = "E3 эффективнее";

            return max;

        }
    }
}
