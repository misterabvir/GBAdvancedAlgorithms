using Lesson2.Sorters.Base;

namespace Lesson2.Sorters;

public class HeapSort : ISorter
{
    public int[] Sort(int[] array)
    {
        int length = array.Length;
        for (int index = length / 2; index >= 0; index--)
        {
            Heapify(array, length - 1, index);
        }
        for (int index = length - 1; index >= 0; index--)
        {
            array.Swap(index, 0);
            Heapify(array, index - 1, 0);
        }
        return array;
    }

    private void Heapify(int[] array, int edge, int index)
    {
        int max = index;
        int left = 2 * index + 1;
        int right = 2 * index + 2;

        if (left <= edge && array[left] > array[max]) max = left;
        if (right <= edge && array[right] > array[max]) max = right;

        if (max != index)
        {
            array.Swap(index, max);
            Heapify(array, edge, max);
        }
    }
}
