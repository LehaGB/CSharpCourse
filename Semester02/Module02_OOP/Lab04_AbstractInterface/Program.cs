Animal[] animals =
{
    new Dog("Шарик"),
    new Bird("Кеша"),
    new Penguin("Петя")
};

foreach(Animal a in animals)
{
    a.PrintInfo();
    Console.WriteLine();
}


IFlyable[] flyable =
{
    new Bird("Кеша"),
    new Airplane(),
    new Helicopter()
};

foreach(IFlyable f in flyable)
{
    f.Fly();
    Console.WriteLine($"Макс. высота: {f.MaxAltitude} м");
    Console.WriteLine();
}


abstract class Animal
{
    public string Name { get; }
    public abstract string Species { get; }

    protected Animal(string name)
    {
        Name = name;
    }

    public abstract void MakeSound();

    public void PrintInfo()
    {
        Console.WriteLine($"{Species} : {Name}");
        MakeSound();
    }
}

interface IFlyable
{
    void Fly();
    int MaxAltitude { get; }
}

class Dog : Animal
{
    public override string Species => "Собака";

    public Dog(string name) : base(name)
    {
        
    }

    public override void MakeSound()
    {
        Console.WriteLine("Гав!");
    }
}

class Bird : Animal, IFlyable
{
    public override string Species => "Птица";

    public int MaxAltitude => 1000;

    public Bird(string name) : base(name)
    {
        
    }

    public void Fly()
    {
        Console.WriteLine("Летит");
    }

    public override void MakeSound()
    {
        Console.WriteLine("Чирик!");
    }
}

class Airplane : IFlyable
{
    public int MaxAltitude => 10000;

    public void Fly()
    {
        Console.WriteLine("Самолет летит");
    }
}

class Penguin : Animal
{
    public override string Species => "Пингвин";

    public Penguin(string name) : base(name)
    {
        
    }

    public override void MakeSound()
    {
        Console.WriteLine("Кря-кря!");
    }
}

class Helicopter : IFlyable
{
    public int MaxAltitude => 5000;

    public void Fly()
    {
        Console.WriteLine("Вертолет летит");
    }
}
