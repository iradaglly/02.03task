namespace task3_binary_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 4, 6, 7, 8, 9, 11 }; //sort olduguna gore sort etmirik
            int n = 8;
            int min = 0;
            int max = numbers.Length-1;
            int middle;
            while (min <= max)
            {
                middle = (min + max) / 2;
                if (numbers[middle] == n)
                {
                    Console.WriteLine(middle);
                    break;
                }
                else if (numbers[middle] > n)
                {
                    max = middle - 1;
                }
                else if (numbers[middle] < n)
                {
                    min = middle + 1;

                }
          
            }
        }
    }
}