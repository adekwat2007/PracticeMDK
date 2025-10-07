namespace PR12
{
    internal class Student
    {
        public string Name;
        public int Age;
        public int Grade;

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}; Возраст: {Age}; Класс: {Grade}");
        }
    }

    internal class Book
    {
        public string Title;
        public string Author;
        public int Pages;

        public void ShortInfo()
        {
            Console.WriteLine($"Название: {Title}; Автор: {Author}; Страницы: {Pages}");
        }
    }

    internal class Rectangle
    {
        public double Length;
        public double Width;

        public double GetArea() => Length * Width;

        public double GetPerimeter() => (Length + Width) * 2;
    }

    internal class Car
    {
        public string Brand;
        public string Model;
        public int Year;

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void CarInfo()
        {
            Console.WriteLine($"Марка: {Brand}; Модель: {Model}; Год: {Year}");
        }
    }

    internal class BankAccount
    {
        public string Owner;
        public decimal Balance;

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Нельзя вносить отрицателную сумму");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Баланс: +{amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("На счете недостаточно средств");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Баланс: -{amount}");
        }

        public void DisplayBalance() => Console.WriteLine($"Баланс: {Balance}");
    }

    internal class PR12
    {
        private static void Main(string[] args)
        {
            #region 1

            Console.WriteLine("1)");
            var st1 = new Student() { Name = "Vazir", Age = 18, Grade = 1 };
            var st2 = new Student() { Name = "Aydar", Age = 18, Grade = 3 };
            st1.DisplayInfo();
            st2.DisplayInfo();

            #endregion 1

            #region 2

            Console.WriteLine();
            Console.WriteLine("2)");
            var b1 = new Book() { Title = "Voyna i Mir", Author = "Tolstoy", Pages = 2036 };
            var b2 = new Book() { Title = "Harry Potter", Author = "Rowling", Pages = 312 };
            b1.ShortInfo();
            b2.ShortInfo();

            #endregion 2

            #region 3

            Console.WriteLine();
            Console.WriteLine("3)");
            var rect = new Rectangle { Length = 10, Width = 5 };
            Console.WriteLine($"Площадь: {rect.GetArea()}");
            Console.WriteLine($"Периметр: {rect.GetPerimeter()}");

            #endregion 3

            #region 4

            Console.WriteLine();
            Console.WriteLine("4)");
            var car1 = new Car("Lada", "Granta", 2018);
            var car2 = new Car("BMW", "530e", 2020);
            car1.CarInfo();
            car2.CarInfo();

            #endregion 4

            #region 5

            Console.WriteLine();
            Console.WriteLine("5)");
            var acc = new BankAccount() { Owner = "Vazir", Balance = 1000 };
            acc.Deposit(200);
            acc.Withdraw(1500);
            acc.DisplayBalance();

            #endregion 5
        }
    }
}