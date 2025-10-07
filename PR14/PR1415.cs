namespace PR1415
{
    internal class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 6 && value <= 100)
                    _age = value;
                else
                    Console.WriteLine("Некорректный возраст");
            }
        }

        private int _grade;

        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

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

        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}; Возраст: {Age}; Класс: {Grade}");
        }
    }

    internal class Book
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _author;

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        private int _pages;

        public int Pages
        {
            get { return _pages; }
            set
            {
                if (value >= 1)
                    _pages = value;
                else
                    Console.WriteLine("Некорректное количество страниц");
            }
        }

        public Book()
        {
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public void ShortInfo()
        {
            Console.WriteLine($"Название: {Title}; Автор: {Author}; Страницы: {Pages}");
        }
    }

    internal class Rectangle
    {
        private double _length;

        public double Length
        {
            get { return _length; }
            set
            {
                if (value >= 0)
                    _length = value;
                else
                    Console.WriteLine("Длина не может быть отрицательной");
            }
        }

        private double _width;

        public double Width
        {
            get { return _width; }
            set
            {
                if (value >= 0)
                    _width = value;
                else
                    Console.WriteLine("Длина не может быть отрицательной");
            }
        }

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

        public double GetArea() => Length * Width;

        public double GetPerimeter() => (Length + Width) * 2;
    }

    internal class Car
    {
        private string _brand;

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set
            {
                if (value >= 1886)
                    _year = value;
                else
                    Console.WriteLine("Некорректный год");
            }
        }

        public Car()
        {
        }

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
        private decimal _balance;

        public decimal Balance => _balance;

        public BankAccount()
        {
        }

        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            _balance = balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Нельзя вносить отрицателную сумму");
                return;
            }
            _balance += amount;
            Console.WriteLine($"Баланс: +{amount}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("На счете недостаточно средств");
                return;
            }
            _balance -= amount;
            Console.WriteLine($"Баланс: -{amount}");
        }

        public void DisplayBalance() => Console.WriteLine($"Баланс: {Balance}");
    }

    internal class PR1415
    {
        private static void Main(string[] args)
        {
        }
    }
}