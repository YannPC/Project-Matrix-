﻿using System;

namespace Coding
{
    class Program
    {
          static void Main(string[] args)
           {

            int [,] a;
            int [,] b;
            int [,] c;
            // r1: row1 
            // c1: colums1
             int r1 ,c1 ,r2 ,c2 , i ,j;

             Console.WriteLine(" enter row side r1 and columns c1 first matrix ");
             r1 = int.Parse(Console.ReadLine());

             c1 = int.Parse(Console.ReadLine());
             Console.WriteLine("enter row side  r2 and columns c2 2 matrix");

             r2 = int.Parse(Console.ReadLine());
             c2= int.Parse(Console.ReadLine());

             if (r1 == c2)
            {
                 a = new int[r1,c1];
                 b = new int [r2,c2];
                 c = new int [r1,c2];
                 Console.WriteLine("Enter matrix 1");
               
                 for (i=0; i<r1;i++)

                 { 
                     for (j=0 ; j<c1;j++)
                   
                   {
                       a[i,j]= int.Parse(Console.ReadLine());

                   }

                 }
                 Console.WriteLine("Enter matrix 2");

                 
                 for (i=0; i<r2;i++)

                 { 
                     for (j=0 ; j<c2;j++)
                   
                   {
                      
                       b[i,j]= int.Parse(Console.ReadLine());

                    }
                 }

                   for ( i =0;i<r1; i++)

                   {
                       for(j =0;j<c2; j++)
                       {
                           c[i,j]=0;
                           
                           for ( r1=0 ; r1<c1;r1++)
                           
                            c[i,j] = c[i,j] + a[i,r1]*b[r1,j];
                           
                        }

                    }

                     Console.WriteLine("after multiplication result is :");

                      for (i=0; i<r1;i++)
                      {
                                for (j=0;j<c2;j++)
                          {
                                  Console.Write( c [i,j]+ " ");
                           }

                           Console.WriteLine();
                      }

                

            } 
             else
               {
                   Console.WriteLine(" Error Matrix Multiplication is Wrong");

               }
               Console.ReadKey();
         
        }
    }
}

