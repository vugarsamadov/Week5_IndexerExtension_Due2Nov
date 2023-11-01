using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_IndexerExtension_Due2Nov.Extensions
{
    public static class Extensions
    {
        public static bool IsPrime(this int number)
        {
            if (number == 2) return true;
            for (int i = 3;i<number;i+=2)
            {
                if(number%i == 0)
                    return false;
            }
            return true;
        }

        public static bool IsPowOfTwo(this int number) 
        { 
            if((number & (number-1)) == 0)
                return true;
            return false;
        }
    }
}
