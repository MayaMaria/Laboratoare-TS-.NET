using System;
using System.Collections.Generic;
using System.Threading;

namespace NumerePrime_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> charList = new List<string>();

            bool isPrime(int number)
            {
                bool flag = true;
                for (int i = 2; i <= number / 2; i++)
                {
                    if (number % i == 0)
                        flag = false;
                }
                return flag;
            }

            int getFirstPrimeNumber(int number)
            {
                for (int i = number - 1; i >= 0; i--)
                {
                    if (isPrime(i) == true)
                        return i;
                }
                return 0;
            }

            int getFirstPrimeNumberMethod2(int number)
            {
                int result = 0;
                for (int i = 1; i < number; i++)
                {
                    if (isPrime(i) == true)
                        result = i;
                }

                return result;

            }

            static String GetTimestamp(DateTime value)
            {
                return value.ToString("HH-mm-ss-ms");
            }

            int number = Convert.ToInt32(Console.ReadLine());

            Thread thread = new Thread(() => getFirstPrimeNumber(number));
            charList.Add("Mamma");
            thread.Name = "First Thread";
            //Console.WriteLine("Start fir: " + thread.Name + GetTimestamp(DateTime.Now) + "Numarul dat" + number);
            thread.Start();
            //Console.WriteLine("End fir: " + thread.Name + GetTimestamp(DateTime.Now) + "Numar prim = ");

            Thread thread2 = new Thread(() => getFirstPrimeNumberMethod2(number));
            thread2.Name = "SecondThread";
            //Console.WriteLine("Start fir: " + thread.Name + GetTimestamp(DateTime.Now) + "Numarul dat" + number);
            thread2.Start();

            foreach (var item in charList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
