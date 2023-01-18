namespace SortingAlgorithms;
class Program
{
    static void Main(string[] args)
    {
        List<int> myList = new List<int> { 1, 1000, 5, 68, 8 };


        #region Method call - Bubble Sort, version 1
        BubbleSort objBubbles1 = new BubbleSort();

        objBubbles1.SortBubles1(myList);

        foreach (var bubble in myList)
        {
            Console.WriteLine(bubble);
        }
        #endregion

        #region Method call - Bubble Sort, version 2
        BubbleSort objBubbles2 = new BubbleSort();

        objBubbles2.SortBubles1(myList);

        foreach (var bubble in myList)
        {
            Console.WriteLine(bubble);
        }
        #endregion

        #region Method Call - Sellection Sort
        SelectionSort objSelectionSort = new SelectionSort();
        objSelectionSort.DataSelectAndSort(myList);
        foreach(var selected in myList)
        {
            Console.WriteLine(selected);
        }
        #endregion
        Console.ReadLine();
    }
}

