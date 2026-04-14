using System;
using System.Text.Json.Serialization;

public class WatchList_103022400131
{
    public string? watchlistName { get; set; }
    public string? createdBy { get; set; }
    public List<DaftarFilm_103022400131>? movies { get; set; }
}

public class DaftarFilm_103022400131 {
    public string? id { get; set; }
    public string? title { get; set; }
    public int? year { get; set; }
    public string? genre { get; set; }
    public double? rating { get; set; }
}
