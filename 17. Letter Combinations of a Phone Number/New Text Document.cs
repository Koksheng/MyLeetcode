public IList<string> LetterCombinations(string digits)
{
    List<string> result = new List<string>();


    if (digits == "")
        return result;

    var map = new Dictionary<char, string>
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tuv"},
                {'9', "wxyz"},
            };

    var list = new List<string>();

    foreach (char num in map[digits[0]])
    {
        list.Add(num.ToString());
    }
    if (digits.Length > 1)
    {
        for (int i = 1; i < digits.Length; i++)
        {
            var current = map[digits[i]];
            var temp = new List<string>();

            foreach (char c in current)
            {
                foreach (var l in list)
                {
                    temp.Add(l + c);
                }
            }
            list = new List<string>();
            list.AddRange(temp);
        }
    }
    return list;
}