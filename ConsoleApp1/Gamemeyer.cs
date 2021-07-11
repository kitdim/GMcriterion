using System;
using System.Linq;

namespace GMcriterion
{

    class Gamemeyer
    {
        /// <summary>
        ///  Определяет сколько нужно добавлять qj
        /// </summary>
        /// <returns></returns>
        public static string HowManyQJ()
        {
            Console.Write("Заданных вероятностей > 1?(да/нет): ");
            string result = Console.ReadLine();
            return result;
        }

        /// <summary>
        /// Заполнение и вывод с клавиатуры известной вероятности состояния
        /// </summary>
        /// <returns>известная вероятность состояния</returns>
        public static double InputQJ()
        {
            Console.Clear();
            Console.WriteLine("Вводить только числа, дробное число вводите через , ");
            Console.Write("Введите qj = ");
            double x = double.Parse(Console.ReadLine());
            return x;
        }
        /// <summary>
        /// Проверка вероятности
        /// </summary>
        /// <param вероястность состояния 1="qj1"></param>
        /// <param вероястность состояния 2="qj2"></param>
        /// <param вероястность состояния 3="qj3"></param>
        /// <returns>истину или ложь</returns>
        public static bool SumQj(double qj1, double qj2, double qj3)
        {
            if (qj1 + qj2 + qj3 != 1) return false;
            else return true;

        }
        public static bool SumQj(double qj1)
        {
            if (qj1 != 1) return false;
            else return true;
        }

        /// <summary>
        /// Шаг 0. Находим максимальное число в трёх матрицах 
        /// и отмимаем его от каждого элемента в матрицах
        /// </summary>
        /// <param name="arE1"></param>
        /// <param name="arE2"></param>
        /// <param name="arE3"></param>
        public static void Zero(double[] arE1, double[] arE2, double[] arE3)
        {
            double maxE1 = arE1.Max();
            double maxE2 = arE2.Max();
            double maxE3 = arE3.Max();
            double max;

            if (maxE1 > maxE2 && maxE1 > maxE3) max = maxE1 + 1;
            else if (maxE2 > maxE1 && maxE2 > maxE3) max = maxE2 + 1;
            else max = maxE3 + 1;
            Console.WriteLine("Cреди eij встречаются положительные значения," +
                              " можно перейти к отрицательным\n" +
                              "a = {0}",
                                max);

            Console.Write("\nE1 = {");
            for (int i = 0; i < arE1.Length; i++)
            {
                arE1[i] -= max;
                Console.Write($"{Math.Round(arE1[i], 2)}\t");
            }
            Console.Write("}\n");
            Console.Write("E2 = {");
            for (int i = 0; i < arE2.Length; i++)
            {
                arE2[i] -= max;
                Console.Write($"{Math.Round(arE2[i], 2)}\t");
            }
            Console.Write("}\n");
            Console.Write("E3 = {");
            for (int i = 0; i < arE3.Length; i++)
            {
                arE3[i] -= max;
                Console.Write($"{Math.Round(arE3[i], 2)} \t");
            }
            Console.Write("}\n");
            Console.WriteLine("\nНажмите на любую клавишу для продолжения...");
            Console.ReadKey();
        }

        /// <summary>
        /// Шаг 1.
        /// Умножение каждого элемента в матрице
        /// на известную вероятность состояния
        /// </summary>
        /// <param ar="double[]"></param>
        public static void One(double[] arE1, double[] arE2, double[] arE3, double qj)
        {
            Console.WriteLine("Шаг 1. Умножение каждого элемента в матрице на известную вероятность состояния qj ={0}", qj);
            Console.Write("\nE1 = ");
            for (int i = 0; i < arE1.Length; i++)
            {
                arE1[i] = arE1[i] * qj;
                Console.Write($"{Math.Round(arE1[i], 2)}\t");        // вывод значений с двумя знаками после запятой
            }
            Console.WriteLine();
            Console.Write("E2 = ");
            for (int i = 0; i < arE2.Length; i++)
            {
                arE2[i] = arE2[i] * qj;
                Console.Write($"{Math.Round(arE2[i], 2)}\t");
            }
            Console.WriteLine();
            Console.Write("E3 = ");
            for (int i = 0; i < arE3.Length; i++)
            {
                arE3[i] = arE3[i] * qj;
                Console.Write($"{Math.Round(arE3[i], 2)}\t");
            }
            Console.WriteLine();
            Console.WriteLine("\nНажмите на любую клавишу для продолжения...");
            Console.ReadKey();

        }
        /// <summary>
        /// Шаг 1.
        /// Умножение каждого элемента в матрице
        /// на известную вероятность состояния
        /// </summary>
        /// <param ar="double[]"></param>
        public static void One(double[] arE1, double[] arE2, double[] arE3, double qj1, double qj2, double qj3)
        {
            Console.WriteLine("Шаг 1. Умножение каждого элемента в матрице на известную вероятность состояния qj1 ={0}; qj2 ={1}; qj3 ={2}", qj1, qj2, qj3);

            for (int i = 0; i < arE1.Length - 2 && i < arE2.Length - 2 && i < arE3.Length - 2; i++)
            {
                arE1[i] = arE1[i] * qj1;
                arE2[i] = arE2[i] * qj1;
                arE3[i] = arE3[i] * qj1;
            }
            for (int i = 1; i < arE1.Length - 1 && i < arE2.Length - 1 && i < arE3.Length - 1; i++)
            {
                arE1[i] = arE1[i] * qj2;
                arE2[i] = arE2[i] * qj2;
                arE3[i] = arE3[i] * qj2;
            }
            for (int i = 2; i < arE1.Length && i < arE2.Length && i < arE3.Length; i++)
            {
                arE1[i] = arE1[i] * qj3;
                arE2[i] = arE2[i] * qj3;
                arE3[i] = arE3[i] * qj3;
            }

            Console.Write("\nE1 = ");
            for (int i = 0; i < arE1.Length; i++)
            {

                Console.Write($" {Math.Round(arE1[i], 2)}\t");        // вывод значений с двумя знаками после запятой
            }
            Console.WriteLine();
            Console.Write("E2 = ");
            for (int i = 0; i < arE2.Length; i++)
            {

                Console.Write($" {Math.Round(arE2[i], 2)}\t");
            }
            Console.WriteLine();
            Console.Write("E3 = ");
            for (int i = 0; i < arE3.Length; i++)
            {

                Console.Write($" {Math.Round(arE3[i], 2)}\t");
            }

            Console.WriteLine();
            Console.WriteLine("\nНажмите на любую клавишу для продолжения...");
            Console.ReadKey();

        }

        /// <summary>
        /// Шаг 2. Найти минимальное значение
        /// </summary>
        /// <param ar="double[]"></param>
        public static double[] Two(double[] arE1, double[] arE2, double[] arE3)
        {

            double minG1 = Math.Round(arE1.Min(), 2);              // ищем минимальный элемент в массиве
            double minG2 = Math.Round(arE2.Min(), 2);
            double minG3 = Math.Round(arE3.Min(), 2);
            double[] minAr = { minG1, minG2, minG3 };
            return minAr;
        }
        public static void Two(double[] ar)
        {
            Console.WriteLine("\nШаг 2. Находим минимальное значение\n" +
                                "\nG1 = {0}\n" +
                                "G2 = {1}\n" +
                                "G3 = {2}", ar[0], ar[1], ar[2]);
            Console.WriteLine("\nНажмите на любую клавишу для продолжения...");
            Console.ReadKey();

        }

        /// <summary>
        /// Шаг 3. Найти максимальное значение среди минимальных
        /// </summary>
        /// <param ar="double[]"></param>
        public static double Three(double[] ar)
        {
            double Gmax = ar.Max();                 // ищем минимальное значение
            return Gmax;
        }
        public static void Three(double Gmax)
        {
            Console.WriteLine("\nШаг 3. Находим максимальное значение среди минимальных значений\n" +
                              "\nGmax = {0}", Gmax);
            Console.ReadKey();
        }

        /// <summary>
        /// Определение выгодного проекта
        /// </summary>
        /// <param Gmax=double></param>
        public static string SelectProject(double Gmax, double qj)
        {

            double[] arE1 = { 94, 50, 18 };
            double[] arE2 = { 51, 27, 11 };
            double[] arE3 = { 19, 11, 7 };
            double maxE1 = arE1.Max();
            double maxE2 = arE2.Max();
            double maxE3 = arE3.Max();
            double max;
            string E1 = "E1 эффективнее";
            string E2 = "E2 эффективнее";
            string E3 = "E3 эффективнее";
            string error = "ошибка";

            if (maxE1 > maxE2 && maxE1 > maxE3) max = maxE1 + 1;
            else if (maxE2 > maxE1 && maxE2 > maxE3) max = maxE2 + 1;
            else max = maxE3 + 1;

            for (int i = 0; i < arE1.Length; i++)
            {
                arE1[i] -= max;
                arE1[i] = arE1[i] * qj;
                Math.Round(arE1[i], 2);
                if (arE1[i] == Gmax)
                    return E1;
            }
            for (int i = 0; i < arE2.Length; i++)
            {
                arE2[i] -= max;
                arE2[i] = arE2[i] * qj;
                Math.Round(arE2[i], 2);
                if (arE2[i] == Gmax)
                    return E2;
            }
            for (int i = 0; i < arE3.Length; i++)
            {
                arE3[i] -= max;
                arE3[i] = arE3[i] * qj;
                Math.Round(arE3[i], 2);
                if (arE3[i] == Gmax)
                    return E3;
            }

            return error;

        }

        public static string SelectProject(double Gmax, double[] ar1, double[] ar2, double[] ar3)
        {
            double[] arE1 = ar1;
            double[] arE2 = ar2;
            double[] arE3 = ar3;
            string E1 = "E1 эффективнее";
            string E2 = "E2 эффективнее";
            string E3 = "E3 эффективнее";
            string error = "Error";

            for (int i = 0; i < arE1.Length; i++)
            {

                arE1[i] = Math.Round(arE1[i], 2);
                if (arE1[i] == Gmax)
                    return E1;
            }
            for (int i = 0; i < arE2.Length; i++)
            {

                arE2[i] = Math.Round(arE2[i], 2);
                if (arE2[i] == Gmax)
                    return E2;
            }
            for (int i = 0; i < arE3.Length; i++)
            {

                arE3[i] = Math.Round(arE3[i], 2);
                if (arE3[i] == Gmax)
                    return E3;
            }

            return error;

        }
        public static void InputProject(string Project)
        {
            Console.WriteLine("\nПриходим к выводу что {0}", Project); Console.ReadKey();
        }

    }
}
