public static void Main(string[] args)
{
    Program p = new Program();
    string haystack = "mississippi";
    string needle = "issip";
    int resp = p.StrStr(haystack, needle);
}

public int StrStr(string haystack, string needle)
{
    int result = 0;

    if (haystack.Contains(needle))
    {
        result = haystack.IndexOf(needle);
    }
    else
    {
        result = -1;
    }

    return result;
}