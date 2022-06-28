namespace LargestWinsFromChaos;

internal class Algorithm
{
    internal static int FindLargest(int[] numbers)
    {
        int result = int.MinValue;

        foreach (var item in numbers)
        {
            if(item > result)
                    result = item;

        }

        return result; ;
    }
}
