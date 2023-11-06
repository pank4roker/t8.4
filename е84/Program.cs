using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace е84
{
    internal class Program
    {
        //task1
        /*static void Swap(ref int a, ref int b,ref int c)
        {
            int p = a;
            a = b;
            b = c;
            c = p;
        }
        static void Main(string[] args)
        {
            Write("Enter a: ");
            int a = Convert.ToInt32(ReadLine());
            Write("Enter b: ");
            int b = Convert.ToInt32(ReadLine());
            Write("Enter c: ");
            int c = Convert.ToInt32(ReadLine());
            Swap(ref a, ref b,ref c);
            WriteLine($"{a}\t{b}\t{c}");*/

        //task2
        /* static void Rise(ref int x, ref int y, ref int z)
         {
             if (x > y)
             {
                 int p = x;
                 x = y;
                 y = p;
             }
             else if(y > z)
             {
                 int p = y;
                 y = z;
                 z = p;
             }
             else if (x > y)
             {
                 int p = x;
                 x = y;
                 y = p;
             }
         }
         static void Main(string[] args) 
         {
             Write("Enter x: ");
             int x = Convert.ToInt32(ReadLine());
             Write("Enter y: ");
             int y = Convert.ToInt32(ReadLine());
             Write("Enter z: ");
             int z = Convert.ToInt32(ReadLine());
             Rise(ref x, ref y, ref z);
             WriteLine($"{x}\t{y}\t{z}");*/
        //task3
        /*static void ABC(ref double rad)
        {
            double s = Math.PI * rad * rad;
            double l = 2 * Math.PI * rad;
            Write($"Radius:{rad}\tarea:{s:f2}\tlength:{l:f2}");

        }
        static void Main(string[] args) 
        {
            Write("Enter the radius of the circle: ");
            double rad = Convert.ToDouble(ReadLine());
            ABC(ref rad);*/
        //task4
        static int N(ref string sentence)
        {
            int count = 0;
            foreach (char letter in sentence)
            {
                if (letter == 'н')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Write("Enter the first sentence: ");
            string s1 = ReadLine();
            Write("Enter the second sentence: ");
            string s2 = ReadLine();
            int cs1=N(ref s1);
            int cs2=N(ref s2);
            int sumn=N(ref s1)+N(ref s2);
            Write($"Count n in first sentence: {cs1}\tCount n in second sentence: {cs2} \tTotal n:{sumn}");
            ReadKey();
        }
    }
}
