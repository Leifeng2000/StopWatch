internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = GenerateNumbers(100000);

        StopWatch stopwatch = new StopWatch();
        SelectionSort(numbers);
        stopwatch.Stop();

        long elapsedTime = stopwatch.GetElapsedTime();
        Console.WriteLine("Elapsed Time: " + elapsedTime + " milliseconds");
    }
    static int[] GenerateNumbers(int count)
    {
        int[] numbers = new int[count];
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            numbers[i] = random.Next();
        }

        return numbers;
    }
    static void SelectionSort(int[] numbers)
    {
        int n = numbers.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = temp;
        }
    }
}