using System;
public static class Program
{
    public static void Main()
    {
        var kata = new Kata();
        kata.Score(new int[] { 2, 4, 4, 5, 4 });
    }

}

public class Kata
{
    public int Score(int[] dice)
    {
        int sum = 0;
        int countOne = 0;
        int countTwo = 0;
        int countThree = 0;
        int countFour = 0;
        int countFive = 0;
        int countSix = 0;

        for (int i = 0; i < dice.Length; i++)
        {
            if (dice[i] == 1)
            {
                countOne += 1;
            }
            else if (dice[i] == 2)
            { 
                countTwo += 1;
            }
            else if (dice[i] == 3)
            {
                countThree += 1;
            }
            else if (dice[i] == 4)
            {
                countFour += 1;
            }
            else if (dice[i] == 5)
            {
                countFive += 1;
            }
            else if (dice[i] == 6)
            {
                countSix += 1;
            }
        }

        if (countTwo >= 3)
        {
            sum += 200;
        }
        if (countThree >= 3)
        {
            sum += 300;
        }
        if (countFour >= 3)
        {
            sum += 400;
        }
        if (countSix >= 3)
        {
            sum += 600;
        }
        if (countOne >= 1)
        {
            int temp = countOne * 100;
            sum += temp;
            if (temp >= 300)
            {
                sum = sum + 1000 - 300;
            }
        }

        if (countFive >= 1)
        {
            int temp = countFive * 50;
            sum += temp;
            if (temp >= 150)
            {
                sum = sum + 500 - 150;
            }
        }

        return sum;
    }
}