public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int result = 0;
        List<int> list = new List<int>();
        if (nums.Length == 0)
        {
            return result;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                list.Add(nums[i]);
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            nums[i] = list[i];
        }
        return list.Count();
    }
}