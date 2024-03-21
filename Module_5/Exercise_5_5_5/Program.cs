namespace Exercise_5_5_5
{
    internal class Program
    {
        static decimal Factorial(int x)
        {
            if (x == 0) 
                return 1;
            else
            {
                return x*Factorial(x-1);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите Факториал: ");
            int fact=int.Parse(Console.ReadLine());
            decimal result = Factorial(fact);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
