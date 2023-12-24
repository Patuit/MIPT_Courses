namespace Home_task_4;

abstract public class Thing : IInventory
{
    public string Name { get; set; }

    /// <summary>
    /// Инвентаризационный номер - пока что без проверки уникальности((
    /// </summary>
    public int Number { get; set; }

    public Thing(string name) {
        Name = name;
    }

}
