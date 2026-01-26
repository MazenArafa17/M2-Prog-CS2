namespace MemSave;

class Program
{
    string Welkom = "Welkom bij een slapeloze nacht coderen.";

    string saveFile = "welkomState.txt";
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    private void Run()
    {
        bool bestaandDeFile = File.Exists(saveFile);
        if (bestaandDeFile == true)
        {
            Console.WriteLine("File exists.");
            Welkom = File.ReadAllText(saveFile);
        }   
        Console.WriteLine(Welkom);
        while(true)
        {
            Console.WriteLine(Welkom);
            Console.WriteLine("Enter text, then press enter.");
            Welkom = Console.ReadLine();
            if(Welkom.Length>0)
            {
                File.WriteAllText(saveFile, Welkom);
            }
        }
    }
}
