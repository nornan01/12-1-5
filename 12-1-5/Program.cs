namespace _12_1_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Hello, what is your name?");
            user.Name = Console.ReadLine();
            Console.WriteLine("Enter your login:");
            user.Login = Console.ReadLine();
            Console.WriteLine("Are you a premium user? (yes/no)");
            string answer = Console.ReadLine()?.Trim().ToLower();
            if (answer == "yes")
            {
                user.IsPremium = true;
            }
            else
            {
                user.IsPremium = false;
            }
            Console.WriteLine($"Welcome, {user.Name}!");
            if (!user.IsPremium)
            {
                ShowAds();
            }

        }
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }


    }
    
    }
