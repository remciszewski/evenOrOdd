using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOrOdd
{
    public class EvenOrOdd
    {

        public static string EOD(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd"; 
            }
        }
    }
}
