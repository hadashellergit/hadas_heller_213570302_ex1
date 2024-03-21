using System;
using System.Linq.Expressions;

namespace MyApp

{

    internal class Program
    {
        static void rectangeTower(int width, int height)
        {
            if (width == height || Math.Abs(width - height) > 5)
            {
                Console.WriteLine("the area is " + height * width + "\n");
            }
            else
            {
                Console.WriteLine("the perimeter is " + ((width * 2) + (height * 2)) + "\n");
            }
        }
        static void triangleTower(int width,int height)
        {
            int answer=0;
            while (answer != 1 && answer != 2) {
                Console.WriteLine("1 for triangle perimeter\n2 for printing the triangle");
                answer = Convert.ToInt32(Console.ReadLine());

            }
            if (answer == 1)
            {
                Console.WriteLine(width + Math.Sqrt(Math.Pow(width, 2) + 4 * Math.Pow(height, 2))+"\n");
            }
            else
            {
                if (width % 2 == 0 || width > height * 2) { Console.WriteLine("the triangle is unprintable\n"); }
                else
                {
                    Console.WriteLine("*\n**");
                }

            }
        }
        static void getWidthAndHeight(ref int width, ref int height)
        {
            Console.WriteLine("enter width");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter height");
            height = Convert.ToInt32(Console.ReadLine());

        }
        static void Main(string[] args)
        {
            int answer, height=0,width=0;
            for (; ; )
            {
                Console.WriteLine("Please type your choice; \n1 to rectange tower \n2 to tringe tower");
                answer = Convert.ToInt32(Console.ReadLine());
                //fix case when a string is typed
                switch (answer)
                {
                    case 1:
                        getWidthAndHeight(ref width, ref height);
                        rectangeTower(width, height);
                        break;
                    case 2:
                        getWidthAndHeight(ref width, ref height);
                        triangleTower(width, height);
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("wrong input\n");
                        break;
                }
            }
        }
    }
}
