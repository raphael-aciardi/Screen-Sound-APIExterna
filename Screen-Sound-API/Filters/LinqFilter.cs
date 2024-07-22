
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
        var ArtistByGenre = songs.Where(songs => songs.Genre.Contains(genre.ToLower()))
            .Select(songs => songs.Artist).Distinct().ToList();
        Console.WriteLine($"Display artists by musical genre >>> {genre}");
        foreach (var artist in ArtistByGenre) Console.WriteLine($"Arstist: {artist}");
        
    }
}
