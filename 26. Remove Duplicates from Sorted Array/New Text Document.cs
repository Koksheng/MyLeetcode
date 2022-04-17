public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int result = 0;
        List<int> list = new List<int>();
        int[] array = nums;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!list.Contains(nums[i]))
            {
                list.Add(nums[i]);
            }
        }
        for (int i = 0; i < list.Count; i++)
        {
            nums[i] = list[i];
        }

        result = list.Count;


        return result;
    }
}