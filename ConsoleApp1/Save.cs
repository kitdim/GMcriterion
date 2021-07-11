using System;
using System.IO;

namespace GMcriterion
{
    class Save
    {

        #region Сохранение значений
        /// <summary>
        /// Cохранение значений 
        /// </summary>
        /// <param лучший проект="project"></param>
        public static string SaveInfo(string project)
        {
            Console.Write("\nCохранить полученный результат(да/нет)?");
            while (true)
            {
                string result = Console.ReadLine();
                Console.Clear();
                switch (result)
                {
                    case "да":
                        string path = @"c:TestFile.txt";
                        File.WriteAllText(path, project);
                        Console.WriteLine("Сохранено..."); Console.ReadKey();
                        return path;
                    case "нет":
                        return null;
                    default:
                        Console.WriteLine("Error"); Console.ReadKey();
                        return null;

                }

            }

        }
        #endregion
    }
}
