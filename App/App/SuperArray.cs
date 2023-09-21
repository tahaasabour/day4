

using System.Collections;
using System;


public class SuperArray : IEnumerable
{
    private object[] list;
    private int count;
    public int Capacity
    { get { return list.Length; } }
    public int Count
    {
        get { return count; }
    }
    public object this[int index]
    {
        get { return list[index]; }
        set { list[index] = value; }    
    }
    public SuperArray(int length =1)
    {
        count = 0;
        list = new object[length];
    }
    public void Add(object item)
    {
        if (count == list.Length)
        {
            Array.Resize(ref list, list.Length * 2);
        }
        list[count++] = item;
    }
    public object Get(int index)
    {
        if(index < 0  || index >= list.Length)  
            
            throw new IndexOutOfRangeException("index");
        return list[index];
    }
    public void TrimExcess()
    {
        object[] temp = new object[count];
        Array.Copy(list, temp, count); 
        list = temp;
    }
    public IEnumerator GetEnumerator()
    {
        for(int i = 0; i <count; i++)
        {
            yield return list[i];
        }
    }
}