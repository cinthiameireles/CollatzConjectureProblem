using CollatzConjectureProblem;
using System.Diagnostics;

Console.Write("Type the number: ");
int.TryParse(Console.ReadLine(), out int n);

Console.WriteLine("Calculating...");

var watch = new Stopwatch();
watch.Start();

List<List<int>> result = CollatzConjecture.CalculateNFirstNumbers(n);

//Console.WriteLine();
//Console.WriteLine("Results:");

//for (int i = 0; i < n; i++)
//{
//    Console.Write($"{i + 1}: ");

//    int currentLenght = result[i].Count;
//    for (int j = 0; j < currentLenght; j++)
//    {
//        Console.Write($"{result[i][j]} ");
//    }

//    Console.WriteLine();
//}

watch.Stop();

Console.WriteLine($"Finished in {watch.ElapsedMilliseconds}ms.");