using System;
using System.Collections.Generic;

namespace Question_1
{
  
    class Program
    {
        static int n;
        static int k;
        static int arrivalCounter;
        static List<string> result = new List<string>();



        static void Main(string[] args)
        {    
            Console.WriteLine("enter the number of test cases:");
            int t = Convert.ToInt32(Console.ReadLine());

            if (t >= 1 && t <= 10) //Applying first constraints 1 <= t <=10
            {

                for (int x = 0; x < t; x++)
                {
                    Console.WriteLine("enter the number of students followed by the threshold seperated by space:");
                    string[] first_line = Console.ReadLine().Split(' ');
                    n = Convert.ToInt32(first_line[0]);
                    k = Convert.ToInt32(first_line[1]);
                    if (n >= 1 && n <= 1000) // applying constraint 1 <=n <= 1000
                    {
                        if (k >= 1 && k <= n)
                        {
                            Console.WriteLine("Now Enter the arrival times of students sperated by space:");
                            string[] a_temp = Console.ReadLine().Split(' ');
                            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                            if (a.Length == n) //making sure the length of the input array equals the total number of students 
                            {                            
                                angryProfessor(k, a);
                            }
                                                     
                            else // if the length of a not equal to n
                            {
                                Console.WriteLine("Number of students must equal n");
                            }
                        }
                        else // if k value is invalid
                        {
                            Console.WriteLine("Invalid Threshold number. Enter a number betewen 1 and " + n); 
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number of Students should be between 1 and 1000");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number of test cases. Enter a value between 1 and 10");
            }

            Console.WriteLine("========================= Class is canceled ? ========================");
            foreach (string i in result)
            {
                Console.WriteLine(i);
            }
        }
       
    static void angryProfessor(int threshold, int[] studentArray)
        { 
            
               // if (a[i] < -100 && a[i] > 100)
                //{
                  //  
                //}

            for (int i = 0; i < n; i++)
            {
                if (studentArray[i] <= 0 && studentArray[i]>-100)
                {
                    arrivalCounter += 1;
                }

                else if (studentArray[i] >0 && studentArray[i] <= 100)
                {
                    arrivalCounter += 0;
                }
                else // if array elements -100 <= a[i] <=100
                {
                    Console.WriteLine("arrival time can't be less than -100 or more than 100");
                }
            }
            if (arrivalCounter <= k)
            {
   
                result.Add("Yes");
            }
            else
            {
                result.Add("No");
            }
        }
          

    }
}
        

