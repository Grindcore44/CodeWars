public static class Program
{
    public static void Main()
    {
        ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 });

    }
    public static int[] ArrayDiff(int[] a, int[] b) //HashSet - решить с ним
    {
        List<int> list = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            list.Add(a[i]);
        }

        for (int i = 0; i < b.Length; i++)
        {
            while (list.Remove(b[i]))
            {   }
        }
        return list.ToArray();
    }
}