public static int ThreeSumClosest(int[] nums, int target)
{
    //var dict = new Dictionary<string, int>();
    Array.Sort(nums);
    //int result = 0;
    int j, k;
    int n = nums.Length;
    //int minDif = int.MaxValue;
    int closestSum = nums[0] + nums[1] + nums[n - 1];
    int threeSum = 0;
    for (int i = 0; i < nums.Length; ++i)
    {
        j = i + 1;
        k = nums.Length - 1;
        while (j < k)
        {
            string strThreeSum = string.Concat(nums[i], nums[j], nums[k]);
            threeSum = nums[i] + nums[j] + nums[k];
            if (threeSum == target)
            {
                return target;
            }
            else if (threeSum > target)
                --k; // verify if a triplet with a smaller sum can be found
            else
                ++j;

            //int dif = threeSum == 0 ? 0 : target - threeSum;
            //minDif = Math.Abs(dif)  < minDif ? Math.Abs(dif) : minDif;
            if (Math.Abs(target - threeSum) < Math.Abs(target - closestSum))
            {
                closestSum = threeSum;
            }

            //(j, k) = dif < 0 ? (j + 1, k) : (j, k - 1);

        }
    }
    //result = result == 0 ? closestSum : result;

    return closestSum;
}