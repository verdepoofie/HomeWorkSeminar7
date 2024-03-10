namespace HomeWorkSeminar7
{
    internal class Exercise1
    {
        public void Execute()
        {
            Console.WriteLine("Задание 1. Работа с листом");
            List<int> randomNumbers = new List<int>();
            Random random = new Random();
            Console.WriteLine("Лист целых чисел:");
            for (int i = 1; i <= 100; i++)
            {
                randomNumbers.Add(random.Next(100));
                Console.Write(randomNumbers[i - 1].ToString() + "\t");
                if (i % 10 == 0)
                    Console.WriteLine();
            }
            randomNumbers.RemoveAll(x => x > 25 && x < 50);
            Console.WriteLine();
            Console.WriteLine("Лист целых чисел без чисел, которые больше 25, но меньше 50:");
            for (int i = 1; i <= randomNumbers.Count; i++)
            {
                Console.Write(randomNumbers[i - 1].ToString() + "\t");
                if (i % 10 == 0)
                    Console.WriteLine();
            }
        }
    }
}
