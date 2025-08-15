namespace AlgorithmsLibrary
{
    public class Bynary
    {


        public static int BinarySearch(int[] array, int target)
        {
            int Length = array.Length;
            int high = Length - 1;
            int low = 0;

            while (low <= high)
            {
                int mid = (high + low) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }

                if (array[mid] > target) high = mid - 1;
                else low = mid + 1;
            }
            return -1;

        }
    }

// public   class Check()
//    {

//        public static void Checkout()
//        {
//            int[] arr = new int[10];
//            int target = 246;
//            for (int i = 0; i < 10; i++)
//            {
//                arr[i] = i * 123;

//            }
//            Console.WriteLine("collection: ");
//            Console.WriteLine(string.Join(", ", arr));
//            Console.WriteLine("target "+target+'\n');
//            int a = Bynary.BinarySearch(arr, target);
//            Console.WriteLine("id target " + a +'\n');
//            Console.WriteLine("for code go to /AlgorithmsLibary/BynarySearch.cs\n");
            
//        }
//    }
}
