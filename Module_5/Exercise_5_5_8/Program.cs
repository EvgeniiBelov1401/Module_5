namespace Exercise_5_5_8
{
    internal class Program
    {
        static int PowerUp(int N,byte pow)
        {
           
            if(pow==0) return 1;
            else if(pow==1) return N;
            else
            {
                return N * (PowerUp(N, --pow));
                
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int N=int.Parse(Console.ReadLine());
            Console.Write("Введите степень: ");
            byte pow = byte.Parse(Console.ReadLine());

            Console.Write($"Ответ: {PowerUp(N,pow)}");

            Console.ReadKey();
        }
    }
}
