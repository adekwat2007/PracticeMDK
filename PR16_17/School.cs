namespace PR16_17
{
    internal class Person
    {
        public string Name;
        public int Age;
        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }

    class Teacher : Person
    {
        public override void GetInfo()
        {
            Console.WriteLine("Учитель:");
            base.GetInfo();
        }
    }

    class Stud : Person
    {
        public override void GetInfo()
        {
            Console.WriteLine("Студент:");
            base.GetInfo();
        }
    }

    class SchoolClass
    {
        public List<Person> people = new();

        public void GetAllInfo()
        {
            foreach(Person person in people) 
                person.GetInfo();
        }
    }
}
