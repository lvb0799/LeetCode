public class Solution {
    public int RomanToInt(string s) {
        int pre=0;
            int result=0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int cur=-1;
                switch (s[i])
                {
                    case 'I':
                        cur=1;
                        break;
                    case 'V':
                        cur=5;
                        break;
                    case 'X':
                        cur=10;
                        break;
                    case 'L':
                        cur=50;
                        break;
                    case 'C':
                        cur=100;
                        break;
                    case 'D':
                        cur=500;
                        break;
                    case 'M':
                        cur=1000;
                        break;
                    default:
                        break;
                }
                if (pre <= cur)
                {
                    result+=cur;
                }
                else
                {
                    result-=cur;
                }
                pre=cur;
            }
        return result;
    }
}