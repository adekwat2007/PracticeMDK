namespace PR18
{
    //1
    internal abstract class Figure
    {
        public abstract double GetArea();
    }

    internal class Circle : Figure
    {
        public double radius;

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    internal class Rectangle : Figure
    {
        public double a;
        public double b;

        public override double GetArea()
        {
            return a * b;
        }
    }

    //2
    internal abstract class Transport
    {
        public abstract void Start();

        public abstract void Stop();
    }

    internal class Car : Transport
    {
        public override void Start()
        {
            Console.WriteLine("Машина начала движение");
        }

        public override void Stop()
        {
            Console.WriteLine("Машина остановилась");
        }
    }

    internal class Bicycle : Transport
    {
        public override void Start()
        {
            Console.WriteLine("Велосипед начал движение");
        }

        public override void Stop()
        {
            Console.WriteLine("Велосипед остановился");
        }
    }

    //3
    internal interface IPlayable
    {
        void Play();

        void Pause();
    }

    internal class MusicPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Музыкальный плеер на паузе");
        }

        public void Play()
        {
            Console.WriteLine("Музыкальный плеер играет");
        }
    }

    internal class VideoPlayer : IPlayable
    {
        public void Pause()
        {
            Console.WriteLine("Видео плеер на паузе");
        }

        public void Play()
        {
            Console.WriteLine("Видео плеер играет");
        }
    }

    //4
    internal abstract class Device
    {
        public abstract void TurnOn();
    }

    internal interface IRechargeable
    {
        void Recharge();
    }

    internal class Smartphone : Device, IRechargeable
    {
        public override void TurnOn()
        {
            Console.WriteLine("Смартфон включился");
        }

        public void Recharge()
        {
            Console.WriteLine("Смартфон зарядился");
        }
    }

    //5
    internal interface IPayment
    {
        void Pay(decimal amount);
    }

    internal class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата по карте: {amount}руб");
        }
    }

    internal class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через PayPal: {amount}руб");
        }
    }

 
    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}