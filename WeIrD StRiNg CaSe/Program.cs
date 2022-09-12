using System.Text;

public static class Program
{
    public static void Main()
    { 
        Console.WriteLine(ToWeirdCase("Ублюдок Мать твою говно собачье сволочь"));
    }

    public static string ToWeirdCase(string s)
    {
      string[] words = s.Split(' ');
        StringBuilder stringBuider = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            if (i != 0)
            {
                stringBuider.Append(' ');
            }
            for (int j = 0; j < words[i].Length; j++)
            {
                char temp = words[i][j];
                
                if (j % 2 == 0)
                {
                    stringBuider.Append(Char.ToUpper(temp));
                }
                else
                {
                    stringBuider.Append(Char.ToLower(temp));
                }
            
            }
        }

        return stringBuider.ToString();
       
    }
}