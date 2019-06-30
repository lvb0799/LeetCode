public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        else if (x == 0)
            return true;
        else
        {
            string xToStr = x.ToString();
            int lenx = xToStr.Length;
            for (int i = 0; i < lenx / 2; i++)
            {
                if (xToStr[i] != xToStr[lenx - i - 1])
                    return false;
            }
            return true;
        }
    }
}