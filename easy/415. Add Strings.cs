public class Solution
{
    public string AddStrings(string num1, string num2)
    {
        int over = 0;
        int i1 = num1.Length - 1;
        int i2 = num2.Length - 1;
        string result = string.Empty;
        while (i1 >= 0 || i2 >= 0)
        {
            int addsum = 0;
            if (i1 < 0)
            {
                addsum = int.Parse(num2[i2].ToString()) + over;
                i2--;
            }
            else if (i2 < 0)
            {
                addsum = int.Parse(num1[i1].ToString()) + over;
                i1--;
            }
            else
            {
                addsum = int.Parse(num1[i1].ToString()) + int.Parse(num2[i2].ToString()) + over;
                i1--;
                i2--;
            }
            if (addsum >= 10)
            {
                addsum %= 10;
                over = 1;
            }
            else
            {
                over = 0;
            }
            result = addsum.ToString() + result;
        }
        if (over == 1)
            result = over.ToString() + result;
        return result;
    }
}