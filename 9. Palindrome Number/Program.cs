public static bool Palindrome(int x)
{
    int temp = 0;
    int n = x;
    while (n > 0)
    {
        temp = temp * 10 + n % 10;
        n = n / 10;
    }
    if (temp == x)
    {
        return true;
    }
    return false;
}