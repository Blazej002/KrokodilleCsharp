namespace KrokodilleSpillet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play!");
            Console.WriteLine("__________");
            Console.WriteLine("1 < 2");
            Console.WriteLine("2 = 2");
            Console.WriteLine("3 > 2");
            Console.WriteLine("_________________");
            Console.WriteLine("To exit write 'e'");
            Console.WriteLine("_________________");
            Console.WriteLine("X _ Y");
            Console.WriteLine("Fill in the blank");
            Console.WriteLine("_________________");
            bool win = false;
            int points = 0;

            while (!win)
            {
                if (points == 10)
                {
                    win = true;
                }

                Random ran = new Random();
                var ran1 = ran.Next(1, 11);
                var ran2 = ran.Next(1, 11);

                Console.WriteLine($"{ran1} _ {ran2}");
                var userInp = Console.ReadLine();

                var result = checkIf(ran1, ran2, userInp);

                if (!result)
                {
                    Console.WriteLine("Wrong");
                    Console.WriteLine("__________");
                    continue;
                }

                points++;

                Console.WriteLine("");
                Console.WriteLine($"Points = {points}");
                Console.WriteLine("Correct!");
                Console.WriteLine("_____________");
            }

            static bool checkIf(int x, int y, string inp)
            {
                string what = whatIf(x, y);
                return what == inp;
            }

            static string whatIf(int x, int y)
            {
                if (x == y)
                {
                    return "=";
                }

                if (x < y)
                {
                    return "<";
                }

                if (x > y)
                {
                    return ">";
                }

                return "idk";
            }
        }
    }
}