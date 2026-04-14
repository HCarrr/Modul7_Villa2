// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text.Json;

public class Program
{
    public static void ReadJSON_103022400131()
    {
        try
        {
            var options = new JsonSerializerOptions { IncludeFields = true };

            Console.WriteLine("\n=== FilmFavorite Huda ===");
            string jsonHuda1 = File.ReadAllText("jurnal7_1_103022400131.json");
            var filmHuda = JsonSerializer.Deserialize<FilmFavorite_103022400131>(jsonHuda1, options);
            Console.WriteLine($"Judul {filmHuda?.title} \nDirektor : {filmHuda?.director}  \nYear : {filmHuda?.year} \nGenre : {filmHuda?.genre} \nRating : {filmHuda?.rating} \nduration : {filmHuda?.durationMinutes} isWatched? : {filmHuda?.isWatched}");

            

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error pada data Huda: {ex.Message}");
        }
    }

    public static void Main()
    {
        ReadJSON_103022400131();
    }
}
