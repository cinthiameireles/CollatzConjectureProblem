using System.Runtime.CompilerServices;

namespace CollatzConjectureProblem;

public class OptimizedCollatzConjecture
{
    private HashSet<int>? previouslyCalculatedNumbers;

    private int CalculateEven(int x) => x / 2;

    private int CalculateOdd(int x) => (3 * x) + 1;

    private List<int> CalculateNumber(int number)
    {
        List<int> currentResults = [number];

        while (number > 1)
        {
            if (previouslyCalculatedNumbers!.Contains(number)) break;

            int result = int.IsEvenInteger(number) ? CalculateEven(number) : CalculateOdd(number);
            currentResults.Add(result);

            previouslyCalculatedNumbers.Add(number);
            number = result;
        }

        return currentResults;
    }

    public List<List<int>> CalculateNFirstNumbers(int n)
    {
        previouslyCalculatedNumbers = [];
        List<List<int>> results = [];

        for (int i = 0; i < n; i++)
        {
            List<int> currentResults = CalculateNumber(i + 1);
            results.Add(currentResults);
        }

        return results;
    }
}
