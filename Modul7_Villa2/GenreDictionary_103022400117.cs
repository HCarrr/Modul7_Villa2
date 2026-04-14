using System.Collections.Generic;
using System.Text.Json.Serialization;

public class GenreDictionary_103022400117
{
    public string? category { get; set; }

    public List<ListGenre_103022400117>? GenreInfo { get; set; }
}

public class ListGenre_103022400117
{
    public string? id { get; set; }
    public string? name { get; set; }
    public string? description { get; set; }
    public string? popularMovies { get; set; }
}