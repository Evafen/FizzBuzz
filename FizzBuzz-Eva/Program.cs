using System;

namespace FizzBuzz_Eva
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 1; i <= 1000; i++)
            {
                var value = (i%3 == 0 && i%5 == 0) ? "FizzBuzz"
                    : (i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : i.ToString();

                Console.Write($"{value},");
            }

        }
    }

}



            //    else if (i % 3 == 0)
            //  {
            //    Console.Write("Fizz,");
            //
            //}
            // else if (i % 5 == 0)
            //{
            //  Console.Write("Buzz,");
            //     }
            //   else
            //    {
            //      Console.Write($"{i},");
            //
            //              }
            //
            //        }
            //
          

    

