

using System.Collections;
using System;


public class SuperArray
{
    private int[] list;
    private int count;
    public int Capacity
    { get { return list.Length; } }
    public int Count
    {
        get { return count; }
    }
    public SuperArray(int length =1)
    {
        count = 0;
        list = new int[length];
    }
    public void Add(int item)
    {
        if(count == list.Length)
        {
            Array.Resize(ref list, list.Length * 2);
        }
        list[count++] = item;
    }
    public int Get(int index)
    {
        if(index < 0  || index >= list.Length)  
            
            throw new IndexOutOfRangeException("index");
        return list[index];
    }
    public IEnumerator GetEnumerator()
    {
        return new Enumerator(this);
    }

    private class Enumerator : IEnumerator
    {
        SuperArray list;
        public Enumerator(SuperArray arr)
        {
            list = arr;
        }
        public object Current
        {
            
            get 
            {
                return list.list[index];
            }
        }
        private int index =-1;
        public bool MoveNext()
        {
            index++;
            return index < list.count;
        }
        public void Reset()
        {
            throw new NotImplementedException();
        }
    }

}