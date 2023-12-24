namespace Home_task_4;

public class VetClinic
{
    public bool checkAnimal(Animal animal)
    {
        if (animal.Health == 0)
        {
            Console.WriteLine();
            Console.WriteLine($"Объект класса {animal.GetType().Name} не принят Ветеринарной клиникой");
            return false;
        }
        Console.WriteLine();
        Console.WriteLine($"Объект класса {animal.GetType().Name} принят Ветеринарной клиникой");
        return true;
    }
}
