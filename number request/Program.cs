using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_request
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = ConvertNumber();

            Console.WriteLine($"Число {number} удалось сконвертировать в int");
            Console.ReadKey();
        }

        static int ConvertNumber()
        {
            bool isSuccess = false;
            string input;
            int number = 0;
            
            while(isSuccess == false)
            {
                Console.Write("Введите число: ");
                input = Console.ReadLine();
                isSuccess = int.TryParse(input, out number);
            }

            return number;
        } 
    }
}
