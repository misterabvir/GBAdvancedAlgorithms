using Lesson2.Sorters.Base;

namespace Lesson2.Sorters
{
    public class NumberSort : ISorter
    {
        public int[] Sort(int[] array)
        {
            int max = array.Max() + 1;
            int[] ints = Enumerable.Range(0, max).Select(i => 0).ToArray();
            for (int i = 0; i < array.Length; i++)
                ints[array[i]]++;
            var list = new List<int>();
            for (int i = 0; i < ints.Length; i++)
                if (ints[i] > 0)
                    list.AddRange(Enumerable.Range(0, ints[i]).Select(item => i));
            return list.ToArray();
        }
    }
}


