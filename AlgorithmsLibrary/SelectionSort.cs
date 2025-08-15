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

    // Пример использования
    public class Program
    {
        public static void Main()
        {
            int[] array = { 64, 25, 12, 22, 11, 99, 3, 100 };

            Console.WriteLine("Неотсортированный массив:");
            Console.WriteLine(string.Join(", ", array));

            SelectionSort.Sort(array);

            Console.WriteLine("\nОтсортированный массив:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}