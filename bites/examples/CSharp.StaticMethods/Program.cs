namespace CSharp.StaticMethods;
class Program
{
    static void Main(string[] args)
    {
        Program staticMeth = new Program();
        staticMeth.Alert("Be careful not to forget those semi-colons!");
        staticMeth.ChangeOfPlan();
        staticMeth.Apology();
        staticMeth.PoliteNotice();
        staticMeth.HelpNeeded();
    }
    static void Alert(string message) {
      Console.WriteLine(message);
    }
    void ChangeOfPlan()
        {
            Console.WriteLine("Change of plan: The quiz will now start in 10 minutes.");
        }

    void Apology()
    {
        Console.WriteLine("We apologize for any inconvenience caused.");
    }

    void PoliteNotice()
    {
        Console.WriteLine("Polite Notice: Please refrain from using mobile phones during the quiz.");
    }

    void HelpNeeded()
    {
        Console.WriteLine("Help Needed: We are looking for volunteers to assist with quiz administration.");
    }
}