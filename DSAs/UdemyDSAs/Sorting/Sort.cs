namespace UdemyDSAs.Sorting;

public static class Sort
{
    #region Selection sort

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

    #endregion

    #region MyRegion

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

    #endregion

    #region Bubble sort

    public static int[] Bubble(int[] source)
    {
        for (int i = 0; i < source.Length - 1; i++)
        {
            for (int j = 0; j < source.Length - 1 - i; j++)
            {
                if (source[j] > source[j + 1])
                {
                    (source[j], source[j + 1]) = (source[j + 1], source[j]);
                }
            }
        }

        return source;
    }

    #endregion

    #region Shell sort

    public static int[] Shell(int[] source)
    {
        var gap = source.Length / 2;
        while (gap > 0)
        {
            for (int i = 0; i < source.Length - gap; i++)
            {
                if (source[i] > source[gap + i])
                {
                    (source[i], source[gap + i]) = (source[gap + i], source[i]);
                    var currentIndex = i;
                    while (currentIndex - 1 >= 0)
                    {
                        if (source[currentIndex] < source[currentIndex - 1])
                        {
                            (source[currentIndex], source[currentIndex - 1]) = (source[currentIndex - 1], source[currentIndex]);
                        }

                        --currentIndex;
                    }
                }
            }

            gap /= 2;
        }

        return source;
    }

    #endregion

    #region Merge sort

    public static int[] Merge(int[] source, int left, int right)
    {
        if (left < right)
        {
            var mid = (left + right) / 2; //left = mid = 5, right = 6
            Merge(source, left, mid); //merge(source, 5, 5)
            Merge(source, mid + 1, right); //merge(source, 6,6))
            MergeSubsets(source, left, mid, right); //(source, 5,5,6)
        }

        return source;
    }

    private static void MergeSubsets(int[] source, int left, int mid, int right)
    {
        int leftSubsetItemIdx = left; //0, mid = 0
        int rightSubsetItemIdx = mid + 1; //1
        int[] sortedSource = new int[source.Length];
        int sortedSourceIdx = left;

        if (left == mid) //in case each subset has only 1 element, just need 1 time swapping
        {
            if (source[leftSubsetItemIdx] > source[rightSubsetItemIdx])
            {
                (source[leftSubsetItemIdx], source[rightSubsetItemIdx]) = (source[rightSubsetItemIdx], source[leftSubsetItemIdx]);
            }

            return;
        }

        while (leftSubsetItemIdx <= mid && rightSubsetItemIdx <= right)
        {
            if (source[leftSubsetItemIdx] > source[rightSubsetItemIdx])
            {
                sortedSource[sortedSourceIdx] = source[rightSubsetItemIdx];
                rightSubsetItemIdx++;
                sortedSourceIdx++;
            }

            else
            {
                sortedSource[sortedSourceIdx] = source[leftSubsetItemIdx];
                leftSubsetItemIdx++;
                sortedSourceIdx++;
            }

            if (rightSubsetItemIdx > right) //case reach the end of right subset
            {
                while (leftSubsetItemIdx <= mid)
                {
                    sortedSource[sortedSourceIdx] = source[leftSubsetItemIdx];
                    sortedSourceIdx++;
                    leftSubsetItemIdx++;
                }

                break;
            }

            if (leftSubsetItemIdx > mid) //case reach the end of left subset
            {
                while (rightSubsetItemIdx <= right)
                {
                    sortedSource[sortedSourceIdx] = source[rightSubsetItemIdx];
                    sortedSourceIdx++;
                    rightSubsetItemIdx++;
                }

                break;
            }
        }

        for (int i = left; i <= right; i++)
        {
            source[i] = sortedSource[i];
        }
    }

    #endregion

    #region Quick sort

    public static int[] Quick(int[] source, int low, int high)
    {
        var pivot = low;
        var initialHigh = high;
        
        if (low == high || source.Length <= 1) return source;
        
        //Find the partition (the right var)
        while (low <= high)
        {
            if (source[low] > source[high])
            {
                (source[low], source[high]) = (source[high], source[low]);
            }

            if (source[low] <= source[pivot])
            {
                ++low;
            }

            if (source[high] >= source[pivot])
            {
                --high;
            }
        }

        //Swap pivot with the partitioned position
        (source[high], source[pivot]) = (source[pivot], source[high]);
        Quick(source, pivot, high);
        Quick(source, low, initialHigh);

        return source;
    }

    #endregion
}