using Lesson2.Sorters.Base;
using System.Threading.Channels;

namespace Lesson2
{
    public static class Utils
    {
        public static async Task TestSortings(int length, int minRandomLimit, int maxRandomLimit, IEnumerable<ISorter> sortings)
        {
            await Console.Out.WriteLineAsync($"Test for {length} elements");
            if (minRandomLimit >= maxRandomLimit) throw new Exception("min value can't be more than max value");
            int[] array = length.CreateRandomRange(minRandomLimit, maxRandomLimit);

            await Start(
                sortings.Select(
                    item => new Task(
                        () => TimeMessure(() => item.Sort(array), item.GetType().Name)
                    )).ToArray()
                );
        }

        private static void TimeMessure(Func<int[]> value, string name)
        {
            DateTime start = DateTime.Now;
            value();
            DateTime finish = DateTime.Now;
            Console.WriteLine($"{name}: {(finish - start).TotalMilliseconds:##.##} ms");
        }

        private static async Task Start(params Task[] tasks)
        {
            foreach (var task in tasks)
                task.Start();
            await Task.WhenAll(tasks);
        }

        public static async Task PrintResultSortings(int length, int minRandomLimit, int maxRandomLimit, IEnumerable<ISorter> sortings)
        {
            await Console.Out.WriteLineAsync($"Test for {length} elements");
            if (minRandomLimit >= maxRandomLimit) throw new Exception("min value can't be more than max value");
            int[] array = length.CreateRandomRange(minRandomLimit, maxRandomLimit);

            await Start(
                sortings.Select(
                    item => new Task(
                        () => item.Sort(array).Print(message: item.GetType().Name)
                    )).ToArray()
                );
        }
    }
}
