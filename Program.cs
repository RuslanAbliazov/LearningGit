using System;

namespace LearningGit
{
    class Program
    {
        static int factorial(int n)
        {
            int ans = 1;
            for (int i = 1; i < n; i++)
            {
                ans = ans * i; 
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(i*i + "Extreme cod!!!");
            }
            Console.WriteLine(factorial(5));
        }
    }
}
