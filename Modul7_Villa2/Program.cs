using System.IO;
using System.Text.Json;

public class Program
{
    public static void ReadJSON_103022400129()
    {
        try
        {
            var options = new JsonSerializerOptions { IncludeFields = true };


            Console.WriteLine("\n=== FilmFavorite Huda ===");
            string jsonHuda1 = File.ReadAllText("jurnal7_1_103022400131.json");
            var filmHuda = JsonSerializer.Deserialize<FilmFavorite_103022400131>(jsonHuda1, options);
            Console.WriteLine($"Judul {filmHuda?.title} \nDirektor : {filmHuda?.director}  \nYear : {filmHuda?.year} \nGenre : {filmHuda?.genre} \nRating : {filmHuda?.rating} \nduration : {filmHuda?.durationMinutes} isWatched? : {filmHuda?.isWatched}");

            Console.WriteLine("\n=== DaftarFilmFavorite ===");
            string jsonHuda2 = File.ReadAllText("jurnal7_2_103022400131.json");
            var watchListHuda = JsonSerializer.Deserialize<WatchList_103022400131>(jsonHuda2, options);
            Console.WriteLine($"Watchlist name: {watchListHuda?.watchlistName} ");
            Console.WriteLine($"Created By: {watchListHuda?.createdBy} ");
            Console.WriteLine("Watchlist:");
            if (watchListHuda?.movies != null)
            {
                for (int i = 0; i < watchListHuda.movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {watchListHuda.movies[i].id} {watchListHuda.movies[i].title} ( {watchListHuda.movies[i].year} - {watchListHuda.movies[i].rating} )");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error pada data Huda: {ex.Message}");
        }
    }
    public static void ReadJSON_103022400131()
    {
      try
      {
            Console.WriteLine("\n=== Film Favorit Dewo ===");
            string jsondwo1 = File.ReadAllText("jurnal7_1_103022400129.json");
            var favdwo = JsonSerializer.Deserialize<FilmFavorit_103022400129>(jsondwo1, options);
            Console.WriteLine($"Judul Film {favdwo?.title} ");
            Console.WriteLine($"Direktur Film {favdwo?.director} ");
            Console.WriteLine($"Tahun Film {favdwo?.year} ");
            Console.WriteLine($"Genre Film {favdwo?.genre} ");
            Console.WriteLine($"Rating Film {favdwo?.rating} ");
            Console.WriteLine($"Durasi Film {favdwo?.durationMinutes} ");
            Console.WriteLine($"Apakah Film ini sudah ditonton {favdwo?.isWatched} ");
            Console.WriteLine("==========================================================");

            string jsondwo2 = File.ReadAllText("jurnal7_2_103022400129.json");
            var watchList = JsonSerializer.Deserialize<WatchList_103022400129>(jsondwo2, options);
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
            Console.WriteLine($"Error pada data Dewo: {ex.Message}");
        }
    }
    public static void Main()
    {
      ReadJSON_103022400129();
      ReadJSON_103022400131();
    }
}
