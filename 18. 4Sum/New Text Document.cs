public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        var res = new List<IList<int>>();

        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }
            for (int j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1])
                {
                    continue;
                }
                int lo = j + 1;
                int hi = nums.Length - 1;
                int twoSum = target - nums[i] - nums[j];

                while (lo < hi)
                {
                    if (nums[lo] + nums[hi] == twoSum)
                    {
                        res.Add(new List<int>() { nums[i], nums[j], nums[lo++], nums[hi--] });
                        while (lo < hi && nums[lo] == nums[lo - 1])
                        {
                            lo++;
                        }
                        while (lo < hi && nums[hi] == nums[hi + 1])
                        {
                            hi--;
                        }
                    }
                    else if (nums[lo] + nums[hi] < twoSum)
                    {
                        lo++;
                    }
                    else
                    {
                        hi--;
                    }
                }
            }

        }

        return res;
    }
}