class Queue
{
    private List<string> people;

    public Queue()
    {
        people = new List<string>();
    }

    public void Add(string person)
    {
        people.Add(person);
        Console.WriteLine($"{person} has been added to the queue.");
    }

    public string Next()
    {
        if (people.Count > 0)
        {
            string nextPerson = people[0];
            people.RemoveAt(0);
            Console.WriteLine($"{nextPerson} is next in line.");
            return nextPerson;
        }
        else
        {
            Console.WriteLine("Queue is empty.");
            return null;
        }
    }

    public void State()
    {
        Console.WriteLine("Current Queue:");
        foreach (string person in people)
        {
            Console.WriteLine(person);
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of Queue
        Queue myQueue = new Queue();

        // Add people to the queue
        myQueue.Add("Alice");
        myQueue.Add("Bob");
        myQueue.Add("Charlie");

        // Display the current state of the queue
        myQueue.State();

        // Get and remove the next person in the queue
        string nextPerson = myQueue.Next();

        // Display the current state of the queue again
        myQueue.State();
    }
}