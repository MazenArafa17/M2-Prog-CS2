namespace _01_functions;

internal class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Vraag1();
        program.Vraag2();
        program.Vraag3();
        program.Vraag4();
        program.Vraag5();
        program.Vraag6();
    }

    internal void Vraag1()
{
    Console.WriteLine("How long do you think you'd survive in a zombie apocalypse?");
    string antwoord1 = Console.ReadLine();

    Console.WriteLine(antwoord1);
}

   internal void Vraag2()
   {
    Console.WriteLine("Have you ever tried talking to a animal?");
    string antwoord2 = Console.ReadLine();

    Console.WriteLine(antwoord2);
   }

    internal void Vraag3()
   {
    Console.WriteLine("Are you a silly goober?");
    string antwoord3 = Console.ReadLine();

    Console.WriteLine(antwoord3);
   }

      internal void Vraag4()
   {
    Console.WriteLine("Why do round pizzas come in square boxes?");
    string antwoord4 = Console.ReadLine();

    Console.WriteLine(antwoord4);
   }

    internal void Vraag5()
   {
    Console.WriteLine("What would you call a male ladybug?");
    string antwoord5 = Console.ReadLine();

    Console.WriteLine(antwoord5);
   }
   
    internal void Vraag6()
   {
    Console.WriteLine("Has someone caught you dancing in front of the mirror?");
    string antwoord6 = Console.ReadLine();

    Console.WriteLine(antwoord6);
   }
}