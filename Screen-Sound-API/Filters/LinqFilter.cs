
using Screen_Sound_API.Models;

namespace Screen_Sound_API.Filters;
internal class LinqFilter
{
    public static void FilterMusicGenre(List<Song> songs)
    {
        var allMusicalGenre = songs.Select(genres => genres.Genre).Distinct().ToList();
        foreach (var genre in allMusicalGenre)
        {
            Console.WriteLine($" - {genre}");
        }
    }

    public static void FilterArtistByMusicalGenre(List<Song> songs, string genre)
    {
        var ArtistByGenre = songs
        .Where(songs => songs.Genre!
            .ToLower()
            .Contains(genre.ToLower()))
        .Select(songs => songs.Artist)
        .Distinct()
        .ToList();


        Console.WriteLine($"Display artists by musical genre >>> {genre}");

        foreach (var artist in ArtistByGenre) Console.WriteLine($"Arstist: {artist}");

    }

    public static void FilterSongByArtist(List<Song> songs, string artist)
    {
        var SongtByArtist = songs.Where(songs => songs.Artist!.Equals(artist)).ToList();
        Console.WriteLine($"Artist Name: {artist}");
        foreach (var song in SongtByArtist) Console.WriteLine($"Musica: {song.Name}");
    }

    public static void FilterByKey(List<Song> songs, int key)
    {
        var songsByKey = songs.Where(song => song.key.Equals(key)).ToList();
        Console.WriteLine($"The songs with key {key} are: ");
        foreach (var song in songsByKey)
        {
            song.ViewSongDetails();
        }
    }

}
