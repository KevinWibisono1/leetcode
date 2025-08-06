using System; 

public class Program
{


    public int[] Sort(int[] array)
    {
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[i])
                {
                    minIndex = j;
                }
            }
            //swap 
            int tempVal = array[i];
            array[i] = array[minIndex];
            array[minIndex] = tempVal;
        }

        return array;
    }

    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        int[] fruitSorted = Sort(fruits);
        int[] basketSorted = Sort(baskets);
        int index = 0; 

        for(int i = 0; i < fruitSorted.Length; i++)
        {
            if (fruitSorted[i] > basketSorted[i])
            {
                index++;
            }
        }
        return index; 
    }

    public static void Main(string[] args)
    {
        int[] fruits = { 5, 2, 5, 7 };
        int[] baskets = { 3, 6, 4, 5 };

        Program p = new Program();
        int unplaced = p.NumOfUnplacedFruits(fruits, baskets);

        Console.WriteLine("Number of unplaced fruits: " + unplaced);
    }
}