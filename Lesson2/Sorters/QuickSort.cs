using Lesson2.Sorters.Base;

namespace Lesson2.Sorters;

public class QuickSort : ISorter
{
    public int[] Sort(int[] array) {
        if (array.Length <= 1) return array;
        int pivot = Random.Shared.Next(0, array.Length);
        int[] left = array.Where(item => item < array[pivot]).ToArray();
        int[] middle = array.Where(item => item == array[pivot]).ToArray();
        int[] right = array.Where(item => item > array[pivot]).ToArray();
        var list = new List<int>();
        list.AddRange(Sort(left));
        list.AddRange(middle);
        list.AddRange(Sort(right));
        return list.ToArray();
    }
}
