Dictionary<char, int> map = new Dictionary<char, int>();


private void FillHashTable()
{
    map.Add('I', 1);
    //map.Add("IV", 4);
    map.Add('V', 5);
    //map.Add("IX", 9);
    map.Add('X', 10);
    //map.Add("XL", 40);
    map.Add('L', 50);
    //map.Add("XC", 90);
    map.Add('C', 100);
    //map.Add("CD", 400);
    map.Add('D', 500);
    //map.Add("CM", 900);
    map.Add('M', 1000);
}

public int RomanToInt(string s)
{
    FillHashTable();
    int result = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (i > 0 && map[s[i]] > map[s[i - 1]])
        {
            result += map[s[i]] - 2 * map[s[i - 1]];
        }
        else
        {
            result += map[s[i]];
        }
    }
    return result;
}