using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_Beginner_Series_Nr3_Sum_of_Numbers
{
    //Given two integers a and b, which can be positive or negative, find the sum of all the numbers between including them too and return it.If the two numbers are equal return a or b.

    //Note: a and b are not ordered!

    //Examples
    //GetSum(1, 0) == 1   // 1 + 0 = 1
    //GetSum(1, 2) == 3   // 1 + 2 = 3
    //GetSum(0, 1) == 1   // 0 + 1 = 1
    //GetSum(1, 1) == 1   // 1 Since both are same
    //GetSum(-1, 0) == -1 // -1 + 0 = -1
    //GetSum(-1, 2) == 2  // -1 + 0 + 1 + 2 = 2

    class Program
    {
        static void Main(string[] args)
        {
            //My Solution
            int GetSum(int a, int b)
            {
                int leftSideNumber = a;
                int rightSideNumber = b;
                int finalScore = leftSideNumber;


                if (leftSideNumber > rightSideNumber)
                {
                    int diffrence = Math.Abs(leftSideNumber - rightSideNumber);
                    for (int i = 0; i < diffrence; i++)
                    {
                        leftSideNumber--;
                        finalScore += leftSideNumber;
                    }
                }
                else if ( leftSideNumber < rightSideNumber)
                {
                    int diffrence = Math.Abs(leftSideNumber - rightSideNumber);
                    for (int i = 1; i <= diffrence; i++)
                    {
                        leftSideNumber++;
                        finalScore += leftSideNumber;
                    }
                }
                else
                {
                    finalScore = leftSideNumber;
                }
                return finalScore;
            }
            // Codewars best solution 
            int GetSum2(int a, int b)
            {
                return (a + b) * (Math.Abs(a - b) + 1) / 2; //Well i could use mathematical formula instead of my code. 
            }
        }
    }
}
