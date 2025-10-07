namespace PR18
{
    internal abstract class Animal
    {
        public abstract void MakeSound();

        public abstract void Eat();
    }

    internal interface IMovable
    {
        void Move();
    }

    internal class Cat : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("МЯУ");
        }

        public override void Eat()
        {
            Console.WriteLine("Кот ест");
        }

        public void Move()
        {
            Console.WriteLine("Кот идет");
        }
    }

    internal class Dog : Animal, IMovable
    {
        public override void MakeSound()
        {
            Console.WriteLine("ГАВ");
        }

        public override void Eat()
        {
            Console.WriteLine("Собака ест");
        }

        public void Move()
        {
            Console.WriteLine("Собака идет");
        }
    }
}