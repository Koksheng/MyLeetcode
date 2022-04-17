public static void Main(string[] args)
{
    Program p = new Program();
    int dividend = -2147483648;
    int divisor = -2;
    int resp = p.Divide(dividend, divisor);
}

public int Divide(int dividend, int divisor)
{
    int sign = Math.Sign(dividend) * Math.Sign(divisor);
    long dividendLong = Math.Abs((long)dividend);
    long divisorLong = Math.Abs((long)divisor);

    if (divisorLong == 1)
    {
        if ((sign * dividendLong) > int.MaxValue)
            return int.MaxValue;
        return (int)(sign * dividendLong);
    }
    int quotient = 0;
    while (dividendLong >= divisorLong)
    {
        long currentDivisor = divisorLong;
        int multiplier = 1;
        while (currentDivisor << 1 <= dividendLong)
        {
            currentDivisor <<= 1;
            multiplier <<= 1;
        }
        dividendLong -= currentDivisor;
        quotient += multiplier;
    }
    return sign * quotient;

}