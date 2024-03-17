namespace Exercise_5_2_17
{
    internal class Program
    {
        static void ShowArray(int[]array, bool IsSort=false)
        {
            if (IsSort==true)
            {
                SortArray(array);
            }
            Console.WriteLine("\nПоказать массив:");
            Console.ReadLine();
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
           

            return result;
        }
        static int[] SortArray(int[] array)
        {
            var temp = 0; 
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
           
            return array;
        }
        static void Main(string[] args)
        {
            var array=GetArrayFromConsole();
            ShowArray(array,true);
        }
    }
}
