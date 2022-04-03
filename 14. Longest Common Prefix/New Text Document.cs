public string LongestCommonPrefix(string[] strs)
{
    string output = "";

    if (strs.Length == 1)
    {
        return strs[0];
    }
    for (int i = 0; i <= strs[0].Length; i++)
    {
        string j = strs[0].Substring(0, i);
        bool result = strs.All(x => x.StartsWith(j));
        if (result)
        {
            output = j;
        }

    }
    return output;
}