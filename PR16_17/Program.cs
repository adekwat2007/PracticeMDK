namespace PR16_17
{
    //1
    internal class Personn
    {
        public string Name;
        public int Age;
    }

    internal class Student : Personn
    {
        public int Grade;
    }

    //2
    internal class Vehicle
    {
        public void Move()
        {
            Console.WriteLine("Движееение");
        }
    }

    internal class Car : Vehicle
    {
        public void OpenDoor()
        {
            Console.WriteLine("Открылась дверь");
        }
    }

    internal class Bicycle : Vehicle
    {
        public void Ring()
        {
            Console.WriteLine("Сработал звонок");
        }
    }

    //3
    internal class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Звук животного");
        }
    }

    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав");
        }
    }

    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Мяу");
        }
    }

    //4
    internal class Employee
    {
        public string Name;

        public Employee(string name)
        {
            Name = name;
        }
    }

    internal class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }
    }

    //5
    internal class BankAccount
    {
        protected decimal Balance;
    }

    internal class SavingsAccount : BankAccount
    {
        public void Deposit(decimal amount) => Balance += amount;
    }

    //6
    internal class Device
    {
        public virtual void GetInfo()
        {
            Console.WriteLine("Это базовое устройство");
        }
    }

    internal class Computer : Device
    {
        public override void GetInfo()
        {
            Console.WriteLine("Это компьютер");
        }
    }

    internal class Laptop : Computer
    {
        public override void GetInfo()
        {
            Console.WriteLine("Это ноутбук");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var c = new SchoolClass();
            c.people = new List<Person> 
            { 
                new Stud { Age = 18, Name = "Vazir" } ,
                new Teacher {Age = 32, Name="Aidar"}
            };
            c.GetAllInfo();
        }
    }
}