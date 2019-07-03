public class Solution
{
    public string IntToRoman(int num)
    {
        if (num >= 1000)
            return 'M' + IntToRoman(num - 1000);
        else if (num >= 500)
            return (num >= 900) ? "CM" + IntToRoman(num - 900) : 'D' + IntToRoman(num - 500);
        else if (num >= 100)
            return (num >= 400) ? "CD" + IntToRoman(num - 400) : 'C' + IntToRoman(num - 100);
        else if (num >= 50)
            return (num >= 90) ? "XC" + IntToRoman(num - 90) : 'L' + IntToRoman(num - 50);
        else if (num >= 10)
            return (num >= 40) ? "XL" + IntToRoman(num - 40) : 'X' + IntToRoman(num - 10);
        else if (num >= 5)
            return (num == 9) ? "IX" + IntToRoman(num - 9) : 'V' + IntToRoman(num - 5);
        else if (num >= 1)
            return (num == 4) ? "IV" + IntToRoman(num - 4) : 'I' + IntToRoman(num - 1);
        else
            return "";
    }

}