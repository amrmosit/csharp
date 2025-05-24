public interface IAnimal
{
    void Eat();
}
public class Animal : IAnimal
{
    public string? Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} says hello!");
    }
    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    } 

}
public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} barks!");
    }
}
public class Cat : Animal
{
    public string Color { get; set; }

    public Cat(string name, int age, string color) : base(name, age)
    {
        Color = color;
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} meows!");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Animal myDog = new Dog("Buddy", 3, "Golden Retriever");
        Animal myCat = new Cat("Whiskers", 2, "Black");
        List<Animal> animals = new List<Animal> { myDog, myCat };
        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }
    }
}