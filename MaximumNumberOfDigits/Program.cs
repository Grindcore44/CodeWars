public static class Kata
{

    public static void Main()
    {
        DescendingOrder(343423);


        // Math.Pow( что возводим , в какую степень)
    }
    public static int DescendingOrder(int num)
    {
        if (num == 0)
        { return num; }
        int numberDischarge = 0;
        int remainder = 0;
        int mutableValue = num;
        int longValue = (int)Math.Floor(Math.Log10(num)) + 1; // узнаем количество символов в числе
        int[] array = new int[longValue];
        for (int i = longValue, b = 0; i > 0 ; i--, b ++) 
        {
            remainder = mutableValue % (int)Math.Pow(10, i - 1); // получаем число со второй цифры
            numberDischarge = mutableValue - remainder; // получаем первую цифру цисла с нулями
            mutableValue = mutableValue - numberDischarge; // получаем число без первой цифры для дальнейшей работы с ним
            array[b] = numberDischarge/ (int)Math.Pow(10, i - 1); //записываем первую цифру в массив без нулей  
        }
        int temp;
        for (int i = 0; i < array.Length - 1; i++) // сортируем массив от большего к меньшему
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        int total = 0;
        for (int i = longValue, b = 0; i > 0; i--, b++) // восстанавливаем число из массива
        {
            temp = array[b] * (int)Math.Pow(10, i - 1);
            total = total + temp;
        }

        return total;
    }
}
