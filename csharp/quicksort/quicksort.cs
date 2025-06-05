namespace csharp.quicksort;

public class quicksort
{

    public static void Quicksort(int[] numbers, int start, int end)
    {
        if (end <= start) return; // base case
        int pivot = Partition(numbers, start, end);
        Quicksort(numbers, start,pivot - 1 );
        Quicksort(numbers,pivot + 1 , end);
    }

    public static int Partition(int[] numbers, int start, int end)
    {
        int pivot = numbers[end];
        int i = start - 1;

        for (int j = start; j <= end - 1; j++)
        {
            if (numbers[j] < pivot)
            {
                i++;
                int temp1 = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp1;
            }
        }
        i++;
        int temp2 = numbers[i];
        numbers[i] = numbers[end];
        numbers[end] = temp2;
        return i;
    }

}