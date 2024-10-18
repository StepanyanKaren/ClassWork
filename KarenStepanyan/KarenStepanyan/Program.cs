using System;

/*class MergeSort
{
    public static void MergeSortRecursive(int[] array)
    {
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];
        Array.Copy(array, 0, left, 0, mid);
        Array.Copy(array, mid, right, 0, array.Length - mid);
        MergeSortRecursive(left);
        MergeSortRecursive(right);
        Merge(array, left, right);
    }

    private static void Merge(int[] array, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                array[k] = left[i];
                i++;
            }
            else
            {
                array[k] = right[j];
                j++;
            }
            k++;
        }

        while (i < left.Length)
        {
            array[k] = left[i];
            i++;
            k++;
        }

        while (j < right.Length)
        {
            array[k] = right[j];
            j++;
            k++;
        }
    }

    public static void Main(string[] args)
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };

        Console.WriteLine(" arr " + string.Join(", ", array));

        MergeSortRecursive(array);

        Console.WriteLine(" sort " + string.Join(", ", array));
    }
}
*/

// QuickSort

/*

class QuickSort
{
    public static void QuickSortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Partition the array and get the pivot index
            int pivotIndex = Partition(array, low, high);

            // Recursively sort elements before and after partition
            QuickSortRecursive(array, low, pivotIndex - 1);
            QuickSortRecursive(array, pivotIndex + 1, high);
        }
    }

    private static int Partition(int[] array, int low, int high)
    {
        // Choose the last element as the pivot
        int pivot = array[high];
        int i = low - 1;

        // Rearrange elements: those smaller than the pivot to the left, larger to the right
        for (int j = low; j < high; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        // Place the pivot element in the correct position
        Swap(array, i + 1, high);
        return i + 1;
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void Main(string[] args)
    {
        int[] array = { 5, 21, 3, 34, 93, 42, 14 };

        Console.WriteLine(" arr " + string.Join(", ", array));

        QuickSortRecursive(array, 0, array.Length - 1);

        Console.WriteLine(" sort: " + string.Join(", ", array));
    }
}

*/

// shell sort

/*


class ShellSort
{
    public static void ShellSortMethod(int[] array)
    {
        int n = array.Length;

        for (int gap = n / 2; gap > 0; gap /= 2)
        {
         
            for (int i = gap; i < n; i++)
            {
                int temp = array[i];
                int j;

                for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                }

                array[j] = temp;
            }
        }
    }

    public static void Main(string[] args)
    {
        int[] array = { 12, 34, 54, 2, 3 };

        Console.WriteLine(" arr " + string.Join(", ", array));

        ShellSortMethod(array);

        Console.WriteLine(" arr " + string.Join(", ", array));
    }
}


*/

//HeapSort



class HeapSort
{
    public static void HeapSortMeth(int[] array)
    {
        int n = array.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            Swap(array, 0, i);
            Heapify(array, i, 0);
        }
    }

    private static void Heapify(int[] array, int n, int i)
    {
        int largest = i;  
        int left = 2 * i + 1;  
        int right = 2 * i + 2; 

        if (left < n && array[left] > array[largest])
        {
            largest = left;
        }

        if (right < n && array[right] > array[largest])
        {
            largest = right;
        }

        if (largest != i)
        {
            Swap(array, i, largest);
            Heapify(array, n, largest);
        }
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    public static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };

        Console.WriteLine("arr " + string.Join(", ", array));

        HeapSortMeth(array);

        Console.WriteLine(" sort " + string.Join(", ", array));
    }
}
