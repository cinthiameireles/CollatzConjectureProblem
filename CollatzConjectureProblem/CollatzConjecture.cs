namespace CollatzConjectureProblem;

public static class CollatzConjecture
{
    private static int CalculateEven(int x) => x / 2;

    private static int CalculateOdd(int x) => (3 * x) + 1;

    public static List<int> CalculateNumber(int number)
    {
        List<int> currentResults = new();
        currentResults.Add(number);

        while (number > 1)
        {
            int result = int.IsEvenInteger(number) ? CalculateEven(number) : CalculateOdd(number);
            currentResults.Add(result);
            number = result;
        }

        return currentResults;
    }

    public static List<List<int>> CalculateNFirstNumbers(int n)
    {
        List<List<int>> results = new();

        for (int i = 0; i < n; i++)
        {
            //Console.WriteLine($"Calculating {i + 1}...");
            List<int> currentResults = CalculateNumber(i + 1);
            results.Add(currentResults);
        }

        return results;
    }
}
