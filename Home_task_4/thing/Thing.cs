namespace Home_task_4;

abstract public class Thing : IInventory
{
    public Thing(int serialNumber) {
        Number = serialNumber;
    }
    public int Number { get; init; }
}
