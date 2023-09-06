using Lesson2;
using Lesson2.Sorters;
using Lesson2.Sorters.Base;



"simple sort func".PrintTitle();
await Utils.TestSortings(length: 20000, minRandomLimit: 0, maxRandomLimit: 20000,
    sortings: new ISorter[] {
        new BubbleSort(),
        new DirectSort(),
        new InsertSort()
    });

"advanced sort func".PrintTitle();
await Utils.TestSortings(
    length: 10000000, 
    minRandomLimit: 0, 
    maxRandomLimit: 10000000,
    sortings: new ISorter[] {
        new NumberSort(),
        new QuickSort(),
        new HeapSort(),
        new StandardSort()
    });


"result for simple array".PrintTitle();
await Utils.PrintResultSortings(
    length: 20, 
    minRandomLimit: 10, 
    maxRandomLimit: 100,
    sortings: new ISorter[] {
        new BubbleSort(),
        new DirectSort(),
        new InsertSort(),
        new NumberSort(),
        new QuickSort(),
        new HeapSort(),
        new StandardSort()
    });

/*
 * OUTPUT 
 * ----------------------- 
 * simple sort func
 * Test for 10000 elements
 * InsertSort: 33.12 ms
 * DirectSort: 645.62 ms
 * BubbleSort: 818.18 ms
 * advanced sort func
 * Test for 1000000 elements
 * NumberSort: 165.82 ms
 * HeapSort: 787.2 ms
 * QuickSort: 1220.06 ms
 * standart sort func
 * Test for 1000000 elements
 * StandardSort: 87.75 ms
 * result for simple array
 * Test for 20 elements
 * BubbleSort:    [14, 16, 18, 22, 23, 23, 35, 39, 45, 45, 46, 51, 51, 67, 67, 67, 67, 74, 74, 74]
 * QuickSort:     [14, 16, 18, 22, 23, 23, 35, 39, 45, 45, 46, 51, 51, 67, 67, 67, 67, 74, 74, 74]
 * DirectSort:    [14, 16, 18, 22, 23, 23, 35, 39, 45, 45, 46, 51, 51, 67, 67, 67, 67, 74, 74, 74]
 * NumberSort:    [14, 16, 18, 22, 23, 23, 35, 39, 45, 45, 46, 51, 51, 67, 67, 67, 67, 74, 74, 74]
 * StandardSort:  [14, 16, 18, 22, 23, 23, 35, 39, 45, 45, 46, 51, 51, 67, 67, 67, 67, 74, 74, 74]
 * InsertSort:    [14, 16, 18, 22, 23, 23, 35, 39, 45, 45, 46, 51, 51, 67, 67, 67, 67, 74, 74, 74]
 * HeapSort:      [14, 16, 18, 22, 23, 23, 35, 39, 45, 45, 46, 51, 51, 67, 67, 67, 67, 74, 74, 74]
 */