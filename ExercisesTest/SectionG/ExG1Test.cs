using System.Diagnostics;
using CSExercises;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExercisesTest
{
    [TestClass]
    public class ExG1Test
    {
        static void Main(string[] args)
        {
            q1();
        }
        static void q1()
        {
            Console.WriteLine("Question 1:");
            Console.Write("Enter a string:");
            string input = Console.ReadLine();
            int tSum = 0;
            int aSum = 0;
            int eSum = 0;
            int iSum = 0;
            int oSum = 0;
            int uSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'A')
                {
                    aSum++;
                }
                else if (input[i] == 'e' || input[i] == 'E')
                {
                    eSum++;
                }
                else if (input[i] == 'i' || input[i] == 'I')
                {
                    iSum++;
                }
                else if (input[i] == 'o' || input[i] == 'O')
                {
                    oSum++;
                }
                else if (input[i] == 'u' || input[i] == 'U')
                {
                    uSum++;
                }
            }
            tSum = aSum + eSum + iSum + oSum + uSum;
            Console.WriteLine("Total vowels:{0}", tSum);
            Console.WriteLine("A:{0}", aSum);
            Console.WriteLine("E:{0}", eSum);
            Console.WriteLine("I:{0}", iSum);
            Console.WriteLine("O:{0}", oSum);
            Console.WriteLine("U:{0}", uSum);
        }
    }
}