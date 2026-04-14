using System;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void ReadJSON_103022400046()
    {
        try
        {
            var options = new JsonSerializerOptions { IncludeFields = true };

            Console.WriteLine("\n=== Film Favorit Aul ===");
            string jsonaul1 = File.ReadAllText("jurnal7_1_103022400046.json");
            var favaul = JsonSerializer.Deserialize<FilmFaforit_103022400046>(jsonaul1, options);
            Console.WriteLine($"Judul Film {favaul?.title} ");
            Console.WriteLine($"Direktur Film {favaul?.director} ");
            Console.WriteLine($"Tahun Film {favaul?.year} ");
            Console.WriteLine($"Genre Film {favaul?.genre} ");
            Console.WriteLine($"Rating Film {favaul?.rating} ");
            Console.WriteLine($"Durasi Film {favaul?.durationMinute} ");
            Console.WriteLine($"Apakah Film ini sudah ditonton{favaul?.isWatched} ");

            string jsonaul2 = File.ReadAllText("jurnal7_2_103022400046.json");
            var watchList = JsonSerializer.Deserialize<WatchList_103022400046>(jsonaul2, options);
            Console.WriteLine($"Watchlist name: {watchList?.watchlistName} ");
            Console.WriteLine($"Created By: {watchList?.createdBy} ");
            Console.WriteLine("Watchlist:");
            if (watchList?.movies != null)
            {
                for (int i = 0; i < watchList.movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {watchList.movies[i].id} {watchList.movies[i].title} ( {watchList.movies[i].year} - {watchList.movies[i].rating} )");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error pada data Aul: {ex.Message}");
        }
    }
    public static void Main()
    {
        ReadJSON_103022400046();
    }
}