
using System.Text.Json.Serialization;

namespace Screen_Sound_API.Modelos;

internal class Music
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artist { get; set; }
}
