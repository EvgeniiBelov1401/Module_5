namespace Exercise_5_5_3
{
    internal class Program
    {
        static void Echo(string str, int deep)
        {
            var modif = str;

            if (modif.Length > 0)
            {
                modif = modif.Remove(0, 2);
                Console.WriteLine("..." + modif);
            }

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Напишите что нибудь: ");
            string str = Console.ReadLine();
            Console.Write("Глубина эхо: ");
            int deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
        }
    }
}
