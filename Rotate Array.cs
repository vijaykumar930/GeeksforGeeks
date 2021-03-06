// { Driver Code Starts
//Initial Template for C#
/* Given an unsorted array arr[] of size N. Rotate the array to the left (counter-clockwise direction) by D steps, where D is a positive integer. 

 

Example 1:

Input:
N = 5, D = 2
arr[] = {1,2,3,4,5}
Output: 3 4 5 1 2
Explanation: 1 2 3 4 5  when rotated
by 2 elements, it becomes 3 4 5 1 2.
Example 2:

Input:
N = 10, D = 3
arr[] = {2,4,6,8,10,12,14,16,18,20}
Output: 8 10 12 14 16 18 20 2 4 6
Explanation: 2 4 6 8 10 12 14 16 18 20 
when rotated by 3 elements, it becomes 
8 10 12 14 16 18 20 2 4 6.
 

Your Task:
Complete the function rotateArr() which takes the array, D and N as input parameters and rotates the array by D elements. The array must be modified in-place without using extra space. 

 

Expected Time Complexity: O(N)
Expected Auxiliary Space: O(1)*/

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
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                int[] arr1 = Array.ConvertAll(elements.Split(), int.Parse);
                int sizeOfArray = arr1[0];// Input for size of array
                int d = arr1[1];
                int[] arr = new int[sizeOfArray];

                elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr1 = Array.ConvertAll(elements.Split(), int.Parse);// input for array elements
                for (int i = 0; i < sizeOfArray; i++)
                {
                    arr[i] = arr1[i];
                }

                Solution obj = new Solution();
                obj.rotateArr(arr, sizeOfArray, d);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }

    
 // } Driver Code Ends
//User function Template for C#

    class Solution
    {
        //Complete this function
        public void rotateArr(int[] arr, int n, int d)
        {
            //Your code here
            int[] temp = new int[d];
            int tempd=d;
            for(int i=0;i<d;i++)
            {
                temp[i] = arr[i];
            }
            /*Console.WriteLine("Temp array:");
            for(int i=0;i<d;i++)
            {
                Console.WriteLine(" " + temp[i]);
            }*/
            for(int i=d;i<n;i++)
            {
                arr[i-d] = arr[i];
            }
            /*Console.WriteLine("After Left shift:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(" " + arr[i]);
            }*/
            for(int i=0;i<d;i++)
            {
                arr[n-tempd]=temp[i];
                //Console.WriteLine("arr["+n+"-"+tempd+"] = " + arr[n-tempd]);
                tempd--;
            }
            /*Console.WriteLine("After appending temp array:");
            for(int i=0;i<n;i++)
            {
                Console.WriteLine(" " + arr[i]);
            }*/
        }
    }

}

// { Driver Code Starts.  // } Driver Code Ends
