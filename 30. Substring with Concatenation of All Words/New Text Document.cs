public static void Main(string[] args)
{
    Program p = new Program();
    string[] words = { "word", "good", "best", "good" };
    IList<int> result = p.FindSubstring("wordgoodgoodgoodbestword", words);
}


public IList<int> FindSubstring(string s, string[] words)
{
    int wordLength = words[0].Length;
    List<int> result = new List<int>();
    if (s.Length == 0)
    {
        return result;
    }
    for (int i = 0; i <= s.Length - words.Count() * wordLength; i++)
    {
        if (HasSequence(s, i, wordLength, words.ToList()))
        {
            result.Add(i);
        }
    }

    return result;
}

private bool HasSequence(string s, int index, int wordLength, List<string> words)
{
    while (words.Count > 0)
    {

        string word = s.Substring(index, wordLength);
        if (!words.Remove(word))
        {
            return false;
        }
        index += wordLength;
    }

    return true;
}