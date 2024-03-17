using System.Drawing;

namespace Exercise_5_1_5
{
    internal class Program
    {
        
        static string ShowColor()
        {
            var color = Console.ReadLine();
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your color is white!");
                    break;
            }
            return color;
        }
        static void Main(string[] args)
        {
            var favcolors = new string[3];

            Console.WriteLine("Ваши 3 любимых цвета (англ): ");
            for (int i=0;i<favcolors.Length;i++)
            {
                favcolors[i]=ShowColor();
            }
            Console.WriteLine("Ваши любимые цвета: ");
            foreach (var fav in favcolors)
            {
                Console.WriteLine(fav);
            }

           
        }
    }
}
