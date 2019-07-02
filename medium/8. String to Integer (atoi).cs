public class Solution
{
    public int MyAtoi(string str)
    {
        str = str.TrimStart();
        if (str == string.Empty)
            return 0;
        string searchStr = string.Empty;
        if (str[0] == '-' || str[0] == '+')
            searchStr = str.Substring(1, str.Length - 1);
        else
            searchStr = str;
        if (searchStr.Length != 0 && searchStr[0] >= '0' && searchStr[0] <= '9')
        {
            string getNumStr = getFirstNumStr(searchStr);
            if (getNumStr == string.Empty)
                return 0;
            int parsenum = 0;
            if (str[0] == '-')
                return int.TryParse(str[0] + getNumStr, out parsenum) ? parsenum : -2147483648;
            return int.TryParse(getNumStr, out parsenum) ? parsenum : 2147483647;

        }
        else
        {
            return 0;
        }

    }
    public string getFirstNumStr(string str)
    {
        string result = string.Empty;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= '0' && str[i] <= '9')
                result += str[i];
            else
                return result;
        }
        return result;
    }
}