using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayList_ListGen
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            //Boxing.
            arrayList.Add(1);
            arrayList.Add((object)2);

            //Unboxing
            int i1 = (int)arrayList[0];

            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine((int)arrayList[i]);

            Console.WriteLine(new string('=', 5));

            List<int> list = new List<int>();

            //Упаковки нет.
            list.Add(3);
            list.Add(4);

            //Распаковки нет.
            int i3 = list[0];

            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
        }
    }
}
