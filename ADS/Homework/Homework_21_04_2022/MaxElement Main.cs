namespace ADS.Homework.Homework_21_04_2022;

public class Program
{
    static void Main(string[] args)
    {
        var array = new int[]{1, 9, 6, 20, 8, 2};
        Console.WriteLine("f");
        Console.WriteLine(FindMax(array, 0, array.Length - 1));
    }
    static int FindMax(int[] data, int start, int end)
    {
        if (start - end <= 1) 
        {
            return Math.Max(data[start], data[end]);
        }
        int mid = (start + end) / 2; 
        int leftMax =  FindMax(data[..mid], start, mid);
        int rightMax = FindMax(data[mid..],mid +1, end);
        return Math.Max(leftMax, rightMax);
    }
}