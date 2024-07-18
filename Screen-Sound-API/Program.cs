using Screen_Sound_API.Models;
using System.Text.Json;
using Screen_Sound_API.Filters;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var songs = JsonSerializer.Deserialize<List<Song>>(resposta)!;
        LinqFilter.FilterMusicGenre(songs);
  
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}

