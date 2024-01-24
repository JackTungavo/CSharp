using System;
namespace ProgrammingLanguageApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgrammingLanguage language1 = new ProgrammingLanguage("C#", 2000, "Microsoft");
            ProgrammingLanguage language2 = new ProgrammingLanguage("Java", 1995, "Sun Microsystems");
            ProgrammingLanguage language3 = new ProgrammingLanguage("Python", 1991, "Guido van Rossum");
            Console.WriteLine("Programming Language 1:");
            PrintProgrammingLanguageDetails(language1);
            Console.WriteLine("\nProgramming Language 2:");
            PrintProgrammingLanguageDetails(language2);
            Console.WriteLine("\nProgramming Language 3:");
            PrintProgrammingLanguageDetails(language3);
        }

        static void PrintProgrammingLanguageDetails(ProgrammingLanguage language)
        {
            Console.WriteLine($"Name: {language.Name}");
            Console.WriteLine($"Year of Creation: {language.YearOfCreation}");
            Console.WriteLine($"Creator: {language.Creator}");
        }
    }

    class ProgrammingLanguage
    {
        public string Name { get; }
        public int YearOfCreation { get; }
        public string Creator { get; }

        public ProgrammingLanguage(string name, int yearOfCreation, string creator)
        {
            Name = name;
            YearOfCreation = yearOfCreation;
            Creator = creator;
        }
    }
}