namespace Home_task_4;


abstract public class Animal : IInventory, IAlive
{
    public Animal(int serialNumber, int health)
    {
        Number = serialNumber;
        Health = health;
    }

    public int Health { get; set; }
    public int Number { get; init; }

    public event EventHandler? NotifyEat;

    public void StartSarving()
    {
        NotifyEat?.Invoke(this, new AnimalEventArgs("Жизненные силы покидают меня!"));
    }

    public void ToDamage() {
        Random rnd = new Random();
        int damageNumber = rnd.Next(10, 100);
        Health -= damageNumber;
        Console.WriteLine("Во время ToDamage " + Health);
        NotifyEat?.Invoke(this, new AnimalEventArgs("Алло? Ай нид хелп!"));
    }

}

public class AnimalEventArgs : EventArgs
{
    public AnimalEventArgs(string message)
    {
        Message = message;
    }
    public string Message { get; set; }
}