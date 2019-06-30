public class Solution
{
    public int Reverse(int x)
    {
        string xToStr = x.ToString();
        string tmpStr = x < 0 ? xToStr.Substring(1, xToStr.Length - 1) : xToStr;
        char[] resultCharList = tmpStr.ToCharArray();
        Array.Reverse(resultCharList);
        string resultnums = new string(resultCharList);
        int resultInt = 0;
        if (int.TryParse(resultnums, out resultInt))
            return x < 0 ? int.Parse("-" + resultnums) : int.Parse(resultnums);
        else
            return 0;
    }
}