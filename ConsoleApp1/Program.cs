using System;


namespace GMcriterion
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamemeyer Gamemeyer = new Gamemeyer();
            Minimax Minimax = new Minimax();
            Menu Menu = new Menu();
            InputAndSaveArray IASA = new InputAndSaveArray();
            Save Save = new Save();


            double[] E1 = { 94, 50, 18 };           // проект, требующий больших вложений             
            double[] E2 = { 51, 27, 11 };           // проект, требующий средних вложений
            double[] E3 = { 19, 11, 7 };            // проект, требующий малых вложений
            double qj = 0.33;                       // известная вероятность состояния

            while (true)
            {
                Console.Clear();
                Menu.Choice();
                string numberChoice = Menu.YourСhoice();
                if (numberChoice == "5") { Menu.Goodbye(); break; }
                switch (numberChoice)
                {
                    case "1":                                   // Переход в минимаксный критерий
                        while (true)
                        {
                            Console.Clear();
                            Menu.Choice2();
                            string numberChoice2 = Menu.YourСhoice();
                            if (numberChoice2 == "3") break;

                            switch (numberChoice2)
                            {
                                case "1":                      // по умолчанию              

                                    InputAndSaveArray.OutputArray(E1, E2, E3); Console.Clear();
                                    Console.WriteLine(Minimax.MinimaxСriterion(E1, E2, E3)); Console.ReadKey();
                                    continue;

                                case "2":                       // ввод через клавиатуру
                                    Console.WriteLine("Вводить только числа, дробное число вводите через , ");
                                    double[] e1MinMax = new double[3]; Console.WriteLine("E1:"); InputAndSaveArray.FillArray(e1MinMax);
                                    Console.WriteLine("Вводить только числа, дробное число вводите через , ");
                                    double[] e2MinMax = new double[3]; Console.WriteLine("E2:"); InputAndSaveArray.FillArray(e2MinMax);
                                    Console.WriteLine("Вводить только числа, дробное число вводите через , ");
                                    double[] e3MinMax = new double[3]; Console.WriteLine("E3:"); InputAndSaveArray.FillArray(e3MinMax);
                                    InputAndSaveArray.OutputArray(e1MinMax, e2MinMax, e3MinMax); Console.Clear();
                                    string result = Minimax.MinimaxСriterion(e1MinMax, e2MinMax, e3MinMax); Console.WriteLine(result); Console.ReadKey();
                                    Save.SaveInfo(result);
                                    continue;

                            }
                        }
                        break;

                    case "2":                                   // Переход в критерий Геймейера
                        while (true)
                        {
                            Console.Clear();
                            Menu.Choice2();
                            string numberChoice2 = Menu.YourСhoice();
                            if (numberChoice2 == "3") break;

                            switch (numberChoice2)
                            {
                                case "1":                       // по умолчанию

                                    Gamemeyer.Zero(E1, E2, E3);
                                    Gamemeyer.One(E1, E2, E3, qj);
                                    double[] Gmin = Gamemeyer.Two(E1, E2, E3);
                                    Gamemeyer.Two(Gmin);
                                    double Gmax = Gamemeyer.Three(Gmin);
                                    Gamemeyer.Three(Gmax);
                                    string Project = Gamemeyer.SelectProject(Gmax, qj);
                                    Gamemeyer.InputProject(Project);

                                    continue;

                                case "2":                       // ввод через клавиатуру
                                    Console.WriteLine("Вводить только числа, дробное число вводите через , ");
                                    double[] e1 = new double[3]; Console.WriteLine("E1:"); InputAndSaveArray.FillArray(e1);
                                    Console.WriteLine("Вводить только числа, дробное число вводите через , ");
                                    double[] e2 = new double[3]; Console.WriteLine("E2:"); InputAndSaveArray.FillArray(e2);
                                    Console.WriteLine("Вводить только числа, дробное число вводите через , ");
                                    double[] e3 = new double[3]; Console.WriteLine("E3:"); InputAndSaveArray.FillArray(e3);
                                    double[] e1Copy = InputAndSaveArray.CopyArray(e1);
                                    double[] e2Copy = InputAndSaveArray.CopyArray(e2);
                                    double[] e3Copy = InputAndSaveArray.CopyArray(e3);

                                    string QjChoice = Gamemeyer.HowManyQJ();
                                    while (true)
                                    {
                                        switch (QjChoice)
                                        {
                                            case "да":

                                                double qj2 = Gamemeyer.InputQJ();
                                                double qj3 = Gamemeyer.InputQJ();
                                                double qj4 = Gamemeyer.InputQJ();
                                                bool ProverkaQJ = Gamemeyer.SumQj(qj2, qj3, qj4);

                                                switch (ProverkaQJ)
                                                {
                                                    case false:
                                                        Console.WriteLine("Условия Геймейера не выполняються");
                                                        Console.ReadKey();
                                                        break;
                                                    case true:
                                                        InputAndSaveArray.OutputArray(e1, e2, e3);
                                                        Gamemeyer.Zero(e1, e2, e3);
                                                        Gamemeyer.One(e1, e2, e3, qj2, qj3, qj4);
                                                        double[] Gmin2 = Gamemeyer.Two(e1, e2, e3);
                                                        Gamemeyer.Two(Gmin2);
                                                        double Gmax2 = Gamemeyer.Three(Gmin2);
                                                        Gamemeyer.Three(Gmax2);
                                                        string Project2 = Gamemeyer.SelectProject(Gmax2, e1Copy, e2Copy, e3Copy);
                                                        Gamemeyer.InputProject(Project2);
                                                        Save.SaveInfo(Project2);
                                                        break;
                                                }
                                                break;

                                            case "нет":

                                                double qj5 = Gamemeyer.InputQJ();
                                                bool ProverkaQJ2 = Gamemeyer.SumQj(qj5);

                                                switch (ProverkaQJ2)
                                                {
                                                    case false:
                                                        Console.WriteLine("Условия Геймейера не выполняються");
                                                        Console.ReadKey();

                                                        break;

                                                    case true:
                                                        InputAndSaveArray.OutputArray(e1, e2, e3);
                                                        Gamemeyer.Zero(e1, e2, e3);
                                                        Gamemeyer.One(e1, e2, e3, qj5);
                                                        double[] Gmin3 = Gamemeyer.Two(e1, e2, e3);
                                                        Gamemeyer.Two(Gmin3);
                                                        double Gmax3 = Gamemeyer.Three(Gmin3);
                                                        Gamemeyer.Three(Gmax3);
                                                        string Project3 = Gamemeyer.SelectProject(Gmax3, e1Copy, e2Copy, e3Copy);
                                                        Gamemeyer.InputProject(Project3);
                                                        Save.SaveInfo(Project3);

                                                        break;
                                                }
                                                break;

                                            default:
                                                Console.WriteLine("Error"); Console.ReadKey();
                                                break;
                                        }
                                        break;
                                    }
                                    break;
                            }
                        }
                        break;

                    case "3":                                    // вывод на экран задания

                        Menu.Task();
                        Console.Clear();
                        continue;

                    case "4":                                    // вывод пред результата

                        Menu.Last_Result();
                        Console.Clear();
                        continue;

                    default:
                        Console.Write("Делается....");
                        Console.ReadKey();
                        Console.Clear();
                        continue;

                }
            }

        }
    }
}
