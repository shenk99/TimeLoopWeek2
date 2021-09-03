using System;
namespace TimeLoopWeek2
{
    public class timeloop
    {
        public static void Main(String[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int x = 1; x <= num; x++)
                Console.WriteLine(x + " Abracadabra");
        }
    }
}
