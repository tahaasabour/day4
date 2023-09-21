
using System;
using System.Collections;

public class Program
{
    public static void Main()
    {

        SuperArray sArr
             = new SuperArray(10)
             {
                 10, 89, 90, "Taha"
             };



        sArr[0] = 100;

        Console.WriteLine(sArr[0]);
        Console.WriteLine(sArr[0]);
        Console.WriteLine(sArr.Count);
        Console.WriteLine(sArr.Capacity);

        Console.WriteLine();
        sArr.Add(1);
        sArr.Add(10);
        sArr.Add(500);

        sArr.TrimExcess();

        Console.WriteLine(sArr.Count);
        Console.WriteLine(sArr.Capacity);

        //Console.WriteLine();
        //Console.WriteLine(sArr.Count);
        //Console.WriteLine(sArr.Capacity);


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        //IEnumerator rator = sArr.GetEnumerator();
        //while (rator.MoveNext())
        //{
        //    //rator.Current = 10;
        //    int i = (int)rator.Current;
        //    i = 90;
        //    Console.WriteLine(i);
        //    Console.WriteLine(i);
        //}

        foreach (int i in sArr)
        {
            Console.WriteLine(i);
        }


        //for (int i =0; i< sArr.Count; i++)
        //    Console.WriteLine(sArr.Get(i));
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        SuperArray Trainees = new SuperArray(6)
        {
             new
            Trainee
            { Name = "Hany" },
              new
            Trainee
            { Name = "Mostafa" }
            };
        foreach(Trainee t in Trainees)
        {
            Console.WriteLine(t);
        }




        SuperArray sArr4 = new SuperArray();
        sArr.Add(600);
        sArr.Add("ITI");
        sArr.Add(new Trainee() { Name = "Hany"});




        foreach (object obj in sArr4)
        {
            if( obj is Trainee)
                Console.WriteLine(obj);
        }

    }

}