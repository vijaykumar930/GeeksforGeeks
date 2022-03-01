// { Driver Code Starts


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[N];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);

                Solution obj = new Solution();
                int[] res = obj.largestAndSecondLargest(arr, N);
                for(int i = 0;i<res.Length;i++){
                    Console.Write(res[i]+" ");
                }
                Console.Write("\n");
          }

        }
    }
}// } Driver Code Ends


//User function Template for C#

 class Solution
    {
        //Complete this function
        public int[] largestAndSecondLargest(int[] A,int N)
        {
            Array.Sort(A);
            Array.Reverse(A);
            int max = A.Max();
            int secondMax = A[1];
            for(int i =1; secondMax==max&&i<A.Length-1; i++)
            {
                secondMax = A[i];
            }
            if(secondMax==max)
            {
                secondMax=-1;
            }
            
            return new int[]{max, secondMax};
        }

    }

