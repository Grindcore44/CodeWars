using System.Text;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Rot13("F-------u      c____k"));
       Console.WriteLine(SummaHuyumba(3, 4));
    }

    public static string Rot13(string message)
    {
        char[] charArray = message.ToCharArray();
        StringBuilder stringBuider = new StringBuilder();

        for (int i = 0; i < charArray.Length; i++)
        {
            int charConvertedInt = Convert.ToInt32(charArray[i]);

            if ((charConvertedInt > 64 && charConvertedInt < 91) || (charConvertedInt > 96 && charConvertedInt < 123))
            {
                charConvertedInt += 13;

                if ((charConvertedInt >= 91 && charConvertedInt <= 103) || charConvertedInt > 122)
                {
                    charConvertedInt = charConvertedInt - 26;
                }
            }
            stringBuider.Append(Convert.ToChar(charConvertedInt));
        }

        return stringBuider.ToString();
    }

    public static int SummaHuyumba(int a, int b)
    {
        return a + b;
    
    }
}