using System.Text;

namespace HomeWorkSeminar7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Exercise1 exercise1 = new Exercise1();
            Exercise2 exercise2 = new Exercise2();
            Exercise3 exercise3 = new Exercise3();
            Exercise4 exercise4 = new Exercise4();
            Console.WriteLine("Домашнее задание 7, для выбора задачи введите 1, 2, 3, 4");
            var answer = Console.ReadKey();
            Console.WriteLine();
            switch (answer.Key)
            {
                case ConsoleKey.D1:
                    exercise1.Execute();
                    break;
                case ConsoleKey.D2:
                    exercise2.Execute();
                    break;
                case ConsoleKey.D3:
                    exercise3.Execute();
                    break;
                case ConsoleKey.D4:
                    exercise4.Execute();
                    break;
            }
            Console.ReadLine();
        }
    }
}
