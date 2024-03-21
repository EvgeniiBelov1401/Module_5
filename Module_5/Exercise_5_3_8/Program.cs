namespace Exercise_5_3_8
{
    internal class Program
    {
        static int GetArrayFromConsole(ref int num)
        {
            var result =new int[6];
            return result.Length;
        }
        static void Main(string[] args)
        {
            var arr = new int[4];
            var num=arr.Length;
            Console.WriteLine(arr.Length);
            GetArrayFromConsole(ref num);
            Console.WriteLine(num);
            

            Console.ReadKey();
        }
    }
}
