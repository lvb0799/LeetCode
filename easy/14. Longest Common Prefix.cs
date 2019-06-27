public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }
        else if (strs.Length == 1)
        {
            return strs[0];
        }
        else
        {
            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length)
                    {
                        return i == 0 ? "" : strs[0].Substring(0, i);
                    }
                    else if (strs[0][i] != strs[j][i])
                    {
                        return i == 0 ? "" : strs[0].Substring(0, i);
                    }
                }
            }
            return strs[0];
        }
    }
}