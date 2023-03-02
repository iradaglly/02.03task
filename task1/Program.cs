using System.Collections.Immutable;
using System.Globalization;
using System.Threading.Channels;
using System.Xml;

namespace task_02._03_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 4,7, 3, 8, 2 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("----------------------------------");
            int m = 0;
            for(int i=0; i<arr.Length-1;i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        m = arr[i];
                        arr[i] = arr[j];
                        arr[j] = m;
                    }
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}