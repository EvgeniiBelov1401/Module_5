namespace Exercise_5_3_13
{
    internal class Program
    {
        static int[] SortArrayAsc(in int[] arr1)
        {
            int temp = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int k = i + 1; k < arr1.Length; k++)
                {
                    if (arr1[i] > arr1[k])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[k];
                        arr1[k] = temp;
                    }
                }
            }
            return arr1;
        }
        static int[] SortArrayDesc(in int[] arr2)
        {
            int temp = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int k = i + 1; k < arr2.Length; k++)
                {
                    if (arr2[i] < arr2[k])
                    {
                        temp = arr2[i];
                        arr2[i] = arr2[k];
                        arr2[k] = temp;
                    }
                }
            }
            return arr2;
        }

        static void SortArray(in int[] arr, out int[] sortarrayask, out int[] sortarraydesk)
        {
            sortarrayask = SortArrayAsc(in arr);
            Console.WriteLine("По возрастанию:");
            ShowMassive(in sortarrayask);
            Console.WriteLine();
            sortarraydesk = SortArrayDesc(in arr);
            Console.WriteLine("По убыванию:");
            ShowMassive(in sortarraydesk);
            Console.WriteLine();

        }

        static void ShowMassive(in int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        static void Main(string[] args)
        {
            var array = new[] {24,6,8};
            Console.WriteLine("Неотсортированный массив:");
            ShowMassive(in array);
            Console.WriteLine();
            SortArray(in array,out array,out array);
        }
    }
}
