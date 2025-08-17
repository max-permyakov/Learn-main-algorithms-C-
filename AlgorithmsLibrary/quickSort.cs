using System.Collections.Generic;
using System.ComponentModel.Design;
namespace AlgorithmsLibrary
{
    public class quickSort
    {
        public static int[] Sort(int[] a)
        {
            if (a.Length < 2) { return a; }
            else { 
            int pivot = a[0];

            List<int> less = new List<int>();
            List<int> greater = new List<int>();
                for(int i=1; i<a.Length; i++)
                {
                    if (a[i]<pivot)
                    {
                        less.Add(a[i]);

                    }else greater.Add(a[i]);
                            
               }
                int[] sortedLess = Sort(less.ToArray());
                int[] sortedGreater = Sort(greater.ToArray());

                int[] result = new int[sortedLess.Length+1+sortedGreater.Length];
                Array.Copy(sortedLess, 0, result, 0, sortedLess.Length);
                result[sortedLess.Length] = pivot;
                Array.Copy(sortedGreater, 0, result, sortedLess.Length + 1, sortedGreater.Length);

                return result;

            }




        }      
    }
}
