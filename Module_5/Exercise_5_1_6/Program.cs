namespace Exercise_5_1_6
{
    internal class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            var temp = 0;
            for (int i = 0;i<result.Length;i++)
            {
                Console.Write($"Введите число {i+1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nПоказать массив");
            Console.ReadKey();
            foreach (int item in result)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nОтсортировать массив");
            Console.ReadKey();
            for (int i=0;i<result.Length;i++)
            {
                for (int k=i+1;k<result.Length;k++)
                {
                    if (result[i] > result[k])
                    {
                        temp = result[k];
                        result[k] = result[i];
                        result[i] = temp;
                    }
                }
            }
            foreach (int item in result)
            {
                Console.Write($"{item} ");
            }
            return result;
        }
        static void Main(string[] args)
        {
            GetArrayFromConsole();
            Console.ReadKey();
        }
    }
}
