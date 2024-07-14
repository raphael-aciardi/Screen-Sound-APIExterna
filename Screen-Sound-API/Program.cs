using Screen_Sound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var songs = JsonSerializer.Deserialize<List<Song>>(resposta);
        songs[0].ViewSongDetails();

    }
    catch (Exception ex) 
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}

