
using System.Text.Json;
namespace Screen_Sound_API.Models;

internal class FavoriteSongs
{
    public string? Name { get; set; }
    public List<Song> FavoriteSongsList { get; }

    public FavoriteSongs(string nome)
    {
        Name = nome;
        FavoriteSongsList = new List<Song>();
    }

    public void AddFavoriteSongs(Song song)
    {
        FavoriteSongsList.Add(song);
    }

    public void DisplayFavoriteSongs()
    {
        Console.WriteLine($"These are {Name}´s favorite songs");
        foreach (var song in FavoriteSongsList)
        {
            Console.WriteLine($" - {song.Name} by the artist {song.Artist}");
        }
    }

    public void CreateJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            songs = FavoriteSongsList
        });
        string archiveName = $"FavoriteSongs-{Name}.json";
        try
        {
            File.WriteAllText(archiveName, json);
            Console.WriteLine($"Json created {Path.GetFullPath(archiveName)}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong. ;-; \n", ex);
        }
    }
}
