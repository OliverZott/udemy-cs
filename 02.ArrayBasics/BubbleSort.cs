namespace _02.ArrayBasics
{
    class BubbleSort
    {

        public static int[] BubbleSortAlgorithm(int[] array)
        {
            int[] tempArray = (int[])array.Clone();

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (tempArray[i] > tempArray[i + 1])
                    {
                        var item = tempArray[i];
                        tempArray[i] = tempArray[i + 1];
                        tempArray[i + 1] = item;
                    }
                }
            }

            return tempArray;
        }
    }
}

