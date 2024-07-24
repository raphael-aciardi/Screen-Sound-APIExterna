using Screen_Sound_API.Models;
using System.Text.Json;
using Screen_Sound_API.Filters;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var songs = JsonSerializer.Deserialize<List<Song>>(resposta)!;
        //LinqFilter.FilterMusicGenre(songs);
        //LinqOrder.DisplayOrderArtistList(songs);
        // LinqFilter.FilterArtistByMusicalGenre(songs, "Rock");
        //LinqFilter.FilterSongByArtist(songs, "U2");

        var raphaelsFavoriteSongs = new FavoriteSongs("Raphael");
        var claudiosFavoriteSongs = new FavoriteSongs("Claudio");

        raphaelsFavoriteSongs.AddFavoriteSongs(songs[1]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[4]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[3]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[123]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[137]);


        raphaelsFavoriteSongs.DisplayFavoriteSongs();

        //claudiosFavoriteSongs.AddFavoriteSongs(songs[1]);
        //claudiosFavoriteSongs.AddFavoriteSongs(songs[4]);
        //claudiosFavoriteSongs.AddFavoriteSongs(songs[3]);
        //claudiosFavoriteSongs.AddFavoriteSongs(songs[123]);

        //claudiosFavoriteSongs.DisplayFavoriteSongs();

        raphaelsFavoriteSongs.CreateJson();
    }
    catch (Exception ex) 
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}

