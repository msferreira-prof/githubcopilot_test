public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("The sum of 2 and 3 is " + Add(2, 3));

        // create a list of Random numbers
        HashSet<int> numbersSet = new HashSet<int>();
        Random rand = new Random();
        while (numbersSet.Count < 10)
        {
            numbersSet.Add(rand.Next(1, 100));
        }
        List<int> numbers = numbersSet.ToList();
        Console.WriteLine("The list of random numbers is: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        AddPrimeNumbersInNumericList(numbers);
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void AddPrimeNumbersInNumericList(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (isPrime(number))
            {
                sum += number;
            }
        }
        Console.WriteLine("The sum of prime numbers in the list is " + sum);
    }

    public static bool isPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}