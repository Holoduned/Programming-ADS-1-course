namespace ADS.Homework.Homework_21_04_2022;

public class Program
{
    static void Main(string[] args)
    {
        var array = new int[]{1001, 9, 6, 20, 8, 12, 45, 2, 4, 900, 4, 6, 1000};
        Console.WriteLine(FindMax(array, 0, array.Length - 1));
    }
    static int FindMax(int[] data, int start, int end)
    {
        if (end - start <= 1) 
        {
            return Math.Max(data[start], data[end]);
        }
        int mid = (start + end) / 2; 
        int leftMax =  FindMax(data[..mid], start, data[..mid].Length - 1);
        int rightMax = FindMax(data[mid..], 0 , data[mid..].Length - 1);
        return Math.Max(leftMax, rightMax);
    }
}