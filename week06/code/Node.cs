public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right (only if value is greater, not equal)
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value == Data, do nothing (don't insert duplicate)
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            // Check left subtree
            if (Left is null)
                return false;
            return Left.Contains(value);
        }
        else
        {
            // Check right subtree
            if (Right is null)
                return false;
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Height is 1 + max(height of left subtree, height of right subtree)
        // If both subtrees are null, height is 1 (the current node)
        
        int leftHeight = 0;
        int rightHeight = 0;
        
        if (Left is not null)
            leftHeight = Left.GetHeight();
        
        if (Right is not null)
            rightHeight = Right.GetHeight();
        
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}