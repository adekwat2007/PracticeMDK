using System.Globalization;

namespace PR8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 1

            Console.WriteLine("1)");

            // 1.1
            int a = 1;
            double b = 2.2;
            decimal c = 3.3m;
            bool d = false;
            char e = 'a';

            // 1.2
            double exp = (double)a;
            double imp = a;

            // 1.3
            object pack = a;
            int unpack = (int)pack;

            // 1.4
            Console.Write("Введите число: ");
            string input = Console.ReadLine();
            var parsedInput = double.Parse(input, CultureInfo.InvariantCulture);

            Console.WriteLine($"Целое: {(int)parsedInput}");
            Console.WriteLine($"Вещественное: {parsedInput}");
            Console.WriteLine($"В процентах: {parsedInput * 100:0}%");

            #endregion 1

            #region 2

            Console.ReadLine();
            Console.WriteLine("2)");

            // 2.1
            var arr = new int[5];
            var rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 25);
            }

            Console.WriteLine("Массив:");
            Console.WriteLine(string.Join(',', arr));

            // 2.2, 2.3
            Console.WriteLine("Отсортировано:");
            Array.Sort(arr);
            Console.WriteLine(string.Join(',', arr));

            Console.WriteLine("Отсортировано в обратном порядке:");
            Array.Reverse(arr);
            Console.WriteLine(string.Join(',', arr));

            // 2.4
            Console.Write("Введите строку: ");
            string s = Console.ReadLine();
            var vowels = "aeiouAEIOU";
            var count = s.Count(vowels.Contains);
            Console.WriteLine($"Гласных: {count}");

            #endregion 2

            #region 3

            Console.ReadLine();
            Console.WriteLine("3)");

            // 3.1
            var t = (name: "John Doe", age: 21, salary: 60000);

            // 3.2, 3.3
            var employee = new Employee()
            {
                Name = "John Doe",
                Age = 21,
                Salary = 60000m
            };
            Console.WriteLine($"Имя: {employee.Name}, Возраст: {employee.Age}, Зарплата: {employee.Salary}");

            #endregion 3

            #region 4

            Console.ReadLine();
            Console.WriteLine("4)");

            // 4.3

            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                PrintDayInfo(day);

            #endregion 4

            #region 5

            Console.ReadLine();
            Console.WriteLine("5)");

            // 5.2
            Product[] products =
            {
                new Product("Milk", 60, 50),
                new Product("Coffee", 120, 20),
                new Product("Pizza", 210, 10)
            };
            Console.WriteLine("Товары:");
            foreach (var p in products)
                p.PrintInfo();

            // 5.3
            var sum = products.Sum(p => p.Price);
            Console.WriteLine($"Сумма цен всех товаров: {sum}");

            Console.WriteLine("Введите название товара для поиска: ");
            var productName = Console.ReadLine();
            var product = products.FirstOrDefault(p => p.Name == productName);

            if (product.Name == null)
                Console.WriteLine("Продукт не найден");
            else
                product.PrintInfo();

            #endregion 5
        }

        public static void PrintDayInfo(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Понедельник - рабочий день");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("Вторник - рабочий день");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("Среда - рабочий день");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Четверг - рабочий день");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Пятница - рабочий день");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("Суббота - выходной день");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Воскресенье - выходной день");
                    break;
            }
        }

        internal struct Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public decimal Salary { get; set; }
        }

        internal struct Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public Product(string name, decimal price, int quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Товар: {Name}, Цена: {Price}, Количество: {Quantity}");
            }
        }

        internal enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}