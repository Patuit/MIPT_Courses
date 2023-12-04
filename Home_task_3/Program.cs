namespace Home_task_3;

class Program
{
    static void Main(string[] args)
    {

        Customer people1 = new Customer("Sofia");
        Customer people2 = new Customer("Mark");
        Customer people3 = new Customer("Poludev Evgeniy");
        List<Customer> manyPeople = new List<Customer>() { people1, people2, people3 };
        FactoryAF factory = new FactoryAF(manyPeople);
        for (int i = 0; i < 2; i++)
        {
            factory.AddCar();
        }
        Console.WriteLine("Состояние покупателей и машин ДО SaleCar");
        Test(factory);
        factory.SaleCar();
        Console.WriteLine("Состояние покупателей и машин ПОСЛЕ SaleCar");
        Test(factory);
    }

    static void Test(FactoryAF factory)
    {
        Console.WriteLine($"Количество покупателей: {factory.customers.Count()}.");
        foreach (var customer in factory.customers)
        {
           Console.WriteLine($"Покупатель {customer.Fio} {(customer.Car is not null ? "имеет автомобиль с номером: " + customer.GetSNCar() : "не имеет авто, так что только трамвай 11..")}"); 
        }

        Console.WriteLine();
        Console.WriteLine($"Количество машин на фабрике {factory.cars.Count()}.");
        foreach (var car in factory.cars)
        {
            Console.WriteLine($"Серийный номер машины {car.SerialNumber}, Размер педалей {car.engine.PedalSize}.");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
