public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int maxLength=0;
        for(int i=0;i<s.Length;i++)
        {
            bool hasRepeat=false;
            for(int j=i+1;j<s.Length;j++)
            {
                string compareStr=s.Substring(i,j-i);
                
                string compareChar=s[j].ToString();
                //Console.WriteLine(compareStr+"->"+compareChar);
                if(compareStr.Contains(compareChar))
                {
                    hasRepeat=true;
                    if(maxLength<compareStr.Length)
                        maxLength=compareStr.Length;
                    //Console.WriteLine(compareStr.Length);
                    break;
                }
            }  
            if(!hasRepeat && maxLength<s.Length-i)
            {
                maxLength=s.Length-i;
                //Console.WriteLine(s.Length+"->"+i);
            }
                
        }
        return maxLength==0? s.Length : maxLength;
    }
}