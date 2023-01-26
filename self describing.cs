using System;

namespace selfdescribe
{
    class Program
    {
        private static int count;
        private static int b;
        static int sSelfdescribing(int num)
        {
            //This method counts the number of times a value equal to the specified index in the argument appears
            string s = num.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                int count;
                string temp = s[i] + "";
                b = int.Parse(temp);

                count = 0;
                //creating another for loop to check 
                for (int j = 0; j < s.Length; j++)
                {
                    int temp_value = int.Parse(s[j] + "");
                    if (temp_value == i)
                    {
                        count++;
                    }

                }

            }
            return count;
        }
        static bool check(int num)
        {
            if (sSelfdescribing(num) != b)
            {
                return false;
            }

            return true;
        }
        public void print(int num)
        {
            if (check(num) == true)
            {
                Console.WriteLine("Self Describing");
            }

            if (check(num) == false)
            {
                Console.WriteLine(" Not Self Describing");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of values to check: ");
            int no_times = int.Parse(Console.ReadLine());
            for (int i = 0; i < no_times; i++)
            {
                Console.WriteLine("Enter Number to check: ");
                int num = int.Parse(Console.ReadLine());

                Program Test = new Program();
                Test.print(num);
            }
        }
    }
}
