namespace Programming.Programming.Домашние__2_семестр.Homework_11_04_18_04._2022;

public class Programm
{
    static void Main(string[] args)
    {
        // var Tree = new AVLTree<int>();
        // string[] consoleRead = Console.ReadLine().Split(" ");
        //
        // foreach (var i in consoleRead)
        // {
        //     Tree.Add(int.Parse(i));
        // }
        //
        // Tree.PrintDepth();
        
        var array = new int[]{1001, 9, 6, 20, 8, 12, 45, 2, 4, 900, 4, 6, 1000};
        Console.WriteLine("f");
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