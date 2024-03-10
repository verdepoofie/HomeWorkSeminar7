namespace HomeWorkSeminar7
{
    internal class Exercise2
    {
        private Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        public void Execute()
        {
            Console.WriteLine("Задание 2. Телефонная книга");
            while (true)
            {
                Console.WriteLine("Введите 1 для новой записи, 2 - для поиска по номеру, Q - для выхода из программы");
                var key = Console.ReadKey();
                Console.WriteLine();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        AddNumber();
                        break;
                    case ConsoleKey.D2:
                        SearchByPhone();
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }
        }
        private void AddNumber()
        {
            while (true)
            {
                Console.WriteLine("Введите Ф.И.О");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 3)
                {
                    Console.WriteLine("Введите номер телефона из 10 цифр, ввидите пустую строку для завершения ввода номеров");
                    string name = input;
                    while (true)
                    {
                        input = Console.ReadLine();
                        if (!string.IsNullOrEmpty(input) && input.Length == 10 && input.All(c => char.IsNumber(c)))
                        {
                            string phone = input;
                            phoneBook.Add(phone, name);
                        }
                        else if (string.IsNullOrEmpty(input))
                            break;
                        else
                            Console.WriteLine("Вы не верно ввели номер");
                    }
                    break;
                }
                else
                    Console.WriteLine("Вы не верно ввели Ф.И.О");
            }
        }
        private void SearchByPhone()
        {
            while (true)
            {
                Console.WriteLine("Введите номер телефона из 10 цифр");
                var input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Length == 10 && input.All(c => char.IsNumber(c)))
                {
                    if (phoneBook.TryGetValue(input, out string name))
                        Console.WriteLine(name);
                    else
                        Console.WriteLine("Такого телефона нет в книге");
                    
                    break;
                }
                else
                    Console.WriteLine("Вы не верно ввели номер");
            }
        }
    }
}
