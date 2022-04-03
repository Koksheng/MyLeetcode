public IList<IList<int>> ThreeSum(int[] nums)
{
    var dict = new Dictionary<string, IList<int>>();

    Array.Sort(nums);
    int j, k;
    for (int i = 0; i < nums.Length - 2; i++)
    {
        j = i + 1;
        k = nums.Length - 1;
        while (j < k)
        {
            int[] tripleset = { nums[i], nums[j], nums[k] };
            string strTripleset = string.Concat(nums[i], nums[j], nums[k]);
            int sumTripleset = tripleset.Sum();
            if (sumTripleset == 0)
            {
                dict.TryAdd(strTripleset, tripleset);
            }
            (j, k) = sumTripleset < 0 ? (j + 1, k) : (j, k - 1);
        }
    }

    return dict.Values.ToList();
}