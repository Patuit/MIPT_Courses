namespace Home_task_3;

class Program
{
    static void Main(string[] args)
    {
        
        Customer Mark = new Customer();
        public List<Customer> manyPeople = new List<Customer>() {Mark};
        FactoryAF factory = new FactoryAF(manyPeople);
        // Customer man1 = new Customer("Petrov", car1);
        // Console.WriteLine(man1.car);
    }
}
