using Coding_Interview__Prepration_Problem_and_Solution.Array_and_String;
using System;

namespace Coding_Interview__Prepration_Problem_and_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayNstring = new ArrayAndString();

            var printThis = arrayNstring.SpiralOrderMatrix(new int[2, 1]{
                { 1},
                { 4}
            }, 2, 1);

            foreach (var item in printThis)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
