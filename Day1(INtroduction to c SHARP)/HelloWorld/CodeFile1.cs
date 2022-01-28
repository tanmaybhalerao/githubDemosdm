using System;

namespace CSFestures
{
    class Utility 
    {   
        //demo for reference type
        public static void swap(ref int n1,ref int n2) 
        {
           int  temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("SWAP FUNction get executed");
        }
    
        //demo for out keyword
        public static void calcarea(int radius,out double area) 
        {
            area = 3.14 * radius * radius;
        }


        //demo for params

        public static void ShowNames(params String [] names) 
        {
            foreach(string name in names) 
            {
                Console.WriteLine("name of the person is :" + name);
            }
        }
        public static void Main(String [] args) 
        {
            int score1 = 10;
            int score2 = 20;
            double area;
            Console.WriteLine("Score 1 before swap :" + score1);
            swap(ref score1, ref score2);
            Console.WriteLine("Score 1 after swap :" + score1);
            calcarea(score1, out area);
            Console.WriteLine("Area of circle is  :" + area);
            ShowNames("rajiv", "manoj", "satya", "sunder");
            Console.ReadLine();
            
        }
    }
}