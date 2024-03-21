namespace Exercise_5_3_1
{
    internal class Program
    {
        static void ChangeAge(int age)
        {
            Console.Write("Введите Ваш возраст: ");
            age=Console.Read();
        }
        static void Main(string[] args)
        {
            var someAge = 25;
            Console.WriteLine(someAge);
            ChangeAge(someAge);
            Console.WriteLine(someAge);

            Console.ReadKey();
        }
    }
}
