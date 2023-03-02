namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1= { 7, 8, 9, 5, };
            int[] numbers2 = { 7, 8, 9,5,2, 3, 1 };
            int count = 0;
            for(int i=0; i<numbers1.Length; i++)
            {
                for(int j=0; j<numbers2.Length; j++)
                    if (numbers1[i]== numbers2[j])
                    {
                        count++;
                        
                    }  
            }if (count == numbers1.Length)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}