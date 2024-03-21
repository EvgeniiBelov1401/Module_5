namespace Exercise_5_3_0
{
    internal class Program
    {
        static void GetName(string name)
        {
            Console.Write("Введите имя: ");
            name =Console.ReadLine();
        }
        static void Main(string[] args)
        {
            var someName = "Jack";
            Console.WriteLine(someName);

            GetName(someName);

            Console.WriteLine(someName);
            Console.ReadKey();
        }
    }
}
