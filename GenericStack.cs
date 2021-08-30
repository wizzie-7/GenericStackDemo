using System;
using System.Collections.Generic;

namespace GenericStackDemo
{
    class GenericStack
    {
        static void Main(string[] args)
        {
            Stack<string> ST = new Stack<string>();
            ST.Push("VIVEK");
            ST.Push("KRUNAL");
            ST.Push("NIRBAHY");
            ST.Push("ABHI");
            ST.Push("SAMEER");

            Console.WriteLine("Number od Items in GenericStack: " + ST.Count);
            Console.WriteLine("Items in GeericStack: ");
            foreach (var v in ST)
            {
                Console.WriteLine("\t{0}", v);
            }

            Console.WriteLine("Last Item i GenerivStack: " + ST.Peek());

            ST.Pop();

            Console.WriteLine("Number od Items in GenericStack After deleting Item: " + ST.Count);
            Console.WriteLine("Items in GeericStack After Deleting Item: ");
            foreach (var v in ST)
            {
                Console.WriteLine("\t{0}", v);
            }

            Console.WriteLine("Last Item i GenerivStack After deleting Item: " + ST.Peek());
        }
    }
}
