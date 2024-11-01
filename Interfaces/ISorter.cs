namespace Interfaces
{
    public interface ISorter
    {
        void Sort(List<int> collection);
    }


    public class QuickSort:ISorter
    {
        public void Sort(List<int> collection)
        {
            Console.WriteLine("QuickSort applied.");
        }
    }
}