using Lesson2.Sorters.Base;

namespace Lesson2.Sorters;

public class DirectSort : ISorter
{
    public int[] Sort(int[] array)
    {
        for (int i = 0; i < array.Length-1; i++)
        {
            for (int j = 1; j < array.Length; j++)
            {
                if (array[i] < array[j]) array.Swap(i, j);
            }
        }
        return array;
    }
}
