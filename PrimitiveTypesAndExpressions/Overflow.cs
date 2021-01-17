using System;

namespace PrimitiveTypesAndExpressions
{
    public class Overflow
    {
        public Overflow()
        {
            // There is no overflow checking for C#
            byte number = 255;
            number++; // The result of this is 0, because the max of byte is 255 and min is 0

            // In order to check the overflow you need to do the following:
            // In this case the program will throw an exception and will stop
            checked
            {
                byte overflowNumber = 255;
                overflowNumber++;
            }
        }
    }
}
