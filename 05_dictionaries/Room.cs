namespace _05_dictionaries;

class Room
{
    internal int x, y;
    internal string[] level;

    internal Room(int x, int y, string[] level)
    {
        this.x = x;
        this.y = y;
        this.level = level;
    }

    public string GetRoomLocationKey()
    {
        return $"{x},{y}";
    }
}