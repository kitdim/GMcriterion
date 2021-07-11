using System;

namespace GMcriterion
{
    class InputAndSaveArray
    {

        #region Заполнение массива данными от пользователя и его копирование
        /// <summary>
        /// Заполнение массива с клавиатуры
        /// </summary>
        /// <param name="ar"></param>
        /// <returns>Заполненный массив</returns>
        public static double[] FillArray(double[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            return ar;
        }

        /// <summary>
        /// Вывод массива
        /// </summary>
        /// <param значения проекта="ar"></param>
        public static void OutputArray(double[] ar1, double[] ar2, double[] ar3)
        {
            Console.Write("E1 ={");
            for (int i = 0; i < ar1.Length; i++)
            {
                Console.Write($" {ar1[i]} \t");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.Write("E2 ={");
            for (int i = 0; i < ar2.Length; i++)
            {
                Console.Write($" {ar2[i]} \t");
            }
            Console.Write("}");
            Console.WriteLine();
            Console.Write("E3 ={");
            for (int i = 0; i < ar3.Length; i++)
            {
                Console.Write($" {ar3[i]} \t");
            }
            Console.Write("}");
            Console.WriteLine("\nНажмите на любую клавишу для расчета...");
            Console.ReadKey(); Console.Clear();
        }

        /// <summary>
        /// Копируем массив для сохранения
        /// </summary>
        /// <param массив до изменений="ar1"></param>
        /// <returns>Копию</returns>
        public static double[] CopyArray(double[] ar1)
        {
            double[] ArrayCopy = ar1;
            return ArrayCopy;
        }
        #endregion
    }
}
