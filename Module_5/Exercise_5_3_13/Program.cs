namespace Exercise_5_3_13
{
    internal class Program
    {
        static int[] SortArrayAsc(int[]arr)
        {
            int temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for (int k=i+1;k<arr.Length;k++)
                {
                    if (arr[i] > arr[k])
                    {
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            return arr;
        }
        static int[] SortArrayDesc(int[]arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] < arr[k])
                    {
                        temp = arr[i];
                        arr[i] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
            return arr;
        }

        static void SortArray(in int[]arr,out int[]sortarrayask, out int[] sortarraydesk)
        {
            sortarrayask=SortArrayAsc(arr);
            sortarraydesk=SortArrayDesc(arr);
            Console.WriteLine("По возрастанию:");
            ShowMassive(in sortarrayask);
            Console.WriteLine("По убыванию:");
            ShowMassive(in sortarraydesk);
        }

        static void ShowMassive(in int[] arr)
        {
            foreach(var item in arr)
            {
                Console.Write($"{arr} ");
            }
        }
        static void Main(string[] args)
        {
            var array = new[] {24,6,8,0,-7,59,0,-99,24,56,95,-34};
            Console.WriteLine("Неотсортированный массив:");
            ShowMassive(in array);
            SortArray(array,out array,out array);
        }
    }
}
