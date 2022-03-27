public static int MaxArea(int[] arr)
{
    int p1 = 0;
    int p2 = arr.Length - 1;
    int maxArea = 0;
    while (p2 > p1)
    {
        int width = Math.Min(arr[p1], arr[p2]);
        int length = p2 - p1;
        int area = width * length;
        maxArea = Math.Max(maxArea, area);
        if (arr[p1] < arr[p2])
        {
            p1++;
        }
        else
            p2--;
    }
    return maxArea;
}