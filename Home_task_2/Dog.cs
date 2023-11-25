namespace Home_task_2;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void Say()
    {
        base.Say("Гав-гав. Гав-но вваша миффология.");
    }
}
