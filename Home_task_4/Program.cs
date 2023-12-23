namespace Home_task_4;

class Program
{
    static void Main(string[] args)
    {
        Monkey monkey = new Monkey(344, 0);
        Rabbit rabbit = new Rabbit(324, 0);

        Zoo zoo = new Zoo();

        Console.WriteLine("monkey Before " + monkey.Health);
        Console.WriteLine("rabbit Before " + rabbit.Health);
        zoo.Add(monkey);
        zoo.Add(rabbit);
        Console.WriteLine("monkey After Add " + monkey.Health);
        Console.WriteLine("rabbit After Add " + rabbit.Health);
        monkey.ToDamage();
        rabbit.ToDamage();
        Console.WriteLine("monkey After Damage " + monkey.Health);
        Console.WriteLine("rabbit After Damage " + rabbit.Health);
    }

    public static void DisplayMessage(object? sender, EventArgs message) => Console.WriteLine(message);
}
