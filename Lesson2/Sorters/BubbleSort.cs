using Lesson2.Sorters.Base;

namespace Lesson2.Sorters;

public class BubbleSort : ISorter
{
    public int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] > array[j + 1]) 
                    array.Swap(j, j + 1);
            }
        }
        return array;
    }
}
