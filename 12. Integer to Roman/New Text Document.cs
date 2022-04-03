Dictionary<int, string> map = new Dictionary<int, string>();

public string IntToRoman(int num)
{
    FillHashTable();

    StringBuilder sb = new StringBuilder();
    var keys = map.Keys.ToArray();
    int key = 0;
    int i = 0;
    while (num > 0)
    {
        key = keys[i];
        if (num >= key)
        {
            sb.Append(map[key]);
            num -= key;
        }
        else
        {
            i++;
        }
    }

    return sb.ToString();
}

private void FillHashTable()
{
    map.Add(1000, "M");
    map.Add(900, "CM");
    map.Add(500, "D");
    map.Add(400, "CD");
    map.Add(100, "C");
    map.Add(90, "XC");
    map.Add(50, "L");
    map.Add(40, "XL");
    map.Add(10, "X");
    map.Add(9, "IX");
    map.Add(5, "V");
    map.Add(4, "IV");
    map.Add(1, "I");

}