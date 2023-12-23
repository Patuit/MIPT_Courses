using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Home_task_4;

/// <summary>
/// Zoo "Nazareth - Animals"
/// </summary>
public class Zoo
{
    public Zoo()
    {
        animals.CollectionChanged += AnimalsCollectionChanged;
    }

    ObservableCollection<Animal> animals = new ObservableCollection<Animal>();

    VetClinic clinic = new VetClinic();

    Manager manager = new Manager();

    public void Add<T>(T thing)
    {
        if (thing is Animal animal && animal != null)
        {
            animals.Add(animal);
            if (animal.Health == 0)
            {
                animal.StartSarving();
            }
        }
    }

    private void AnimalsCollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
    {
        if (e.Action == NotifyCollectionChangedAction.Add && e.NewItems != null && e.NewItems.Count > 0)
        {
            if (e.NewItems[0] is Animal newAnimal && newAnimal != null)
            {
                newAnimal.NotifyEat += manager.ToFeed;
            }
        }
    }

}
