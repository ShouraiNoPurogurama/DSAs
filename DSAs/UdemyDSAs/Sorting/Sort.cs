namespace UdemyDSAs.Sorting;

public static class Sort
{
    public static int[] Selection(int[] source)
    {
        for (int i = 0; i < source.Length; i++)
        {
            for (int j = i + 1; j < source.Length; j++)
            {
                if (source[i] > source[j])
                {
                    (source[i], source[j]) = (source[j], source[i]);
                }
            }
        }

        return source;
    }

    public static int[] Insertion(int[] source)
    {
        for (int i = 1; i < source.Length; i++)
        {
            int pre = i - 1;
            int curr = i;
            while (curr >= 1)
            {
                if (source[pre] > source[curr])
                {
                    (source[pre], source[curr]) = (source[curr], source[pre]);
                }
                --curr;
                --pre;
            }
        }

        return source;
    }
}