#User function Template for python3

'''
arr: List of integers denoting the input array
n  : size of the given array

You need to return the sorted binary array

Given a binary array A[] of size N. The task is to arrange the array in increasing order.

Note: The binary array contains only 0  and 1.

Example 1:

Input:
N = 5
A[] = {1,0,1,1,0}
Output: 0 0 1 1 1
Example 2:

Input:
N = 10
A[] = {1,0,1,1,1,1,1,0,0,0}
Output: 0 0 0 0 1 1 1 1 1 1
Your Task:
Complete the function SortBinaryArray() which takes given array as input and returns the sorted array. 

Expected Time Complexity: O(N).
Expected Auxiliary Space: O(1).
'''


class Solution:
    def sortBinaryArray (self, arr, n):
        # Your code here
        arr.sort();
        return arr;

#{ 
#  Driver Code Starts
#Initial Template for Python 3

#Initial Template for Python 3

import math

def main():
        T=int(input())
        while(T>0):
            
            n=int(input())
            
            arr=[int(x) for x in input().strip().split()]
            ob=Solution()
            res = ob.sortBinaryArray (arr, n)
            for i in range (n):
                print (res[i], end = " ")
            
            print ("")
            T-=1
            


if __name__ == "__main__":
    main()



# } Driver Code Ends
