using System.Xml;

namespace TestInterfaces1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pets = new List<IAnimalWithOwner>(); //generics
            var mydog = new Dog
            {
                Name = "Bobby",
                OwnerName = "Ven",
                LegsNumber = 3
            };
            var mycat = new Cat
            {
                Name = "Mia",
                OwnerName = "Lluis",
                LegsNumber = 4
            };
            pets.Add(mydog);
            pets.Add(mycat);

            foreach (var pet in pets)
            {
                AnimalService.FeedAnimalAndPutAnimalToSleep(pet);
            }
            Console.ReadLine();
        }
    }

    //public class ParserService
    //{
    //    public static void ParseFiles()
    //    {
    //        var savedFiles = GetSavedFilesFromDatabase();
    //        IParser andBankParser = new AndbankParser();
    //        IParser moabankParser = new MoabankParser();

    //        foreach (var savedFile in savedFiles)
    //        {
    //            if(savedFile.type == "AND") andBankParser.Parse(savedFile.content);
    //            if(savedFile.type == "MOA") moabankParser.Parse(savedFile.content);
    //        }
    //    }
    //}



    //public interface IParser
    //{
    //    public void Parse(string input);
    //}

    //public class AndbankParser : IParser
    //{
    //    public void Parse(string input)
    //    {
    //        // Implementation for Andbank parsing logic
    //        //parse the input as a CSV file

    //    }
    //}

    //public class MoabankParser : IParser
    //{
    //    public void Parse(string input)
    //    {
    //        // Implementation for Moabank parsing logic
    //        //parse the input as a XML file

    //    }
    //}

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
        public void CallOwner();
    }

    public interface IAnimalWithOwner : IAnimal, IOwnerInfo
    {

    }

    public class Dog : IAnimalWithOwner
    {
        public string Name { get; set; } = "";
        public int LegsNumber { get; set; } = 4; //default
        public void Eat()
        {
            Console.WriteLine($"DOG CLASS {Name} is eating. Thx { OwnerName}");
        }
        public void Sleep()
        {
            Console.WriteLine($"DOG CLASS {Name} is sleeping. Time to relax {OwnerName}");
        }
        public string OwnerName { get; set; } = "";
        public void CallOwner()
        {
            Console.WriteLine($"DOG CLASS Calling {OwnerName} for {Name}");
        }
    }

    public class Cat : IAnimalWithOwner
    {
        public string Name { get; set; } = "";
        public int LegsNumber { get; set; } = 4; //default
        public void Eat()
        {
            Console.WriteLine($"CAT CLASS {Name} is eating a mice. Thx for nothing {OwnerName}");
        }
        public void Sleep()
        {
            Console.WriteLine($"CAT CLASS {Name} is not sleeping. Time to find it {OwnerName}");
        }
        public string OwnerName { get; set; } = "";
        public void CallOwner()
        {
            Console.WriteLine($"CAT CLASS Calling owner {OwnerName}");
        }
    }

    public class AnimalService
    {
        public static void FeedAnimalAndPutAnimalToSleep(IAnimalWithOwner animal)
        {
            Console.WriteLine($"SERVICE INIT");
            animal.Eat();
            animal.Sleep();
            Console.WriteLine($"SERVICE Animal {animal.Name} is sleeping. Calling { animal.OwnerName}");
            animal.CallOwner();
            Console.WriteLine($"SERVICE END");
        }
    }
}
