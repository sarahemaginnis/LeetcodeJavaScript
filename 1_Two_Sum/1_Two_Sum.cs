//Leetcode Link: https://leetcode.com/problems/two-sum/
//C# Solution

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i<nums.Length; i++)
        {
            var startNum = nums[i];
            for(int j=i+1; j<nums.Length; j++)
            {
                if(startNum + nums[j] == target)
                {
                    return new int[2]{i, j}; 
                }
            }
        }
        return new int[1]{nums[0]};
    }
}