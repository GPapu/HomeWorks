using System;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region პირველი დავალება
            //Console.Write("Please input Number: ");
            //int x= Convert.ToInt32(Console.ReadLine());
            //if(x%5 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}
            #endregion
            #region მეორე დავალება
            //Console.Write("enter number one: ");
            //var x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("enter number Two: ");
            //var y = Convert.ToInt32(Console.ReadLine());
            //var sum = x + y;
            //var mult = x * y;
            //Console.WriteLine("Sum of two number is: "+sum);
            //Console.WriteLine("multiplication of two number is: "+mult);
            //if (x < y)
            //{
            //    if(x==0)
            //    {
            //        Console.WriteLine("divison by  0 is not possible");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"division of two numbers: {y / x}");
            //    }
            //    Console.WriteLine($"Substraction of two numbers: {y-x}");


            //}
            //else if (x > y)
            //{
            //    if (y == 0)
            //    {
            //        Console.WriteLine("divison by  0 is not possible");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"divison of two numbers: {x / y}");
            //    }
            //    Console.WriteLine($"Substraction of two numbers: {x - y}");

            //}
            #endregion
            #region მესამე დავალება
            //Console.Write("x: ");
            //var x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("y: ");
            //var y = Convert.ToInt32(Console.ReadLine());
            //var z=0;

            //z = x;
            //x = y;
            //y = z;
            //Console.WriteLine($"x= {x}, y = {y}");
            #endregion
            #region მეოთხე დავალება
            //Console.Write("enter number: ");
            //var x = Convert.ToInt32(Console.ReadLine());
            //if (x % 2 == 0)
            //    {
            //    for(int i = 0; i < x; i++)
            //    { 
            //        x=x-2;
            //        Console.WriteLine(x*x);
            //    }
                
            //    }
            #endregion
            #region მეხუთე დავალება
            var x = int.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{x}* {i} ={x*i}");
               
            }
            #endregion

        }
    }
}
