 using System;
using System.Net.Http;
using static System.Console;
using System.Drawing;
using System.Collections.Generic;
namespace classtest1
{
   
    internal class Maincpp
    {
      
        static void Main(string[] args)
        {
            WriteLine("홀수 입력 :");
            int input = int.Parse(ReadLine());
            for (int i = 0; i < (input / 2)+1; i++)
            {
                for (int j = 0; j <i; j++)
                {
                    Write(" ");
                }
                for (int k = input; k > i*2; k --)
                {
                    Write("*");
                }
                WriteLine();

            }
            for (int i = (input / 2)-1; i >=0 ; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Write(" ");
                }
                for (int k = i * 2; k<input; k++)
                {
                    Write("*");
                }
                WriteLine();
           }
      }
      
}//입력되는 홀수에 따라 달라지는 모래시게
