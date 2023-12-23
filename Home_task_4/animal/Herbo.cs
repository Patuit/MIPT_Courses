namespace Home_task_4;

abstract public class Herbo : Animal
{
    protected Herbo(int serialNumber, int health) : base(serialNumber, health)
    {
    }

    public int LvlKind { get; set; }
}
