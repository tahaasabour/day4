
using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        SuperArray sArr
             = new SuperArray();


        Console.WriteLine(sArr.Count);
        Console.WriteLine(sArr.Capacity);
        Console.WriteLine();
        sArr.Add(1);
        sArr.Add(10);
        sArr.Add(500);

        //Console.WriteLine();
        //Console.WriteLine(sArr.Count);
        //Console.WriteLine(sArr.Capacity);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        IEnumerator rator = sArr.GetEnumerator();
        while (rator.MoveNext())
        {
            //rator.Current = 10;
            int i = (int)rator.Current;
            i = 90;
            Console.WriteLine(i);
            Console.WriteLine(i);
        }

        foreach (int i in sArr)
        {
            // i = 90;
            sArr.Add(6999);
            Console.WriteLine(i);
            Console.WriteLine(i);
        }


        //for (int i =0; i< sArr.Count; i++)
        //    Console.WriteLine(sArr.Get(i));





    }
}