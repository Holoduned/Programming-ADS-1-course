using System.Text.RegularExpressions;
using Programming.Домашние__2_семестр.Homework_21_02_2022;

namespace Programming.Programming.Домашние__2_семестр.Homework_04_04_2022;

public class TreeNode<T> : IComparable<T>, IComparable
    where T: IComparable, IComparable<T>
{
    public T Data;
    public int position;
    public TreeNode<T> Left;
    public TreeNode<T> Right;
    public TreeNode<T> Parent;
    public int height = 0;

    public TreeNode(T data)
    {
        Data = data;
    }

    public TreeNode(T data, TreeNode<T> left, TreeNode<T> right)
    {
        Data = data;
        Left = left;
        Right = right;
    }

    public int CompareTo(object obj) 
    {
        if (obj is TreeNode<T> item)
        {
            return Data.CompareTo(item);
        }
        else
        {
            throw new ArgumentException("Типы не совпадают");
        }
    }

    public int CompareTo(T data) 
    {
        return Data.CompareTo(data); 
    }
}

public class BinarySearchTree<T>
    where T : IComparable, IComparable<T>
{
    public TreeNode<T> Root;
    private int count;
    
    public void Add(T data)
    {
        var node = new TreeNode<T>(data);

        if (Root == null)
        {
            node.position = 1;
            Root = node;
            count += 1;
        }
        else
        {
            var runner = Root;
            while (true)
            {
                if (node.Data.CompareTo(runner.Data) < 0)
                {
                    if (runner.Left == null)
                    {
                        node.Parent = runner;
                        node.height += node.Parent.height + 1;
                        node.position = 2 * node.Parent.position;
                        runner.Left = node;
                        count++;
                        return;
                    }
                    runner = runner.Left;
                }
                else
                {
                    if (runner.Right == null)
                    {
                        node.Parent = runner;
                        node.height += node.Parent.height + 1;
                        node.position = 2 * node.Parent.position + 1;
                        runner.Right = node;
                        count++;
                        return;
                    }
                    runner = runner.Right;
                }
            }
        }
    }
    public T RootData()
    {
        return Root.Data;
    }
    public string Parent(int p)
    {
        string result = "Нет родителя";

        if (p == 1)
        {
            return result;
        }
        Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.position == p)
            {
                result = runner.Parent.Data.ToString();
            }

            queue = AddQueue(runner, queue);
        }

        return result;
    }

    public string LeftMostChild(int p) 
    {
        var result = "Левого сына не существует";
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.position == p && runner.Left != null)
            {
                result = runner.Left.Data.ToString();
            }
            
            queue = AddQueue(runner, queue);
        }

        return result;
    }

    public string RightSibling(int p)
    {
        var result = "Правого брата не существует";
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.position == p && runner.Parent.Right != null)
            {
                result = runner.Parent.Right.Data.ToString();
            }

            queue = AddQueue(runner, queue);
        }

        return result;
    }
    public T Element(int p)
    {
        T result = Root.Data;
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.position == p)
            {
                result = runner.Data;
                break;
            }
            
            queue = AddQueue(runner, queue);
        }

        return result;
    }
    public bool IsExternal(int p)
    {
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.position == p && runner.Left == null && runner.Right == null)
            {
                return true;
            }

            queue = AddQueue(runner, queue);
        }
        return false;
    }
    
    public void Remove(TreeNode<T> node, T key)
    {
        if (Root == null)
            return;
        
        if (key.CompareTo(node.Data) < 0 && node.Left != null)
            Remove(node.Left, key);
        else if (key.CompareTo(node.Data) > 0 && node.Right != null)
            Remove(node.Right, key);
        else if (key.CompareTo(node.Data) == 0)
        {
            if (node.Left == null && node.Right == null)
                if (node.position % 2 == 0)
                    node.Parent.Left = null;
                else
                    node.Parent.Right = null;
            else if (node.Left == null)
                node.Parent.Left = node.Right;
            else if (node.Right == null)
                node.Parent.Right = node.Left;
            else
            {
                var Min = RecursiveSearch(node.Right);
                Remove(node.Right, Min);
                if (node.position % 2 == 0)
                    node.Parent.Left.Data = Min;
                else
                    node.Parent.Right.Data = Min;
            }
        }
    }

    private T RecursiveSearch(TreeNode<T> node)
    {
        T minimum = node.Data;
        
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(node);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.Data.CompareTo(minimum) < 0)
            {
                minimum = runner.Data;
            }

            queue = AddQueue(runner, queue);
        }
        return minimum ;
    }
    
    
    public bool IsInternal(int p)
    {
        return !IsExternal(p);
    }
    
    public bool IsRoot(int p)
    {
        return Root.position == p;
    }
    
    public bool IsRootByKey(T key)
    {
        return Root.Data.Equals(key);
    }
    
    public bool Find(int key) 
    {
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.Data.Equals(key))
            {
                return true;
            }

            queue = AddQueue(runner, queue);
        }
        return false;
    }
    
    /// <summary>
    /// Вывод в глубину прямой
    /// Прямой (pre-order)        
    /// Посетить корень    
    /// Обойти левое поддерево    
    /// Обойти правое поддерево
    /// </summary>
    public void PreOrderPrint(TreeNode<T> node)
    {
        if (node == null)
        {
            return;
        }
        Console.WriteLine(node.Data);
        PreOrderPrint(node.Left);
        PreOrderPrint(node.Right);
    }
    
    /// <summary>
    /// Вывод в глубину Симметричный или поперечный (in-order)
    /// Обойти левое поддерево
    /// Посетить корень
    /// Обойти правое поддерево
    /// </summary>
    public void InOrderPrint(TreeNode<T> node)
    {
        if (node == null)
        {
            return;
        }
        PreOrderPrint(node.Left);
        Console.WriteLine(Root.Data);
        PreOrderPrint(node.Right);
    }
    
    /// <summary>
    /// Вывод в глубину В обратном порядке (post-order)
    /// Обойти левое поддерево
    /// Обойти правое поддерево
    /// Посетить корень
    /// </summary>
    public void PostOrderPrint(TreeNode<T> node)
    {
        if (node == null)
        {
            return;
        }
        PreOrderPrint(node.Left);
        PreOrderPrint(node.Right);
        Console.WriteLine(Root.Data);
    }
    
    public void PrintDepth()
    {
        if (Root == null)
        {
            return;
        }

        Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();
            Console.WriteLine(runner.Data);

            queue = AddQueue(runner, queue);
        }
    }
    private Queue<TreeNode<T>> AddQueue(TreeNode<T> temp, Queue<TreeNode<T>> queue)
    {
        if (temp.Left != null)
        {
            queue.Enqueue(temp.Left);
        }

        if (temp.Right != null)
        {
            queue.Enqueue(temp.Right);
        }

        return queue;
    }
    
    public void RainbowPrint()
    {
        ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
        var random = new Random();

        if (Root == null)
        {
            return;
        }

        Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);
        var lastHeight = 1;
        var currentColor = colors[0];

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            int currunetHeight = runner.height;
            queue.Dequeue();

            if (currunetHeight == lastHeight)
            {
                Console.ForegroundColor = currentColor;
                Console.WriteLine(runner.Data);
            }
            else
            {
                lastHeight = currunetHeight;
                currentColor = colors[new Random().Next(1, 15)];
                Console.ForegroundColor = currentColor;
                Console.WriteLine(runner.Data);
            }

            if (runner.Left != null)
            {
                queue.Enqueue(runner.Left);
            }

            if (runner.Right != null)
            {
                queue.Enqueue(runner.Right);
            }
        }
    }
}