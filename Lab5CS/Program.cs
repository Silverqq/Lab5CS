using System;

class Animal
{
    public string food;
    public string location;

    public virtual void MakeNoise()
    {
        Console.WriteLine("Животное издает звуки.");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Животное кушает.");
    }

    public void Sleep()
    {
        Console.WriteLine("Животное спит.");
    }
}

class Dog : Animal
{
    public string Breed;

    public override void MakeNoise()
    {
        Console.WriteLine("Собака лает.");
    }

    public override void Eat()
    {
        Console.WriteLine("Собака грызет кость.");
    }
}

class Cat : Animal
{
    public bool IsLazy;

    public override void MakeNoise()
    {
        Console.WriteLine("Кошка мяукает.");
    }

    public override void Eat()
    {
        Console.WriteLine("Кошка кушает рыбку.");
    }
}

class Horse : Animal
{
    public string Color;

    public override void MakeNoise()
    {
        Console.WriteLine("Лошадь фыркает.");
    }

    public override void Eat()
    {
        Console.WriteLine("Лошадь жует сено.");
    }
}

class Veterinarian
{
    public void TreatAnimal(Animal animal)
    {
        Console.WriteLine($"Еда: {animal.food}, Место обитания: {animal.location}");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.food = "Мясо";
        dog.location = "Будка";
        dog.MakeNoise();
        dog.Eat();

        Cat cat = new Cat();
        cat.food = "Рыба";
        cat.location = "Дом";
        cat.MakeNoise();
        cat.Eat();

        Horse horse = new Horse();
        horse.food = "Сено";
        horse.location = "Стойло";
        horse.MakeNoise();
        horse.Eat();

        Veterinarian vet = new Veterinarian();
        vet.TreatAnimal(dog);
        vet.TreatAnimal(cat);
        vet.TreatAnimal(horse);
    }
}
