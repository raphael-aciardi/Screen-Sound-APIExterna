
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
}
