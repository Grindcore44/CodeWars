using System.Text;

public static class Program
{
    public static void Main()
    {
        NarcissisticOrNormal(153);


        // Math.Pow( что возводим , в какую степень)
    }
    public static bool NarcissisticOrNormal(int value)
    {
        int numberDischarge = 0;
        int remainder = 0;
        int mutableValue = value;
        int sum = 0;
        int longValue = (int)Math.Floor(Math.Log10(value)) + 1; // узнаем количество символов в числе
        for (int i = longValue; i > 0; i--)
        {
           remainder = mutableValue % (int)Math.Pow(10, i-1);
           numberDischarge = (mutableValue - remainder);
           mutableValue = mutableValue - numberDischarge;
           sum = sum + (int)Math.Pow(numberDischarge/(int)Math.Pow(10, i - 1), longValue);
          
        }
        return sum == value;
    }
}