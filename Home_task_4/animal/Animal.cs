namespace Home_task_4;


abstract public class Animal : IInventory, IAlive
{
    private int _health;
    /// <summary>
    /// Здоровье от 0 до 100
    /// </summary>
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }
            else if (value > 100)
            {
                _health = 100;
            }
            else
            {
                _health = value;
            }
        }
    }
    public int Number { get; set; }

    public event EventHandler? NotifyEat;

    public Animal(int health)
    {
        Health = health;
    }

    public void CryToHelp()
    {
        NotifyEat?.Invoke(this, new AnimalEventArgs("Жизненные силы покидают меня!"));
    }

    /// <summary>
    /// Метод Подпитаться - увеличивает здоровье животного на случайное число
    /// </summary>
    public void Eat()
    {
        Random rnd = new Random();
        Health += rnd.Next(10, 100);
    }

    public void ToDamage()
    {
        Random rnd = new Random();
        Health -= rnd.Next(10, 100);

        if (Health == 0)
        {
            CryToHelp();
        }
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