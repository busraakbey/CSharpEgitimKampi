﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız oluşturma
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Alt alta 10 tane yıldız oluşturma her satırda 10 tane yıldız olsun
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Dik üçgen
            //for (int i = 1; i <= 5; i++)
            //{           
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Ters dik üçgen
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Dik ve ters dik üçgen beraber
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //for (int i = 4;i >= 1; i--)
            //{
            //    for(int j = 1;j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Pramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluk
            //    for (int j = n-i; j>0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldız
            //    for(int k=1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Ters Pramit
            //int n = 5;
            //for (int i = n; i >0; i--)
            //{
            //    for(int j=n-i; j > 0;j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k  <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion
            Console.Read();
        }
    }
}
