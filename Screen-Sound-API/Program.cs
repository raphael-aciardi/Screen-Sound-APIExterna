using Screen_Sound_API.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string answer = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var songs = JsonSerializer.Deserialize<List<Song>>(answer)!;
        //LinqFilter.FilterMusicGenre(songs);
        //LinqOrder.DisplayOrderArtistList(songs);
        // LinqFilter.FilterArtistByMusicalGenre(songs, "Rock");
        //LinqFilter.FilterSongByArtist(songs, "U2");
        //Console.WriteLine(answer);



        var raphaelsFavoriteSongs = new FavoriteSongs("Raphael");
        var claudiosFavoriteSongs = new FavoriteSongs("Claudio");

        raphaelsFavoriteSongs.AddFavoriteSongs(songs[1]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[4]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[3]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[123]);
        raphaelsFavoriteSongs.AddFavoriteSongs(songs[137]);


        //raphaelsFavoriteSongs.DisplayFavoriteSongs();

        //claudiosFavoriteSongs.AddFavoriteSongs(songs[1]);
        //claudiosFavoriteSongs.AddFavoriteSongs(songs[4]);
        //claudiosFavoriteSongs.AddFavoriteSongs(songs[3]);
        //claudiosFavoriteSongs.AddFavoriteSongs(songs[123]);

        //claudiosFavoriteSongs.DisplayFavoriteSongs();

        raphaelsFavoriteSongs.CreateJson();


        foreach (var song in songs)
        {
            song.ViewSongDetails();
            Console.WriteLine("__________________________________-");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"We have a problem: {ex.Message}");
    }
}

