namespace AlgorithmsLibrary
{
    public class QuickSort
    {
        public static int[] Sort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr;
            }
            else
            {
                Random r = new Random();
                List<int> less = new List<int>();
                List<int> greater = new List<int>();
                int pivot = arr[r.Next(arr.Length)];
                for (int i = 1; i < arr.Length; i++)
                {

                    if (arr[i] < pivot)
                    {

                        less.Add(arr[i]);
                    }
                    else
                    {
                        greater.Add(arr[i]);
                    }


                }
                int[] sortedLess = Sort(less.ToArray());
                int[] sortedGreater = Sort(greater.ToArray());
                int[] result = new int[sortedLess.Length + 1 + sortedGreater.Length];
                Array.Copy(sortedLess, 0, result, 0, sortedLess.Length);
                result[sortedLess.Length] = pivot;
                Array.Copy(sortedGreater, 0, result, sortedLess.Length + 1, sortedGreater.Length);
                return result;
            }
        }
    }
}