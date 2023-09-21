
using System;
using System.Collections;
using System.Globalization;

public class Program
{
    public static void Main()
    {
        ArrayList ls = new ArrayList(90)
        { 10, "ITI"};
        ls[0] = 90;

        Console.WriteLine(ls.Capacity);
        Console.WriteLine(ls.Count);
        ls.TrimToSize();
        Console.WriteLine(ls.Capacity);
        Console.WriteLine(ls.Count);
        foreach (object o in ls)
            Console.WriteLine(o);


        Stack s = new Stack();
        //s[0] -= 90;
        s.Push(90);
        s.Push(7);
        s.Push(79);
        s.Push(66);


        Console.WriteLine(s.Pop());
        Console.WriteLine(s.Pop());



        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(queue.Dequeue());
        Console.WriteLine(queue.Dequeue());


        Hashtable ht = new Hashtable();
        ht.Add(new Trainee() { ID = 1, Name = "Hany" }, "Ahmed");
        ht.Add(new Trainee() { ID = 1, Name = "Hany" }, "Hany");



    }

}