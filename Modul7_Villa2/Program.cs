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
            string jsonaul = File.ReadAllText("jurnal7_1_103022400046.json");
            var favaul = JsonSerializer.Deserialize<FilmFaforit_103022400046>(jsonaul, options);
            Console.WriteLine($"Judul Film {favaul?.title} ");
            Console.WriteLine($"Direktur Film {favaul?.director} ");
            Console.WriteLine($"Tahun Film {favaul?.year} ");
            Console.WriteLine($"Genre Film {favaul?.genre} ");
            Console.WriteLine($"Rating Film {favaul?.rating} ");
            Console.WriteLine($"Durasi Film {favaul?.durationMinute} ");
            Console.WriteLine($"Apakah Film ini sudah ditonton{favaul?.isWatched} ");


        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error pada data Dewo: {ex.Message}");
        }
    }
    public static void Main()
    {
        ReadJSON_103022400046();
    }
}