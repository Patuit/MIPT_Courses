namespace Home_task_2;
using System;

public abstract class Animal
{
    public int Health { get; private set; }
    public string Name { get; }
    public int Age { get; }

    public Animal(string name)
    {
        var rand = new Random();
        Age = rand.Next(1, 15);
        Name = name;
        Health = rand.Next(1, 100);
    }

    public void PrintHealth()
    {
        Console.Write("Уровень здоровья: ");
        if (Health > 50)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Зелёный");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Белый");
        }
        Console.ResetColor();
    }

    public void Feed(int foodCount)
    {
        Health += foodCount;
    }

    public void Punish(int punchCount)
    {
        Health -= punchCount;
    }

    public virtual void Say()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age} лет.");
    }

    public virtual void Say(string? typeSay)
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age} лет. Его отношение к этому - {typeSay}.");
    }
}
