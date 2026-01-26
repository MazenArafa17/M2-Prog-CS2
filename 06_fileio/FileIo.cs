using System.Diagnostics;
using System.Text;

namespace _06_fileio;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    private void Run()
    {
        string[] quizLines = File.ReadAllLines("quiz.txt");
        for (int i = 0; i < quizLines.Length; i++)
        {
            Console.WriteLine(quizLines[i]);
        }

        string[] artikelLines = File.ReadAllLines("nos.txt");
        for (int i = 0; i < artikelLines.Length; i++)
        {
            Console.WriteLine(artikelLines[i]);
        }
    }
}   