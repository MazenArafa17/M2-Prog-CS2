using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

namespace Constructor;

class Quiz
{
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] ingevuldeAntwoorden;

    internal Quiz(int aantalvragen)
    {
        vragen = new QuizVraag[aantalvragen];
        ingevuldeAntwoorden = new QuizVraagAntwoord[aantalvragen];
    }


    internal void VoegVraagToeOpIndex(int index, QuizVraag vraag)
    {
        vragen[index] = vraag;
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
    {
        QuizVraag quizVraag = new QuizVraag(vraag, antwoord);
        VoegVraagToeOpIndex(index, quizVraag);
    }
    internal void StelVraag(int index)
    {
        QuizVraag quizVraag = vragen[index];
        QuizVraagAntwoord antwoord = new QuizVraagAntwoord(quizVraag);

        Console.WriteLine(quizVraag.vraag);
        string gegevenAntwoord = Console.ReadLine();

        antwoord.goed = (gegevenAntwoord == quizVraag.antwoord);
        
        if (antwoord.goed)
        {
            Console.WriteLine("Correct! Neem een chocoladereep.");
        }
        else
        {
            Console.WriteLine($"Fout! Het juiste antwoord is: Ik heb geen idee.");
        }

        ingevuldeAntwoorden[index] = antwoord;
    }

    internal int GetScore()
    {
        int score = 0;
        for (int i = 0; i < ingevuldeAntwoorden.Length; i++)
        {
            if (ingevuldeAntwoorden[i].goed)
            {
                score++;
            }
        }
        return score;
    }
}
