using System;
using System.Linq.Expressions;

namespace MyApp

{

    internal class Program
    {
        static void rectangleTower(int width, int height)
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
            string answer="0";
            while (answer != "1" && answer != "2") {
                Console.WriteLine("1 for triangle perimeter\n2 for printing the triangle");
                answer = Console.ReadLine();

            }
            if (answer == "1")
            {
                Console.WriteLine(width + Math.Sqrt(Math.Pow(width, 2) + 4 * Math.Pow(height, 2))+"\n");
            }
            else
            {
                if (width % 2 == 0 || width > height * 2) { Console.WriteLine("the triangle is unprintable\n"); }
                else
                {
                    int asterisks = 1;
                    int x = (width - 3 )/ 2;    //check case width <3
                    int num=(height-2)/ x;
                    int count1=height-2-(num*x)+num;
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < asterisks; j++) {
                            Console.Write("*");
                        }
                        if (i == 0 ||i==count1||(i> count1&&(height-i-1)%num==1)||i+2==height) { asterisks += 2; };
                        Console.WriteLine("\n");
                    }
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
            string answer;
            int height=0,width=0;
            for (; ; )
            {
                Console.WriteLine("Please type your choice; \n1 to rectangle tower \n2 to tringe tower");
                answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        getWidthAndHeight(ref width, ref height);
                        rectangleTower(width, height);
                        break;
                    case "2":
                        getWidthAndHeight(ref width, ref height);
                        triangleTower(width, height);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("wrong input\n");
                        break;
                }
            }
        }
    }
}
