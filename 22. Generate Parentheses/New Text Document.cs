public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        if (n == 0)
        {
            return result;
        }
        GenerateParenthesis(n, n, 0, new char[2 * n], result);

        return result;
    }
    private void GenerateParenthesis(int open, int closed, int idk, char[] current, List<string> result)
    {
        if (closed == 0)
        {
            result.Add(new string(current));
            return;
        }
        if (open == closed)
        {
            current[idk] = '(';
            GenerateParenthesis(open - 1, closed, idk + 1, current, result);
        }
        else if (open < closed)
        {
            if (open > 0)
            {
                current[idk] = '(';
                GenerateParenthesis(open - 1, closed, idk + 1, current, result);
            }
            current[idk] = ')';
            GenerateParenthesis(open, closed - 1, idk + 1, current, result);
        }
    }
}