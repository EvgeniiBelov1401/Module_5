namespace Exercise_5_2_14
{
    internal class Program
    {
        static int[] GetArrayFromConsole(int num=5)
        {
            var result = new int[num];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nПоказать массив");
            Console.ReadKey();
            foreach (int item in result)
            {
                Console.Write($"{item} ");
            }

            return result;
        }

        static int[] SortArray(int[] array)
        {
            var temp = 0;
            Console.WriteLine("\nОтсортировать массив");
            Console.ReadKey();
            for (int i = 0; i < array.Length; i++)
            {
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[i] > array[k])
                    {
                        temp = array[k];
                        array[k] = array[i];
                        array[i] = temp;
                    }
                }
            }
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
            return array;
        }
        static void Main(string[] args)
        {
            int[] Array = GetArrayFromConsole();
            SortArray(Array);
            Console.ReadKey();
        }
    }
}
