using System;

namespace ConsoleApplication2
{
    public class Stairs
    {
        public void Calculate()
        {
            var num = 6;

            for (int i = 1; i <= num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j < num - i)
                        Console.Write(' ');
                    else
                        Console.Write('#');
                }
                Console.Write("\n");
            }
        }
    }
}
