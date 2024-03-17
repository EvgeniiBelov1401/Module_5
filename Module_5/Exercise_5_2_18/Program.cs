namespace Exercise_5_2_18
{
    internal class Program
    {
        static int[] GetMassiveFromConsole()
        {
            var massive = new int[10];
            for ( int i = 0; i < massive.Length; i++)
            {
                Console.Write($"Число {i+1}: ");
                massive[i] = int.Parse( Console.ReadLine());
            }
            return massive;
        }
        static void ShowSortedMassive(int[]array, bool IsSort=false)
        {
            if (IsSort)
            {
                var temp = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    for (int k = i + 1; k < array.Length; k++)
                    {
                        if (array[i] > array[k])
                        {
                            temp = array[i];
                            array[i] = array[k];
                            array[k] = temp;
                        }
                    }
                }
            }
            foreach(var item in array)
            {
                Console.Write($"{item} ");
            }
        }
        static void Main(string[] args)
        {
            var array = GetMassiveFromConsole();
            ShowSortedMassive(array,true);
        }
    }
}
