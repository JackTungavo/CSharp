using System;

namespace StoryBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StoryBuilder myStoryBuilder = new StoryBuilder();
            myStoryBuilder.AddPlotline("Once upon a time, in a faraway land...");
            myStoryBuilder.AddPlotline("The hero embarked on a quest to save the kingdom...");
            myStoryBuilder.AddPlotline("Unexpected challenges and magical encounters awaited...");
            Console.WriteLine("Story Plot:");
            Console.WriteLine(myStoryBuilder.GetPlot());
        }
    }

    class StoryBuilder
    {
        private string plot;
        {
            plot = "";
        }
        public void AddPlotline(string plotline)
        {
            plot += plotline + " ";
        }
        public string GetPlot()
        {
            return plot;
        }
    }
}
