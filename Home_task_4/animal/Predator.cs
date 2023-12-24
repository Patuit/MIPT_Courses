namespace Home_task_4;

abstract public class Predator : Animal
{
    protected Predator(int health) : base(health)
    {
    }

    public string? WhatIsEating { get; init; }
}
