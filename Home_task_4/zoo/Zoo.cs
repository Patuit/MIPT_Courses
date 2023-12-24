using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Home_task_4;

/// <summary>
/// Zoo "Nazareth - Animals"
/// </summary>
public class Zoo
{
    /// <summary>
    /// Баланс Зоопарка
    /// </summary>
    List<IInventory> theCompanysBalanceSheet = new List<IInventory>();

    /// <summary>
    /// Список животных Зоопарка
    /// </summary>
    ObservableCollection<Animal> animals = new ObservableCollection<Animal>();

    VetClinic vetClinicZoo = new VetClinic();

    Manager myManager = new Manager();

    public Zoo()
    {
        animals.CollectionChanged += AnimalsCollectionChanged;
    }

    /// <summary>
    /// Добавить в Зоопарк
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="addThing"></param>
    public void Add<T>(T addThing)
    {
        if (addThing is null)
        {
            return;
        }

        // Чтобы не добавляли в зоопарк, оно должно попадать на баланс предприятия
        if (addThing is IInventory thing)
        {
            Random rnd = new Random();
            thing.Number = rnd.Next(111111, 999999);
            theCompanysBalanceSheet.Add(thing);
            // Console.WriteLine($"{}");

            // Если это животное, то добавляем в отдельный список животных. К ним особое отношение :)
            if (thing is Animal animal)
            {
                if (vetClinicZoo.checkAnimal(animal))
                {
                    animals.Add(animal);
                    if (animal.Health < 100)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Только приняли в зоопарк {animal.GetType().Name} со здоровьем здоровье: {animal.Health}.");

                        animal.CryToHelp();
                        Console.WriteLine();
                        Console.WriteLine($"После кормёжки {animal.GetType().Name} здоровье: {animal.Health}.");

                    }
                }
                else
                {
                    Remove(animal);
                }
            }
        }
    }

    /// <summary>
    /// Убрать с баланса Зоопарка
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="rmThing"></param>
    public void Remove<T>(T rmThing)
    {
        if (rmThing is null)
        {
            return;
        }

        if (rmThing is IInventory thing)
        {
            thing.Number = 0;
            theCompanysBalanceSheet.Remove(thing);

            if (thing is Animal animal)
            {
                animals.Remove(animal);
            }
        }
    }

    /// <summary>
    /// Депрессия, что сеяла хаос, голод и болезни
    /// </summary>
    public void BadRain()
    {
        foreach (var animal in animals)
        {
            animal.ToDamage();
            Console.WriteLine();
            Console.WriteLine($"После депрессии {animal.GetType().Name} имеет здоровье: {animal.Health}.");

        }
    }

    private void AnimalsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if (sender == null)
        {
            return;
        }

        // При добавлении животного в список зоопарка - Менеджер подписывается на животное
        if (e.NewItems != null && e.NewItems[0] is Animal addAnimal && addAnimal != null && e.Action == NotifyCollectionChangedAction.Add)
        {
            addAnimal.NotifyEat += myManager.ToFeed;
            Console.WriteLine();
            Console.WriteLine($"Менеджер теперь будет присматривать за {addAnimal.GetType().Name}.");
        }

        // При удалении животного из списка зоопарка - Менеджер отписывается от животного
        else if
        (e.OldItems != null && e.OldItems[0] is Animal rmAnimal && rmAnimal != null && e.Action == NotifyCollectionChangedAction.Remove)
        {
            rmAnimal.NotifyEat -= myManager.ToFeed;
            Console.WriteLine();
            Console.WriteLine($"Менеджер отпускает {rmAnimal.GetType().Name}, но он навсегда останется в его сердце..");

        }
    }
}
