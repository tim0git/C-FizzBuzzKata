using System.Collections.Generic;

namespace FizzBuzz
{
    public class Class1
    {
        public static string GetValue(int input)
        {

            List<string> add_list = new List<string>();

            for (int i = 0; i <= 100; i++)
            {
                if(i % 3 ==0 && i % 5 == 0)
                {
                    add_list.Add("FizzBuzzer");
                } else if(i%3 == 0)
                {
                    add_list.Add("Fizz");
                } else if(i % 5 == 0)
                {
                    add_list.Add("Buzz");
                }else
                {
                    add_list.Add(i.ToString());
                }
            }

            string[] FizzBuzzers = add_list.ToArray();

            return FizzBuzzers[input];
        }
    }
}
