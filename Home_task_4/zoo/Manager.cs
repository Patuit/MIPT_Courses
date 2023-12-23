namespace Home_task_4;

public class Manager
{
    public void ToFeed (object sender, EventArgs e) {
        if (((Animal)sender).Health <= 100)
        {
            ((Animal)sender).Health = 100;
        }
        
        Console.WriteLine(((AnimalEventArgs)e).Message);
    }
}
