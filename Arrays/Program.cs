using System;
using static System.Net.Mime.MediaTypeNames;

//ref link:https://www.youtube.com/watch?v=Shl7TsNMGSE&list=PLRwVmtr-pp07QlmssL4igw1rnrttJXerL
// ctrl+k+c -- comment line

class MainClass
{
    static void Main()
    {
        int[] ages = new int[5];
        //int myAge =     25;
        //int yourAge =   27;
        //int suziesAge = 23;
        //int bobbysAge = 34;
        //int jimsAge =   36;
        ages[0] = 25;
        ages[1] = 27;
        ages[2] = 23;
        ages[3] = 34;
        ages[4] = 36;
        int totalAge = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(ages[i]);
            totalAge += ages[i];
        }
        //Console.WriteLine(myAge);
        //Console.WriteLine(yourAge);
        //Console.WriteLine(suziesAge);
        //Console.WriteLine(bobbysAge);
        //Console.WriteLine(jimsAge);
        //Console.WriteLine(ages[0]);
        //Console.WriteLine(ages[1]);
        //Console.WriteLine(ages[2]);
        //Console.WriteLine(ages[3]);
        //Console.WriteLine(ages[4]);
        //int totalAge = myAge + yourAge + suziesAge + bobbysAge + jimsAge;
        Console.WriteLine(totalAge);
    }
}