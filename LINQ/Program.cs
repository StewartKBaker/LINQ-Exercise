namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Fallout New Vegas", "Warframe", "Prey", "Dark Souls 3", "Elden Ring", "Overwatch"};

            var orderedVideoGames = videoGames.OrderBy(name => name.Length);
            var i = 0;
            foreach (var game in orderedVideoGames)
            {
                i++;
                Console.WriteLine($"{i}. {game}");
            }
        }
    }
}
