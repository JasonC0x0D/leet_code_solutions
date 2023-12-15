// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
// The overall run time complexity should be O(log (m+n)).

//Example 1:
//Input: nums1 = [1,3], nums2 = [2]
//Output: 2.00000
//Explanation: merged array = [1,2,3] and median is 2.

//Example 2:
//Input: nums1 = [1,2], nums2 = [3,4]
//Output: 2.50000
//Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

var solution = new Solution();

int[] testNums1 = [1,2];
int[] testNums2 = [3,4];

var ans = solution.FindMedianSortedArrays(testNums1, testNums2);

Console.WriteLine(ans);

public class Solution {

    // This algorithm determines the median, which is the middle number or the average of two middle numbers.
    // By keeping track of indices for both sorted arrays, it compares the values at these
    // indices and increments the index corresponding to the smaller value. This process continues until
    // it identifies the middle number or the two closest numbers to the middle. It then returns or 
    // calculates the median.

    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int length1 = nums1.Length;
        int length2 = nums2.Length;

        // HACK: Needed if goes though one entire array to prevent trying to index past an array.
        nums1 = nums1.Append(int.MaxValue).ToArray();
        nums2 = nums2.Append(int.MaxValue).ToArray();

        double middle = (length1 + length2) / 2.0;
        bool inBetween = middle * 10 % 10 != 5; 

        if(!inBetween){
            int j = -1; // nums1 index
            int k = -1; // nums2 index
            bool jLastIncremented = false;

            for (int i = 0; i < (int)middle + 1; i++)
            {
                if(nums1[j+1] <= nums2[k+1]){
                    j++;
                    jLastIncremented = true;
                }

                else
                {
                    k++;
                    jLastIncremented = false;
                }
            }
            return jLastIncremented ? nums1[j] : nums2[k];
        }
        else{
            int numBeforeMiddle;
            int numAfterMiddle;

            int j = -1; // nums1 index
            int k = -1; // nums2 index
            bool jLastIncremented = false;

            for (int i = 0; i < (int)middle; i++)
            {
                if(nums1[j+1] <= nums2[k+1]){
                    j++;
                    jLastIncremented = true;
                }

                else
                {
                    k++;
                    jLastIncremented = false;
                }
            }
            numBeforeMiddle =  jLastIncremented ? nums1[j] : nums2[k];
            numAfterMiddle = nums1[j+1] <= nums2[k+1] ? nums1[j+1] : nums2[k+1];

            return (numBeforeMiddle + numAfterMiddle)/2.0;
        }
    }
}