namespace Constructor;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("Hoe oud is je beste vriend?", "20");


        int quizGrote = 10;
        Quiz quiz = new Quiz(quizGrote);
        quiz.VoegVraagToeOpIndex(0, quizVraag);

        quiz.VoegVraagToeOpIndex(1, "Wanneer is de verjaardag van je beste vriend?", "15 october");
        quiz.VoegVraagToeOpIndex(2, new QuizVraag("Wat is je favoriete eten?", "Spaghetti"));
        
        QuizVraag quizVraag4 = new QuizVraag("I got too lazy man.", "Same here.");
        quiz.VoegVraagToeOpIndex(3, quizVraag4);

        quiz.VoegVraagToeOpIndex(4, "Vraag5", "Antwoord5");
        quiz.VoegVraagToeOpIndex(5, new QuizVraag("Vraag6", "Antwoord6"));

        quiz.VoegVraagToeOpIndex(6, "Vraag7", "Antwoord7");
        quiz.VoegVraagToeOpIndex(7, new QuizVraag("Vraag8", "Antwoord8"));

        quiz.VoegVraagToeOpIndex(8, "Vraag9", "Antwoord9");
        quiz.VoegVraagToeOpIndex(9, new QuizVraag("Vraag10", "Antwoord10"));

        for (int i = 0; i < quizGrote; i++)
        {
            quiz.StelVraag(i);
        }

        int score = quiz.GetScore();
        Console.WriteLine($"Je hebt {score} punten behaald.");
    }
}