namespace Home_task_4;

// Не травоядное и не хищник - что это?? ()_()
public class Manager
{
    public void ToFeed (object sender, EventArgs e) {
        if (((Animal)sender).Health <= 100)
        {
            ((Animal)sender).Eat();
        }
        
        Console.WriteLine(((AnimalEventArgs)e).Message);
    }
}
