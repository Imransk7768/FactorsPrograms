using System;

namespace FactorProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter a number for Prime factor : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2;i <= num;i++)
            {
                if(num % i == 0)
                {
                    for(int j = 1 ;j <= i; j++)
                    {
                        if(i%j==0)
                        {
                            count++;
                        }
                    }
                }
            }
            if (count == 2)
            {
                int n = num/num;
                Console.WriteLine("Given number is a Prime : " + num);
                Console.WriteLine("Prime Factors of " + num + " is " + num + " & " +n);
            }

            else
                Console.WriteLine("Given number is not a Prime : " + num);
        }
    }
}