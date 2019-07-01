public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length <= 1)
            return s;
        else
        {
            int maxLength = 0;
            int leftidx = 0;
            int rightidx = 0;
            int[] oven = new int[] { 0, 0 };
            int[] odd = new int[] { 0, 0 };
            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine("i=" + i +" ");
                odd = findPalindrome(s, i, i);
                oven = findPalindrome(s, i, i + 1);
                int lenOven = 0;
                int lenOdd = 0;
                lenOven = oven[1] - oven[0];
                lenOdd = odd[1] - odd[0];
                if (lenOven > lenOdd && lenOven > maxLength)
                {
                    maxLength = lenOven;
                    leftidx = oven[0];
                    rightidx = oven[1];
                }
                else if (lenOven <= lenOdd && lenOdd > maxLength)
                {
                    maxLength = lenOdd;
                    leftidx = odd[0];
                    rightidx = odd[1];
                }
            }
            //Console.WriteLine(leftidx+","+rightidx+"--result");
            return s.Substring(leftidx, rightidx - leftidx + 1);
        }

    }
    private int[] findPalindrome(string s, int left, int right)
    {
        int[] result = new int[2];
        result[0] = left;
        result[1] = right;
        while (result[0] >= 0 && result[1] < s.Length && s[result[0]] == s[result[1]])
        {
            result[0]--;
            result[1]++;
        }
        result[0]++;
        result[1]--;
        //Console.WriteLine(result[0]+", result"+result[1]);
        return result;
    }
}
