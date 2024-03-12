// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("modyfikacja1");
static double GetAverage(int[] numbers)
{
    double ssum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        ssum += numbers[i];
    }
    return ssum / numbers.Length;
}

int[] arr = { 1, 2, 3, 4 };
double averge = GetAverage(arr);
Console.WriteLine(averge);
