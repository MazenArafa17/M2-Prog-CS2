namespace Constructor;
class QuizVraagAntwoord
{
    internal QuizVraag vraag;
    internal bool goed;

    internal QuizVraagAntwoord(QuizVraag vraag)
    {
        this.vraag = vraag;
        goed = false;
    }
}