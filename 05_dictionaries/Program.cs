namespace _05_dictionaries;

class Program
{
    Dictionary<string, Room> rooms = new Dictionary<string, Room>();

    static void Main(string[] args)
    {
        Program program = new Program();
        //program.Run();
        program.RunRooms();
    }


    internal void RunRooms()
    {
        Room start = new Room(0, 0, [
            "xxxxx",
            "x...x",
            "x...x",
            "x...x",
            "xxxxx"
        ]);
        rooms.Add(start.GetRoomLocationKey(), start);

        Room room2 = new Room(0, 1, [
            "xxxxx",
            "x...x",
            "x.x.x",
            "x...x",
            "xxxxx"
        ]);
        rooms.Add(room2.GetRoomLocationKey(), room2);

        Room room3 = new Room(0, 2, [
            "xxxxx",
            "x...x",
            "x.x.x",
            "x...x",
            "xxxxx"
]);
        rooms.Add(room3.GetRoomLocationKey(), room3);


        ShowRoom(0, 0);
        ShowRoom(0, 1);
        ShowRoom(0, 2);
        ShowRoom(-1, -1);
    }

    private void ShowRoom(int x, int y)
    {
        string key = $"{x},{y}";
        if (rooms.ContainsKey(key) == false)
        {
            Console.WriteLine($"Room {x} + {y} isn't real!");
            return;
        }
        Room room = rooms[key];
        Console.WriteLine($"You are in room {x},{y}");
        foreach (string r in room.level)
        {
            Console.WriteLine(r);
        }
    }
    internal void Run()
    {
        Dictionary<int, string> personeelOpNummer = new Dictionary<int, string>();
        personeelOpNummer.Add(382942, "jim");
        personeelOpNummer.Add(789432, "tim");

        string jim = personeelOpNummer[382942];
        string tim = personeelOpNummer[789432];
        Console.WriteLine(jim);
        Console.WriteLine(tim);

        foreach (KeyValuePair<int, string> item in personeelOpNummer)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }

        foreach (int key in personeelOpNummer.Keys)
        {
            Console.WriteLine(key);
        }

        foreach (string value in personeelOpNummer.Values)
        {
            Console.WriteLine(value);
        }
    }
}
