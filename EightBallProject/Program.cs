namespace EightBallProject
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var running = true;
            Console.Clear();
            while (running)
            {
                string[] answers = { "Yes", "No", "It Is Certain", "Cannot Predict Now", "Better Not Tell You Now", "Concentrate And Ask Again", "Signs Point To Yes", "My Sources Say No", "Very Doubtful" };
                var shake = new Random();
                var answerIndex = shake.Next(answers.Length);
                var randomAnswer = answers[answerIndex];

                Console.Write("Ask a Question (q to quit): ");
                var askQuestion = Console.ReadLine();

                switch (askQuestion)
                {
                    case "":
                        continue;
                    case "q":
                    case "Q":
                        running = false;
                        break;
                    default:
                    {
                        if (randomAnswer is "No" or "Cannot Predict Now" or "Better Not Tell You Now" or "My Sources Say No" or "Very Doubtful")
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("It's Not Looking Good");
                            Thread.Sleep(3000);
                            Console.WriteLine(randomAnswer);
                        }
                        else
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Hmmmm.....");
                            Thread.Sleep(4000);
                            Console.WriteLine(randomAnswer);
                        }
                        break;
                    }
                }
            }
        }
    }
}