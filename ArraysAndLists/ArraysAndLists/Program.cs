﻿using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            List<string> stringList = new List<string>();
            stringList.Add("Hello");
            stringList.Add("Jesse");
            stringList.Remove("Jesse");

            Console.WriteLine(stringList[0]);
            Console.ReadLine();

            byte[] byteArray = new byte[5000];

            //List<int> intList = new List<int>();
            //intList.Add(4);
            //intList.Add(10);
            //intList.Remove(10);

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;

            //Console.WriteLine(numArray2[3]);
            //Console.ReadLine();
        }
    }
}
