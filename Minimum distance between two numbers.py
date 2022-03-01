
#Look at Minimum distance between two numbers.java file for instructions
class Solution:
    def minDist(self, arr, n, x, y):
        llist = [];
        xList = [];
        yList = [];
        for i in range(len(arr)):
            if arr[i]==x:
                xList.append(i);
            if arr[i]==y:
                yList.append(i);
        if len(xList)==0 or len(yList)==0:
            return -1;
        for i in range(len(xList)):
            for j in range(len(yList)):
                if xList[i] > yList[j]:
                    llist.append(xList[i]-yList[j]);
                elif yList[j] > xList[i]:
                    llist.append(yList[j]-xList[i]);
        return min(llist);
#{ 
#  Driver Code Starts
#Initial Template for Python 3


if __name__=='__main__':
    t = int(input())
    for i in range(t):
        n = int(input())
        arr = list(map(int, input().strip().split()))
        x,y = list(map(int, input().strip().split()))
        print(Solution().minDist(arr, n, x, y))



# } Driver Code Ends
