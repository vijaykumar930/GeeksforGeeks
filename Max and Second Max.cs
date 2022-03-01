// { Driver Code Starts
/*Given an array arr[] of size N of positive integers which may have duplicates. The task is to find the maximum and second maximum from the array, and both of them should be distinct, so If no second max exists, then the second max will be -1.

Example 1:

Input:
N = 3
arr[] = {2,1,2}
Output: 2 1
Explanation: From the given array 
elements, 2 is the largest and 1 
is the second largest.
Example 2:

Input:
N = 5
arr[] = {1,2,3,4,5}
Output: 5 4
Explanation: From the given array 
elements, 5 is the largest and 4 
is the second largest.

Your Task:
The task is to complete the function largestAndSecondLargest(), which should return maximum and second maximum element from the array with first element as maximum element and second element as second maximum(if there is no second maximum the  second element should be -1)

Expected Time Complexity: O(N).
Expected Auxiliary Space: O(1).*/


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

