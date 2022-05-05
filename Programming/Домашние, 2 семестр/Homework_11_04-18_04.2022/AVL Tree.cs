namespace Programming.Programming.Домашние__2_семестр.Homework_11_04_18_04._2022;

public class TreeNode<T> : IComparable<T>, IComparable
    where T: IComparable, IComparable<T>
{
    public T Data;
    public TreeNode<T> Left;
    public TreeNode<T> Right;

    public TreeNode(T data)
    {
        Data = data;
    }
    
    public int CompareTo(object obj) 
    {
        if (obj is TreeNode<T> item)
        {
            return Data.CompareTo(item);
        }
        throw new ArgumentException("Типы не совпадают");
    }

    public int CompareTo(T data) 
    {
        return Data.CompareTo(data); 
    }
}

public class AVLTree<T>
    where T : IComparable, IComparable<T>
{
    public TreeNode<T> Root;
    private int count;

    public void Add(T data)
    {
        TreeNode<T> node = new TreeNode<T>(data);
        if (Root == null)
        {
            Root = node; 
        }
        else
        {
            Root = RecursiveInsert(Root, node);
        }
    }
    private TreeNode<T> RecursiveInsert(TreeNode<T> runner, TreeNode<T> node)
    {
        if (runner == null)
        {
            runner = node;
            return runner;
        }
        else if (node.Data.CompareTo(runner.Data) < 0)
        {
            runner.Left = RecursiveInsert(runner.Left, node);
            runner = Balance(runner);
        }
        else if (node.Data.CompareTo(runner.Data) > 0)
        {
            runner.Right = RecursiveInsert(runner.Right, node);
            runner = Balance(runner);
        }
        return runner;
    }
    
    private TreeNode<T> Balance(TreeNode<T> runner)
    {
        int b_factor = balance_factor(runner);
        if (b_factor > 1)
        {
            if (balance_factor(runner.Left) > 0)
            {
                runner = SmallRightRotate(runner);
            }
            else
            {
                runner = BigRightRotate(runner);
            }
        }
        else if (b_factor < -1)
        {
            if (balance_factor(runner.Right) > 0)
            {
                runner = BigLeftRotate(runner);
            }
            else
            {
                runner = SmallLeftTurn(runner);
            }
        }
        return runner;
    }
    
    private int balance_factor(TreeNode<T> runner)
    {
        int left = Height(runner.Left);
        int right = Height(runner.Right);
        int b_factor = left - right;
        return b_factor;
    }
    private int Height(TreeNode<T> runner)
    {
        int height = 0;
        if (runner != null)
        {
            int left = Height(runner.Left);
            int right = Height(runner.Right);
            int m = Math.Max(left, right);
            height = m + 1;
        }
        return height;
    }
    private TreeNode<T> SmallLeftTurn(TreeNode<T> node)
    {
        TreeNode<T> temp = node.Right;
        node.Right = temp.Left;
        temp.Left = node;
        node = temp;
        return node;
    }
    
    private TreeNode<T> SmallRightRotate(TreeNode<T> node)
    {
        TreeNode<T> temp = node.Left;
        node.Left = temp.Right;
        temp.Right = node;
        node = temp;
        return node;
    }
    
    private TreeNode<T> BigLeftRotate(TreeNode<T> node)
    {
        node.Right = SmallRightRotate(node.Right);
        node = SmallLeftTurn(node);
        return node;
    }
    
    private TreeNode<T> BigRightRotate(TreeNode<T> node)
    {
        node.Left = SmallLeftTurn(node.Left); 
        node = SmallRightRotate(node);
        return node;
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