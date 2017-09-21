/* 
 Created by: Danilenko Dmitriy
 Visual Studion 2017 
 Time: 6:10 PM 
 Date: 21.09.2017 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laba2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //1 задание 
            //a)
            sbyte sgndbyte = -1;
            byte unsgndbyte = 24;
            Int16 i16 = 2343;
            Int32 i32 = 24124124;
            Int64 i64 = 2 * 3424234 * 235;
            UInt16 ui16 = 2324;
            UInt32 ui32 = 234230;
            UInt64 ui64 = 2 * 23523 * 235;
            char chr = 'a';
            float single = 2.22f;
            double dbl = 21.2;
            object obj = args;
            decimal dec = 124.12m;
            string str = "hello, world!";



            //b)


            i64 = i32;
            i32 = sgndbyte;
            i16 = unsgndbyte;
            dbl = single;
            dec = i64;

            i16 = 1;
            sgndbyte = (sbyte)16;
            dec = 24241;
            i32 = (Int32)dec;
            i64 = 1345;
            sgndbyte = (sbyte)i64;
            dbl = -5.32;
            sgndbyte = (sbyte)dbl;
            ui32 = 6643;
            i32 = (Int32)ui32;

            //c)
            Object a = i32;
            i32 = (Int32)a;
            Object b = i64;
            i64 = (Int64)b;

            //d)

            var test = 4;

            test = test * 5;

            Console.WriteLine(test);

            //e)

            Int32? nullebl = null;
            Int16 tester = (Int16)(nullebl ?? 1);
            Console.WriteLine(tester);

            Nullable<Int32> NULLEBL2 = 50;
            if (NULLEBL2.HasValue)
            {
                Console.WriteLine(NULLEBL2.Value);
            }

            //2 задание
            //a)
            String str1 = "dima";
            String str2 = "petya";
            if (str1 == str2)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            //b)

            str1 = "my ";
            str2 = "name";
            String str3 = "dima";
            Console.WriteLine(str1 + str2 + str3);

            Console.WriteLine($"{str2}_is_{str1}");

            str1 = "My name is dima";

            Console.WriteLine(str1.Substring(11, 4));

            Console.WriteLine(String.Join("What about you??", str1.Split(' ')));

            Console.WriteLine(str1.Insert(11, "Lola "));

            Console.WriteLine(str1.Remove(4, 3));

            //c)


            String nullStr = null;
            try
            {
                nullStr = nullStr.Insert(0, "Hey");
                Console.WriteLine(nullStr);
            } catch (Exception e) {
                Console.WriteLine(e.GetType());
            }

            //d)
            StringBuilder strlbuilder = new StringBuilder("kek lol");
            strlbuilder.Remove(2, 3);
            strlbuilder.Insert(0, "arbidol");
            strlbuilder.Insert(strlbuilder.Length, "lol kek cheburek");
            Console.WriteLine(strlbuilder);

            //3 задание
            //a)

            const int size = 2;
            int[,] darr = new int[size, size] { { 5, 6 }, { 8, 9 } };
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(darr[i, j] + " ");
                }
                Console.WriteLine();
            }
            //b)
            String[] strarr = { "hey", "bro", "how", "are", "you" };
            Console.WriteLine($"\nLength = {strarr.Length}");
            foreach (String _str in strarr)
            {
                Console.WriteLine(_str);
            }
            Console.WriteLine("enter the number of the string for replace: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value: ");
            strarr[num - 1] = Console.ReadLine();

            Console.WriteLine();

            foreach (String _str in strarr)
            {
                Console.WriteLine(_str);
            }

            //c
            double[][] drr = new double[2][];
            drr[0] = new double[2];
            drr[1] = new double[3];
            Console.WriteLine("enter the array: ");
            for (int i = 0; i < drr.Length; i++)
            {
                Console.WriteLine($"enter {drr[i].Length} values: ");
                int j = 0;
                foreach (String rstr in Console.ReadLine().Split(' '))
                {
                    drr[i][j] = Convert.ToDouble(rstr);
                    j++;
                }
            }

            Console.WriteLine("\nEnter the array: ");
            foreach (double[] arr in drr)
            {
                foreach (double value in arr)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
            //d)
            var indexArray = new int[23];
            var str_ = "hey there!";

            //4 задание
            var tuple = (count: 10, str1: "good", ch: 'a', str2: "morning", bigint: (ulong)322);

            Console.WriteLine(tuple);
            Console.WriteLine(tuple.count + " " + tuple.ch + " " + tuple.str2);

            (int count, string _str1, char ch, string _str2, ulong bigint) = tuple;
            Console.WriteLine(count + " " + _str1 + " " + ch + " " + _str2 + " " + bigint);

            var tuple1 = (22, 22, 22);
            var tuple2 =(33, 33, 33);

            if (tuple1.CompareTo(tuple2) == 0)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            //5 задание
            (int, int, int, char) localFunc(int[] arr, string stringg) {
                
                int max = arr[0];
                int min = arr[0];
                int summa = arr[0];

                char symbol = stringg[0];

                for (int i = 1; i < arr.Length; i++) {
                    if (arr[i] < min) {
                        min = arr[i];
                    }
                    if (arr[i] > max) {
                        max = arr[i];
                    }
                    summa += arr[i];
                }

                return (max, min, summa, symbol);
            }
          
            int[] array = { 1,2,3,4,5,6,7,8,8,9,9,0 };
            Console.WriteLine(localFunc(array, "abcdefghigk"));
        }
    }
}