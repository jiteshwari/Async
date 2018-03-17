using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asynchronous.cs
{
    class ClaAsyn
    {
        public static async void Test()
        {
            Task<int> task = Show();
            Display();
            int count = await task;
            Method1(count);
        }
        public static async Task<int> Show()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Test1");
                    count += 1;
                }
            });
            return count;
        }
        public static void Display()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Test2");
            }
        }
        public static void Method1(int count)
        {
            Console.WriteLine("Total count is " + count);
        }

        static void Main(string[] args)
        {
            Test();//call
            Console.ReadKey();
        }

    }

}

