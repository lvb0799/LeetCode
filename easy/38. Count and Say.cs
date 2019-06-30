public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1)
            return "1";
        else
        {
            string recursiveString = CountAndSay(n - 1);
            char[] tmpchar = recursiveString.ToCharArray();
            Console.WriteLine(recursiveString);
            int count = 1;
            string result = string.Empty;
            for (int i = 0; i < tmpchar.Length; i++)
            {
                if (i == tmpchar.Length - 1)
                    result += count.ToString() + tmpchar[i];
                else if (tmpchar[i] != tmpchar[i + 1])
                {
                    result += count.ToString() + tmpchar[i];
                    count = 1;
                }
                else
                {
                    count++;
                }
            }
            return result;
        }
    }
}