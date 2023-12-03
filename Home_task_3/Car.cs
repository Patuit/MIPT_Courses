namespace Home_task_3;

class Car
{
    public int SerialNumber { get; }

    Engine engine;

    public Car(int serialNumber)
    {
        var rand = new Random();
        this.SerialNumber = serialNumber;
        this.engine = new Engine(rand.Next(1, 20));
    }
}