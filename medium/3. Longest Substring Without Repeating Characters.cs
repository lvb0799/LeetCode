public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length==0)
            return 0;
        else if(s.Length==1)
            return 1;
        else
        {
            int maxLength=1;
            for(int i=0;i<s.Length;i++)
            {
                for(int j=i+1;j<s.Length;j++)
                {
                    if(s[i]==s[j])
                    {
                        if(j-i>maxLength)
                        {
                            maxLength=j-i;
                        }
                        break;
                    }
                }
            }
            return maxLength;
        }
    }
}