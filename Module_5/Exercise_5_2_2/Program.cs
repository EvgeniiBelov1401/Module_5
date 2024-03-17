namespace Exercise_5_2_2
{
    internal class Program
    {
        static string ShowColor(string username,int userage)
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
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);


            var favcolors = new string[3];

            Console.WriteLine($"{anketa.name},{anketa.age} лет,\n Напишите свой любимый цвет: ");
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(anketa.name,anketa.age);
            }
            Console.WriteLine($"{anketa.name}, Ваши любимые цвета: ");
            foreach (var fav in favcolors)
            {
                Console.WriteLine(fav);
            }
            Console.ReadKey();
        }
    }
}
