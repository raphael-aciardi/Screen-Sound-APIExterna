
using Screen_Sound_API.Models;


namespace Screen_Sound_API.Filters;

internal class LinqOrder
{
    public static void DisplayOrderArtistList(List<Song> songs)
    {
        var orderedArtists = songs.OrderBy(songs => songs.Artist).Select(songs => songs.Artist).Distinct().ToList();
        foreach (var song in orderedArtists) 
        {
            Console.WriteLine($"Artist: {song}");
        }
    }
}
