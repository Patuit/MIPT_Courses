namespace Home_task_3;

class Program
{
    static void Main(string[] args)
    {
        
        Customer people1 = new Customer("Mark");
        Customer people2 = new Customer("Lui");
        Customer people3 = new Customer("Sofia");
        List<Customer> manyPeople = new List<Customer>() { people1, people2, people3 };
        FactoryAF factory = new FactoryAF(manyPeople);
        factory.AddCar();
        factory.AddCar();
        // Console.WriteLine(man1.car);
    }
}
