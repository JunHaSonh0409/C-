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
            for (int i = 0; i < 5; i++)//9
            {
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                for (int a = i * 2; a < 8; a++)//8642
                {
                    Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Write("*");
                }
                WriteLine();
            }
            for (int i = 4; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Write("*");
                }
                for (int a = 9;a>=i*2; a--)//8642
                {
                    Write(" ");
                }
                for (int k = i; k > 0; k--)
                {
                    Write("*");
                }
                WriteLine();
             }

        }         
    }
 }
