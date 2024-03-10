namespace HomeWorkSeminar7
{
    internal class Exercise3
    {
        public void Execute()
        {
            Console.WriteLine("Задание 3. Проверка повторов");
            HashSet<int> numbers = new HashSet<int>();
            bool exit = false;
            while (!exit)
            {
                while (true)
                {
                    Console.WriteLine("Введите число в коллекцию, или Q для выхода");
                    var input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int result))
                    {
                        if (!numbers.Contains(result))
                        {
                            numbers.Add(result);
                            Console.WriteLine("Число успешно добавленно");
                        }
                        else
                            Console.WriteLine("Такое число уже есть");
                        break;
                    }
                    else if (!string.IsNullOrEmpty(input) && input.ToUpper() == "Q")
                    {
                        exit = true;
                        break;
                    }
                    else
                        Console.WriteLine("Не верный ввод");
                }
            }
            Console.WriteLine("Коллекция чисел");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
