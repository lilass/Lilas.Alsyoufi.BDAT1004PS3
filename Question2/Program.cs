using System;

namespace Question2
{
    class Program
    {
        
        static int n;
        static int m;

        static void Main(string[] args)
        {
            Console.WriteLine("two space-separated integers, the number of elements in array a and the number of elements in array b.");
            string[] arrayslength = Console.ReadLine().Split(' '); //create an array and assign it to the console input
            n = Convert.ToInt32(arrayslength[0]); //first element of the array is the n
            m = Convert.ToInt32(arrayslength[1]); //second element is the m 

            Console.WriteLine("Now Enter the element of the first array separated by space");
            string[] firstArrayInput = Console.ReadLine().Split(' ');
            int[] firstArray = Array.ConvertAll(firstArrayInput, Int32.Parse);

            Console.WriteLine("Now Enter the element of the second array separated by space");
            string[] secondArrayInput = Console.ReadLine().Split(' ');
            int[] secondArray = Array.ConvertAll(secondArrayInput, Int32.Parse);

            getTotalX(firstArray, secondArray);
        }


        static void getTotalX(int[] a, int[] b) 
        {
            for (int i = 0; i <b.Length; i++)
            {
                for (int x=0; x< a.Length; x++)
                {
                    if (b[i] % i+1 == 0 )
                }

            }
        }
    }
}
