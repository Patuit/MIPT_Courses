namespace Home_task_4;

abstract public class Predator : Animal
{
    protected Predator(int serialNumber, int health) : base(serialNumber, health)
    {
    }

    public string? WhatIsEating { get; init; }
}
