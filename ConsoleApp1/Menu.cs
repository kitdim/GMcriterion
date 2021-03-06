using System;
using System.IO;

namespace GMcriterion
{
    class Menu
    {
        #region Задание, функционал, выбор кейса, прощание, предыдущий результат
        /// <summary>
        /// Задание
        /// </summary>
        public static void Task()
        {
            string task = "Вариант12." +
                 "\nКритерий Гермейера (qj =0.33) и Минимаксный критерий." +
                 "\n\nРазработать автоматизированную программу выбора оптимального " +
                 "\nрешения с использованием заданных критериев." +
                 "\nАкционеры на собрании Закрытого акционерного общества «Энергосвязь» обсуждают три проекта вложения инвестиций. " +
                 "\nВарианты решений таковы:" +
                 "\nE1 – проект, требующий больших вложений;" +
                 "\nE2 – проект, требующий средних финансовых вложений;" +
                 "\nE3 – проект, требующий небольших вложений." +
                 "\n" +
                 "\nУсловия, вызываемые необходимость рассмотрения и утверждения проектов следующие:" +
                 "\nF1 - большие доходы, но в течение нескольких лет;" +
                 "\nF2 - средние доходы в ближайшее время;" +
                 "\nF3 - больших доходов не предвидится, но обеспечится престижность, высокое общественное звучание проекта. " +
                 "\nРезультаты решений eij оцениваются величиной прибыли в американских долларах" +
                 "\n\t\t       F1  F2  F3" +
                 "\n\t\tE1 = { 94, 50, 18 };" +
                 "\n\t\tE2 = { 51, 27, 11 };" +
                 "\n\t\tE3 = { 19, 11, 7  };";
            Console.Write($"{task}" +
                   "\n\nНажмите на любую на клавишу для продолжения...");
            Console.ReadKey();
        }

        /// <summary>
        ///  Функционал программы
        /// </summary>
        public static void Choice()
        {
            string choice =
                "\n++++++++++++++++++++++++++++++++++" +
                "\n1-Минимаксный критерий" +
                "\n2-Критерий Гермейера" +
                "\n3-показать задание" +
                "\n4-предыдущий результат" +
                "\n5-выход" +
                "\n++++++++++++++++++++++++++++++++++";
            Console.WriteLine($"{choice}");
        }

        /// <summary>
        /// Функционал подпрограммы
        /// </summary>
        public static void Choice2()
        {
            string choice =
                "\n++++++++++++++++++++++++++++++++++" +
                "\n1-параметры по умолчанию         " +
                "\n2-ввод параметров пользователем  " +
                "\n3-вернуться назад                			        " +
                "\n++++++++++++++++++++++++++++++++++";
            Console.WriteLine($"{choice}");
        }

        /// <summary>
        /// Отправка числа на кейсы для выбора 
        /// </summary>
        /// <returns></returns>
        public static string YourСhoice()
        {
            Console.Write("\nВыберите нужный вариант для продолжения: ");
            string number = Console.ReadLine();
            Console.Clear();
            return number;
        }

        /// <summary>
        /// Прощание с пользователем
        /// </summary>
        public static void Goodbye()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 4);
            switch (value)
            {
                case 1:
                    Console.WriteLine("До свидание!");
                    break;
                case 2:
                    Console.WriteLine("Пока!");
                    break;
                case 3:
                    Console.WriteLine("Всего доброго!");
                    break;
            }
            Console.ReadKey();

        }
        /// <summary>
        /// Вывод пред. результата
        /// </summary>
        public static void Last_Result()
        {

            Console.Write(File.ReadAllText(@"c:TestFile.txt") +
                                            "\n\nНажмите на любую на клавишу для продолжения...");

            Console.ReadKey();
        }
        #endregion


    }
}
