namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>();

            videoGames.Add("Battlefield");
            videoGames.Add("Destiny");
            videoGames.Add("GTA");
            videoGames.Add("Halo");
            videoGames.Add("Mario");

            var videoGameLength = videoGames.OrderBy(x => x.Length);
            foreach (var videoGame in videoGameLength)
            {
                Console.WriteLine(videoGame);
            }
        }
    }
}
