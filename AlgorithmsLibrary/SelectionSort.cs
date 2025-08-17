namespace AlgorithmsLibrary
{



    public class SelectionSort
    {
        // Основной метод сортировки
        public static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                // Находим индекс минимального элемента в неотсортированной части
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Меняем местами найденный минимум и первый элемент неотсортированной части
                if (minIndex != i)
                {
                    Swap(ref array[i], ref array[minIndex]);
                }
            }
        }

        // Вспомогательный метод для обмена элементов
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

 
}