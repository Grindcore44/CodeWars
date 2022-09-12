using System;


public static class Program
{
    public static void Main()
    {
        IsIsogram("Dermatoglyphics");

    }

    public static bool IsIsogram(string str)
    {
        if (str == null)
        {
            return true;
        }
        str = str.ToLower();

        for (int i = 0; i < str.Length; i++)
        {
            for (int b = i+1; b < str.Length; b++)
            {
                if (str[i] == str[b])
                { 
                    return false;
                }
            
            }
        }
        return true;
    }
}