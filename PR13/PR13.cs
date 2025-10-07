using System.Diagnostics;
using System.Xml.Linq;

namespace PR13
{
    internal class Student
    {
        public string Name;
        public int Age;
        public int Grade;

        public Student()
        {
            Name = "Vazir";
            Age = 18;
            Grade = 1;
        }

        public Student(string name, int age, int grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        ~Student()
        {
            Console.WriteLine("Студент уничтожен");
        }

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

        public Book()
        {
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        ~Book()
        {
            Console.WriteLine("Книга уничтожена");
        }

        public void ShortInfo()
        {
            Console.WriteLine($"Название: {Title}; Автор: {Author}; Страницы: {Pages}");
        }
    }

    internal class Rectangle
    {
        public double Length;
        public double Width;

        public Rectangle()
        {
            Length = 10;
            Width = 5;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        ~Rectangle()
        {
            Console.WriteLine("Прямоугоольник уничтожен");
        }

        public double GetArea() => Length * Width;

        public double GetPerimeter() => (Length + Width) * 2;
    }

    internal class Car
    {
        public string Brand;
        public string Model;
        public int Year;

        public Car()
        {
        }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        ~Car()
        {
            Console.WriteLine("Машина уничтожена");
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

        public BankAccount()
        {
            Console.WriteLine("Вызван конструктор без параметров");
        }

        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
            Console.WriteLine("Вызван конструктор с параметрами");
        }

        ~BankAccount()
        {
            Console.WriteLine("Объект счета уничтожен");
        }

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

    internal class BankAccountDemo
    {
        public string Owner;
        public decimal Balance;

        public BankAccountDemo()
        {
        }

        public BankAccountDemo(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
            Console.WriteLine("Вызван конструктор с параметрами");
        }

        ~BankAccountDemo()
        {
            Console.WriteLine("Объект счета уничтожен");
        }
    }

    internal class PR13
    {
        private static void Main(string[] args)
        {
            #region 1

            Console.WriteLine("1)");
            var st1 = new Student();
            var st2 = new Student() { Name = "Aydar", Age = 18, Grade = 3 };
            st2.DisplayInfo();

            #endregion 1

            #region 2

            Console.WriteLine();
            Console.WriteLine("2)");
            var b1 = new Book("Voyna i Mir", "Tolstoy", 2036);
            var b2 = new Book() { Title = "Harry Potter", Author = "Rowling", Pages = 312 };

            b1.ShortInfo();
            b2.ShortInfo();

            #endregion 2

            #region 3

            Console.WriteLine();
            Console.WriteLine("3)");
            var rect1 = new Rectangle();
            var rect2 = new Rectangle(10, 5);
            Console.WriteLine($"Площадь: {rect2.GetArea()}");
            Console.WriteLine($"Периметр: {rect2.GetPerimeter()}");

            #endregion 3

            #region 4

            Console.WriteLine();
            Console.WriteLine("4)");
            var car1 = new Car("Lada", "Granta", 2018);
            var car2 = new Car() { Brand = "BMW", Model = "530-e", Year = 2020 };
            car1.CarInfo();
            car2.CarInfo();

            #endregion 4

            #region 5

            Console.WriteLine();
            Console.WriteLine("5)");
            var acc = new BankAccount("Aydar", 0);
            var acc2 = new BankAccount() { Owner = "Vazir", Balance = 1000 };
            acc2.Deposit(200);
            acc2.Withdraw(1500);
            acc2.DisplayBalance();

            CtorDectorDemo();

            #endregion 5
        }

        internal class Test
        {
            public string Name { get; set; }
        }

        private static void CtorDectorDemo()
        {
            Console.ReadLine();
            Console.WriteLine("ДОПОЛНИТЕЛЬНО");

            for (int i = 0; i < 2; i++)
            {
                var temp = new BankAccountDemo("Vazir", 1000);
            }

            Thread.Sleep(2000);

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}