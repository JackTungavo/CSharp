namespace QuizPart5
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz("What is the capital of Burkina Faso?", "What is the capital of Bhutan?");
            Console.WriteLine("Question 1: " + quiz.GetQuestionOne());
            Console.WriteLine("Question 2: " + quiz.GetQuestionTwo());
        }
    }

    class Quiz
    {
        private string questionOne;
        private string questionTwo;
        public Quiz(string q1, string q2)
        {
            questionOne = q1;
            questionTwo = q2;
        }
        public string GetQuestionOne()
        {
            return questionOne;
        }

        public string GetQuestionTwo()
        {
            return questionTwo;
        }
    }
}