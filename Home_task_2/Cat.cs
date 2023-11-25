namespace Home_task_2;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Say()
    {
        base.Say("МАУУУУУ! МАУУУУ!");
    }
}
