using Lesson2.Sorters.Base;

namespace Lesson2.Sorters;

public class InsertSort : ISorter
{
    public int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j > 0 && array[j] < array[j - 1]; j--)
            {
                array.Swap(j, j - 1);
            }
        }
        return array;
    }
}
