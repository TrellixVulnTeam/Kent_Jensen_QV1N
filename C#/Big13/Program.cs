﻿using System;
using System.Collections.Generic;

namespace Big13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, -1, -2, -3, -4, -5};
            print1to255();
            printIntsAndSum();
            printMaxOfArray(arr);
            returnOddsArray1To255(arr);
            returnArrayCountGreaterThanY(arr, 3);
            printMaxMinAvgArrayVals(arr);
            swapNegsInArray(arr);
            printOdds1to255();
            printArr(arr);
            printAvgArray(arr);
            squareArr(arr);
            zeroNegsInArray(arr);
            shiftLeft(arr);
        }

        static void print1to255()
        {
            for (int i=1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void printIntsAndSum()
        {
            int sum = 0;
            for (int i=0; i < 256; i++)
            {
                sum += i;
                Console.WriteLine(i);
                Console.WriteLine(sum);
            }
        }

        static void printMaxOfArray(int[] arr)
        {
            int high = arr[0];
            for(int i = 0; i<arr.Length;i++)
            {
                if(arr[i] > high)
                {
                    high = arr[i];
                }
            }
        }

        static void returnOddsArray1To255(int[] arr)
        {
            int[] NewArr = new int[256/2];
            int indexpos = 0;
            for (int i = 1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                    NewArr[indexpos] = i;
                    indexpos ++;
                }
            }
        }

        static void returnArrayCountGreaterThanY(int[] arr, int y)
        {
            int count = 0;
            for (int i = 0; i <arr.Length; i++)
            {
                if (arr[i] > y)
                {
                count++;
                }
            }
            Console.WriteLine(count);
        }

        static void printMaxMinAvgArrayVals(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
                else if (min > arr[i])
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            float avg = sum/arr.Length;
            Console.WriteLine(avg);
        }

        static void swapNegsInArray(int[] arr)
        {
             List<string> noNegs = new List<string>();
             for (int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] < 0)
                 {
                     noNegs.Add("Dojo");
                 }
                 else
                 {
                     noNegs.Add(arr[i].ToString());
                 }
             }
        }

        static void printOdds1to255()
        {
            for (int i=1; i < 256; i++)
            {
                if (i % 2 == 1)
                {
                Console.WriteLine(i);
                }
            }
        }

        static void printArr(int[] arr)
        {
            for (int i=0; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void printAvgArray(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i< arr.Length; i++)
            {
                sum += arr[i];
            }
            float avg = sum/arr.Length;
            Console.WriteLine(avg);
        }

        static void squareArr(int[] arr)
        {
            for(int i =0; i < arr.Length; i++)
            {
                arr[i] *= arr[i];
            }
        }

        static void zeroNegsInArray(int[] arr)
        {
             for(int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] < 0)
                 {
                     arr[i] = 0;
                 }
             }
        }

        static void shiftLeft(int[] arr)
        {
             for(int i = 0; i < arr.Length-1; i++)
             {
                 arr[i] = arr[i+1];
             }
             arr[arr.Length - 1] = 0;
        }
    }
}
