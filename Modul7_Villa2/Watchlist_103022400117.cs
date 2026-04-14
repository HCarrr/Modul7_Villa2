using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Watchlist_103022400117
{
    public string? watchlistName { get; set; }
    public string? createdBy { get; set; }

    public List<List_103022400117>? movies { get; set; }
}

public class List_103022400117
{
    public string? id { get; set; }
    public string? title { get; set; }
    public int? year { get; set; }
    public string? genre { get; set; }
    public double? rating { get; set; }
}