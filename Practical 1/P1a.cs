using System;


namespace Practical_1
{
    internal class P1a
    {
        static void Main(string[] args)
        {
            int no1, no2, no3, no4, ans;
            Console.Write("Enter the first Number:");
            no1=int.Parse(Console.ReadLine());
            Console.Write("Enter the Second Number:");
            no2 =int.Parse(Console.ReadLine());
            Console.Write("Enter the Third Number:");
            no3 =int.Parse(Console.ReadLine());
            Console.Write("Enter the Fourth Number:");
            no4 =int.Parse(Console.ReadLine());
            ans=no1+no2 + no3 + no4;
            Console.WriteLine("Addition of"+no1+no2+no3+no4+" is "+ans);
            Console.ReadKey();



        }
    }
}
