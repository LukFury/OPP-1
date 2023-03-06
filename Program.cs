using System;

public abstract class SuperHero
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Power { get; set; }
    public int Defense { get; set; }

    public abstract void UseSuperPower();

    public virtual void GetInfo()
    {
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Health: {0}", Health);
        Console.WriteLine("Power: {0}", Power);
        Console.WriteLine("Defense: {0}", Defense);
    }
}

public class FlyingSuperhero : SuperHero
{
    public int Agility { get; set; }
    public int Speed { get; set; }

    public FlyingSuperhero()
    {
        Agility = 10;
        Speed = 20;
    }

    public override void UseSuperPower()
    {
        Console.WriteLine("{0} is flying at a speed of {1} mph and agility of {2}.", Name, Speed, Agility);
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Agility: {0}", Agility);
        Console.WriteLine("Speed: {0}", Speed);
    }
}

public class SuperStrengthHero : SuperHero
{
    public int LiftingCapacity { get; set; }

    public SuperStrengthHero()
    {
        LiftingCapacity = 1000;
    }

    public override void UseSuperPower()
    {
        Console.WriteLine("{0} is using super strength to lift an object of {1} lbs.", Name, LiftingCapacity);
    }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine("Lifting Capacity: {0}", LiftingCapacity);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SuperHero hero1 = new FlyingSuperhero();
        hero1.Name = "Superman";
        hero1.Health = 100;
        hero1.Power = 90;
        hero1.Defense = 80;
        hero1.UseSuperPower();
        hero1.GetInfo();

        SuperHero hero2 = new SuperStrengthHero();
        hero2.Name = "Hulk";
        hero2.Health = 100;
        hero2.Power = 90;
        hero2.Defense = 80;
        hero2.UseSuperPower();
        hero2.GetInfo();
    }
}
