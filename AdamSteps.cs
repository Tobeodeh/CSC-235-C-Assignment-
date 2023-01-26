using System;

namespace AdamStepss
{
     
    class Program
    {
        
        public void counter(string steps)
        {
            /*This method checks each character of the inputted string and counts the number of times
            the letter 'U' (which represents adam standing) appears in the string. it displays the value of count
            whenever it would be called*/
            int count = 0;
            
            foreach (int i in steps)
            {
                if (i == 'U')
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }   
            
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of steps to check");
            int no_times = int.Parse(Console.ReadLine());
            for (int i = 0; i < no_times; i++)
            {
                Console.WriteLine("Enter the steps");
                string steps = Console.ReadLine();
                Program Steps = new Program();
                Steps.counter(steps);
            }
           
        }
    }
}
