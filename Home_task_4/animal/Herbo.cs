namespace Home_task_4;

abstract public class Herbo : Animal
{
    protected Herbo(int health) : base(health)
    {
    }

    public int LvlKind { get; init; }
}
