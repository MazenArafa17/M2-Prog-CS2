using System.Text.Json;

namespace Schrijven;

class Program
{
    static void Main(string[] args)
    {
        new Program().Run();
    }

    private void Run()
    {
        FavoriteGame[] games =
        {
            new FavoriteGame { Name = "Minecraft", Platform = "PC, Xbox, Playstation" },
            new FavoriteGame { Name = "God of War: Ragnarok", Platform = "PlayStation 5" },
            new FavoriteGame { Name = "SCP: Secret Laboratory", Platform = "PC" }
        };

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        string text = JsonSerializer.Serialize(games, options);

        File.WriteAllText("games.json", text);

        FavoriteGame[] loadedGames =
            JsonSerializer.Deserialize<FavoriteGame[]>(
                File.ReadAllText("games.json"),
                options
            )!;

        foreach (FavoriteGame game in loadedGames)
        {
            Console.WriteLine($"Name: {game.Name}, Platform: {game.Platform}");
        }
    }
}
