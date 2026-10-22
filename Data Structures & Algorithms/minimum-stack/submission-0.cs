class node<T>
{

    public T value;
    public node<T> prev { get; set; }

    public node()
    {
        prev = null;
        value = default(T);
    }
    public node(T val)
    {
        value = val;
        prev = null;
    }

    public node(T val, node<T> pre)
    {
        prev = pre;
        value = val;
    }
}

class kvp<T, Y>
{
    public T key { get; private set; }
    public Y val { get; set; }

    public kvp(T k, Y v)
    {
        val = v;
        key = k;
    }
}
public class MinStack
{
    private node<kvp<int, uint>> minVal;
    private node<int> currNode;

    public MinStack()
    {

        currNode = null;
        minVal = null;
    }

    public void Push(int val)
    {
        if (minVal == null) 
            minVal = new node<kvp<int, uint>>(new kvp<int, uint>(val, 1));
            else if (val < minVal.value.key)
            minVal = new node<kvp<int, uint>>(new kvp<int, uint>(val, 1) , minVal);
        else if ( val == minVal.value.key)
            minVal.value.val ++;

        currNode = new node<int>(val, currNode);
        
    }

    public void Pop()
    {
        Console.WriteLine(currNode.value + " , " + minVal.value.val);
        if (currNode.value == minVal.value.key)
        {
            minVal.value.val--;
            if (minVal.value.val == 0) minVal = minVal.prev;
        }
        if (currNode.prev != null)
            currNode = currNode.prev;


    }

    public int Top()
    {
        return currNode.value;
    }

    public int GetMin()
    {
        
        return minVal.value.key;
    }
}
