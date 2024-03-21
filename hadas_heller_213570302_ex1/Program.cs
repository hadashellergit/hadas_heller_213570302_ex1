using System;
using System.Linq.Expressions;

namespace MyApp

{
    internal class Program
    {
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
                switch (answer)
                {
                    case 1:
                        getWidthAndHeight(ref width, ref height);
                        if(width== height||Math.Abs(width - height) > 5)
                        {
                            Console.WriteLine(height * width);
                        }
                        else
                        {
                            Console.WriteLine(width * 2 + height * 2);
                        }
                        //Console.WriteLine("rectange tower\n " + width + "*" + height);
                        break;
                    case 2:
                        getWidthAndHeight(ref width, ref height);
                        Console.WriteLine("triangle tower\n"+width+ "*"+height);
                        break;
                    case 3:
                        Console.WriteLine("bye bye");
                        return;
                    default:
                        Console.WriteLine("wrong input\n");
                        break;
                }
            }
        }
    }
}
