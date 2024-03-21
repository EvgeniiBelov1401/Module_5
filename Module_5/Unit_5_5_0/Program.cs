namespace Unit_5_5_0
{
    internal class Program
    {
        static void Echo(string str, int deep)
        {
            Console.WriteLine(str);

            if (deep > 1)
            {
                Echo(str, deep-1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Напишите что нибудь: ");
            string str=Console.ReadLine();
            Console.Write("Глубина эхо: ");
            int deep = int.Parse(Console.ReadLine());
            
            Echo(str, deep);
        }
    }
}
