using System.Text.RegularExpressions;

namespace Programming.Programming.Домашние__2_семестр.Homework_04_04_2022;

public class TreeNode<T> : IComparable<T>, IComparable
    where T: IComparable, IComparable<T>
{
    public T Data;
    public int position;
    public TreeNode<T> Left;
    public TreeNode<T> Right;
    public TreeNode<T> Parent;

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
                        node.position = 2 * node.Parent.position;
                        runner.Left = node;
                        count++;
                        return;
                    }
                    else
                    {
                        runner = runner.Left;
                    }
                }
                else
                {
                    if (runner.Right == null)
                    {
                        node.Parent = runner;
                        node.position = 2 * node.Parent.position + 1;
                        runner.Right = node;
                        count++;
                        return;
                    }
                    else
                    {
                        runner = runner.Right;
                    }
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
    public string IsExternal(int p)
    {
        string result = "Нет";
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);

        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();

            if (runner.position == p && runner.Left == null && runner.Right == null)
            {
                result = "Да";
            }

            queue = AddQueue(runner, queue);
        }
        return result;
    }
    
    public void Remove(T key)
    {
        var queue = new Queue<TreeNode<T>>();
        queue.Enqueue(Root);
        var ListData = new List<T>();
        ListData.Add(Root.Data);
        while (queue.Count != 0)
        {
            var runner = queue.Peek();
            queue.Dequeue();
            
            if (runner.Left != null)
            {
                ListData.Add(runner.Left.Data);
                queue.Enqueue(runner.Left);
            }

            if (runner.Right != null)
            {
                ListData.Add(runner.Right.Data);
                queue.Enqueue(runner.Right);
            }
        }

        Root = null;
        ListData.Remove(key);
        foreach (var i in ListData)
        {
            Add(i);
        }
    }

    public void SmallLeftTurn(ref TreeNode<T> node)
    {
        TreeNode<T> temp = node.Right;
        node.Right = node.Right.Left;
        temp.Left = node;
        node = temp;
    }

    public void SmallRightRotate(ref TreeNode<T> node)
    {
        TreeNode<T> temp = node.Left;
        node.Left = node.Left.Right;
        temp.Right = node;
        node = temp;
    }

    public void BigLeftRotate(ref TreeNode<T> node)
    {
        
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
}


/*

/// <summary>
/// /// проверяет, является ли p позицией внутренней вершины (не листа)
/// </summary>
public bool IsInternal(int p) 
{ 
    throw new NotImplementedException();
}

/// <summary>
/// проверяет, является ли p позицией корня.
/// /// </summary>
public bool IsRoot(int p)
{
    
}

/// <summary>
/// /// проверяет, является ли key ключом корневого узла.
/// </summary>
public bool IsRootByKey(int key)
{
    
}

/// <summary>
/// /// Поиск элемента в дереве
/// </summary>
public bool Find(int key) 
{ 
    throw new NotImplementedException();
}

/// <summary>
/// /// добавление в дерево значения 
/// </summary>
public void Insert(int key, T data)
{
    
}


    /// <summary>
    /// Вывод в глубину прямой
    /// Прямой (pre-order)        
    /// Посетить корень    
    /// Обойти левое поддерево    
    /// Обойти правое поддерево
    /// </summary>
    public void PreOrderPrint()
    {
    
    }


    /// <summary>
    /// Вывод в глубину Симметричный или поперечный (in-order)
    /// Обойти левое поддерево
    /// Посетить корень
    /// Обойти правое поддерево
    /// </summary>
    public void InOrderPrint()
    {
    }


    /// <summary>
    /// Вывод в глубину В обратном порядке (post-order)
    /// Обойти левое поддерево
    /// Обойти правое поддерево
    /// Посетить корень
    /// </summary>
    public void PostOrderPrint()
    {
    }


    /// <summary>
    /// Сбалансировать дерево *
    /// </summary>
    public void Balance() 
    { 
    }*/