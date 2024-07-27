

using System.Text.Json.Serialization;

namespace Screen_Sound_API.Models;

internal class Song
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int key { get; set; }

    List<string> keysList = new List<string> {
    "C",
    "C#",
    "D",
    "D#",
    "E",
    "F",
    "F#",
    "G",
    "G#",
    "A",
    "A#",
    "B"
    };

    public void ViewSongDetails()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Music: {Name}");
        Console.WriteLine($"Duration in seconds: {Duration / 1000}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"The key is {keysList[key]};");
    }

}
