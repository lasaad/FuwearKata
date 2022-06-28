namespace MoveTowardsZero;

internal class A
{
    internal static int ClosestToZero(int[] ints)
    {
        if (ints == null || !ints.Any())
            return 0;

        if (ints.Count() == ints.Where(i => i == int.MinValue).Count())
            return int.MinValue;

        var result = new List<int>();
        result.Add(int.MaxValue);

        foreach (var item in ints)
        {
            var test = item;
            if (item == int.MinValue)
            {
                test = int.MinValue + 1;
            }
            if (Math.Abs(test) < Math.Abs(result.FirstOrDefault()))
            {
                result.Clear();
                result.Add(test);
            }
            else if (Math.Abs(test) == Math.Abs(result.FirstOrDefault()))
            {
                result.Add(test);
            }
            else
                continue;
        }
        result.OrderBy(x => x).ToList();

        if (result.FirstOrDefault() == result.LastOrDefault())
            return result.LastOrDefault();
        else
            return Math.Abs(result.FirstOrDefault());
    }
}
