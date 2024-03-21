namespace Exercise_5_3_3
{
    internal class Program
    {
        static void GetName(ref string name)
        {
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            var someName = "Jack";
            Console.WriteLine(someName);

            GetName(ref someName);

            Console.WriteLine(someName);
            Console.ReadKey();
        }

    }
}
