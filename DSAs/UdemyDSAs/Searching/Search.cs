namespace UdemyDSAs.Searching;

public static class Search
{
    public static int Binary(int[] source, int n, int key)
    {
        int left = 0;
        int right = source.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (key == source[mid]) return mid;
            if (key < source[mid]) right = mid - 1;
            else if (key > source[mid]) left = mid + 1;
        }

        return -1;
    }

    public static int RecursionBinary(int[] source, int key, int left, int right) //Just for demo purpose, don't use this stupid method
    {
        if (left > right) return -1;

        int mid = (left + right) / 2;
        if (key == source[mid]) return key;
        if (key < source[mid])
        {
            return RecursionBinary(source, key, left, mid - 1);
        }
        else if (key > source[mid])
        {
            return RecursionBinary(source, key, mid + 1, right);
        }

        return -1;
    }
}