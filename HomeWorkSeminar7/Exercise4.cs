using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWorkSeminar7
{
    internal class Exercise4
    {
        private string fileName = "person.xml";
        public struct Person
        {
            public Person()
            {

            }
            public string FullName { get; set; } = "";
            public string StreetName { get; set; } = "";
            public int HouseNumber { get; set; } = 0;
            public int ApartmentNumber { get; set; } = 0;
            public string PhoneNumber { get; set; } = "";
            public string HomePhoneNumber { get;  set; } = "";
        }
        private void AddToFile()
        {
            try
            {
                Person person = new Person();
                Console.WriteLine("Введите Ф.И.О.");
                person.FullName = (string)GetInput(nameof(person.FullName));
                Console.WriteLine("Введите улицу");
                person.StreetName = (string)GetInput(nameof(person.StreetName));
                Console.WriteLine("Введите номер дома");
                person.HouseNumber = (int)GetInput("Number");
                Console.WriteLine("Введите номер квартиры");
                person.ApartmentNumber = (int)GetInput("Number");
                Console.WriteLine("Введите номер телефона");
                person.PhoneNumber = (string)GetInput("PhoneNumber");
                Console.WriteLine("Введите номер домашнего телефона");
                person.HomePhoneNumber = (string)GetInput("PhoneNumber");
                XElement xElement = new XElement("Person", new XAttribute("name", person.FullName),
                    new XElement("Address",
                        new XElement("Street", person.StreetName),
                        new XElement("HouseNumber", person.HouseNumber),
                        new XElement("FlatNumber", person.ApartmentNumber)),
                    new XElement("Phones",
                        new XElement("MobilePhone", person.PhoneNumber),
                        new XElement("FlatPhone", person.HomePhoneNumber)));
                xElement.Save(fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка:\n" + ex.Message);
            }
        }
        private object GetInput(string inputType)
        {
            while (true)
            {
                var input = Console.ReadLine();
                switch (inputType)
                {
                    case "FullName":
                        if (!string.IsNullOrEmpty(input) && input.Split(' ').Length == 3)
                            return input;
                        break;
                    case "StreetName":
                        if (!string.IsNullOrEmpty(input))
                            return input;
                        break;
                    case "Number":
                        if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int number) && number > 0)
                            return number;
                        break;
                    case "PhoneNumber":
                        if (!string.IsNullOrEmpty(input) && input.Length == 10 && input.All(c => char.IsNumber(c)))
                            return input;
                        break;
                    default:
                        return new object();
                }
                Console.WriteLine("Не верный ввод");
            }
        }
        public void Execute()
        {
            Console.WriteLine("Задание 4. Записная книжка");
            AddToFile();
        }
    }
}
