
using System.Text.Json.Serialization;

namespace Screen_Sound_API.Modelos;

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

    public void ViewSongDetails()
    {
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Music: {Name}");
        Console.WriteLine($"Duration in seconds: {Duration / 1000}");
        Console.WriteLine($"Genre: {Genre}");
    }
}
