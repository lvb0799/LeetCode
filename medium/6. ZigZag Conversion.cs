public class Solution {
    public string Convert(string s, int numRows) {
        if(numRows==1)
            return s;
        string result=string.Empty;
        string[] resultmap=new string[numRows];
        int finalRow=resultmap.Length-1;
        for(int i=0,sign=1,curRows=0;i<s.Length;i++)
        {
            if(curRows==0)
                sign=1;
            else if (curRows==finalRow)
                sign=-1;
            resultmap[curRows]+=s[i];
            curRows+=sign;
        }
        for(int i=0;i<numRows;i++)
        {
            result+=resultmap[i];
        }
        return result;
    }
}