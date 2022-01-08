using System;
using System.Collections.Generic;

namespace HalloWelt
{
    class Program
    {  
        static void Main(string[] args)
        {
            int count2 = 4; //Anzahl der Reihen
            int count = 0; //Zähler

            for (int i = count; i < count2-1; i++)
            {
                Console.WriteLine("L");
                count +=1;

            }

            if (count == count2-1)
            {
                for (int k = 0; k < count2; k++)
                {
                    Console.Write("L");

                }               
            }      
        }
    }
}