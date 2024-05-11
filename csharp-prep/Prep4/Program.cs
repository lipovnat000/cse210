using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        int sum = 0;
        int amount = 0;
        int average = 0;
        int max = 0;

        while (number != 0) {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0) {
                numbers.Add(number);
            }
        }

        foreach (int num in numbers) {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        
        foreach (int num in numbers) {
            amount ++;
            average = sum / amount;
        }
        Console.WriteLine($"The average is: {average}");

        foreach (int num in numbers) {
            if (num > max) {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}