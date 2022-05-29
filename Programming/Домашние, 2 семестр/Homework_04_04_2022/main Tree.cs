using System.ComponentModel.DataAnnotations;
using Контрольная_21_03_2022;

namespace Programming.Programming.Домашние__2_семестр.Homework_04_04_2022;

public class Programm
{
    static void Main(string[] args)
    {
        var Tree = new BinarySearchTree<int>();
        string[] consoleRead = Console.ReadLine().Split(" ");

        foreach (var i in consoleRead)
        {
            Tree.Add(int.Parse(i));
        }
        Tree.RainbowPrint();
        // Console.WriteLine($"Значение корня дерева: {Tree.RootData()}");
        // Console.WriteLine($"Значение родителя для вершины в позиции p: {Tree.Parent(4)}");
        // Console.WriteLine($"Значение «самого левого сына» для вершины в позиции p: {Tree.LeftMostChild(3)}");
        // Console.WriteLine($"Значение «правого брата» для вершины в позиции p: {Tree.RightSibling(4)}");
        //Console.WriteLine($"Является ли p позицией листа дерева: {(Tree.IsExternal(4) ? "Да" : "Нет")}");
        // Console.WriteLine($"Элемент дерева для вершины в позиции p: {Tree.Element(2)}");
        Tree.Remove(Tree.Root, 3);
        
        //Console.WriteLine($"{(Tree.IsInternal(4) ? "Да" : "Нет")}");
        //Console.WriteLine(Tree.IsRoot(1));
        //Console.WriteLine(Tree.Find(4));
        //Tree.PreOrderPrint(Tree.Root);
        //Tree.InOrderPrint(Tree.Root);
        //Tree.PostOrderPrint(Tree.Root);
        Tree.RainbowPrint();
        
    }

}