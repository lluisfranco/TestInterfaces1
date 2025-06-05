namespace TestInterfaces1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mydog = new Dog
            {
                Name = "Bobby",
                OwnerName = "Ven",
                LegsNumber = 3
            };
            mydog.Eat();
            mydog.Sleep();
            Console.ReadLine();
        }
    }

    public interface IAnimal
    {
        public string Name { get; set; }
        public int LegsNumber { get; set; }
        public void Eat();
        public void Sleep();
    }

    public interface IOwnerInfo
    {
        public string OwnerName { get; set; }
    }

    public class Dog : IAnimal, IOwnerInfo
    {
        public string Name { get; set; } = "";
        public int LegsNumber { get; set; } = 4; //default
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating. Thx { OwnerName}");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping. Time to relax {OwnerName}");
        }
        public string OwnerName { get; set; } = "";
    }

    public class Cat : IAnimal, IOwnerInfo
    {
        public string Name { get; set; } = "";
        public int LegsNumber { get; set; } = 4; //default
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating a mice. Thx for nothing {OwnerName}");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is not sleeping. Time to find it {OwnerName}");
        }
        public string OwnerName { get; set; } = "";
    }
}
