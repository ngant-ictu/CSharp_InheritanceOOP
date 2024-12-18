using System;
namespace InheritanceOOP;

public class Animal
{
    public string Name { get; set; }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($" {Name} : Woof! Woof!");
    }
}

public class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine($" {Name} : Meow! Meow!");
    }
}   

public class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "Buddy";
        dog.Bark();

        Cat cat = new Cat();
        cat.Name = "Whiskers";
        cat.Meow();
    }
}