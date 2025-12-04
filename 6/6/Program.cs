class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi i am factorial solver\n\nWaiting for number\n\nAnd remember i`m to silly for numbers bigger then 19");

        if (int.TryParse(Console.ReadLine(), out int number) && number <= 19)
        {
            Console.WriteLine("Calculating please wait");

            Thread.Sleep(Random.Shared.Next(1000, 6000));

            Console.WriteLine(Dactorial(number));
        }
        else
        {
            Console.WriteLine("Bruuuuuuuuuuuuuuuh");
        }
    }

    private static long Dactorial(int n)
    {
        return Enumerable.Range(1, n).Aggregate(1L, (a, b) => a * b);

        // I can write it but it unsafe
        //if (n <= 1) return 1;
        //return n * Dactorial(n - 1);
    }
}