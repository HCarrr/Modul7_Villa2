using System;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void ReadJSON_103022400129()
    {
        try
        {
            var options = new JsonSerializerOptions { IncludeFields = true };

            Console.WriteLine("\n=== Film Favorit Dewo ===");
            string jsondwo1 = File.ReadAllText("jurnal7_1_103022400129.json");
            var favdwo = JsonSerializer.Deserialize<FilmFavorit_103022400129>(jsondwo1, options);
            Console.WriteLine($"Judul Film {favdwo?.title} ");
            Console.WriteLine($"Direktur Film {favdwo?.director} ");
            Console.WriteLine($"Tahun Film {favdwo?.year} ");
            Console.WriteLine($"Genre Film {favdwo?.genre} ");
            Console.WriteLine($"Rating Film {favdwo?.rating} ");
            Console.WriteLine($"Durasi Film {favdwo?.durationMinutes} ");
            Console.WriteLine($"Apakah Film ini sudah ditonton{favdwo?.isWatched} ");

            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error pada data Dewo: {ex.Message}");
        }
    }
    public static void Main()
    {
        ReadJSON_103022400129();
    }
}
