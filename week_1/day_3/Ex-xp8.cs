using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var data = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
            new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
            new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
            new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
            new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
            new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
        };

        bool playAgain;
        do
        {
            playAgain = false;
            int correct = 0, incorrect = 0;
            var wrongAnswers = new List<Dictionary<string, string>>();

            foreach (var q in data)
            {
                Console.WriteLine(q["question"]);
                string userAnswer = Console.ReadLine();

                if (userAnswer.ToLower() == q["answer"].ToLower())
                {
                    correct++;
                }
                else
                {
                    incorrect++;
                    wrongAnswers.Add(new Dictionary<string, string>
                    {
                        {"question", q["question"]},
                        {"user_answer", userAnswer},
                        {"correct_answer", q["answer"]}
                    });
                }
            }

            Console.WriteLine($"Correct answers: {correct}");
            Console.WriteLine($"Incorrect answers: {incorrect}");

            if (wrongAnswers.Count > 0)
            {
                Console.WriteLine("Wrong answers:");
                foreach (var wa in wrongAnswers)
                {
                    Console.WriteLine($"- {wa["question"]}");
                    Console.WriteLine($"  Your answer: {wa["user_answer"]}");
                    Console.WriteLine($"  Correct answer: {wa["correct_answer"]}");
                }
            }

            if (incorrect > 3)
            {
                Console.Write("You had more than 3 wrong answers. Play again? (yes/no): ");
                string response = Console.ReadLine();
                if (response.ToLower() == "yes")
                {
                    playAgain = true;
                }
            }
        } while (playAgain);
    }
}