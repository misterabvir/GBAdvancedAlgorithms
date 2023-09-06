using Lesson2.Sorters.Base;

namespace Lesson2.Sorters;

public class StandardSort : ISorter
{
    public int[] Sort(int[] array) { array.ToList().Sort(); return array; }
}