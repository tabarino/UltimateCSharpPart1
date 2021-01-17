using System;

namespace PrimitiveTypesAndExpressions
{
    public class TypeConversion
    {
        public TypeConversion()
        {
            // Implicit Type Conversion
            byte testByte = 1;
            int testInt = testByte;
            Console.WriteLine(testInt);

            // Explicit Type Conversion
            // Be careful with it, if your int is bigger than the max of the byte, you will lose data
            int testInt2 = 1;
            byte testByte2 = (byte)testInt2;
            Console.WriteLine(testByte2);

            // Non-compatible Types Conversion
            // Parse is a little bit faster than Convert for conversions
            string number = "1234";
            int iNumber = Convert.ToInt32(number);
            Console.WriteLine(iNumber);

            try
            {
                string number2 = "1234";
                int bNumber = Convert.ToByte(number2);
                Console.WriteLine(bNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                string strBool = "true";
                bool convertedStrBool = bool.Parse(strBool);
                Console.WriteLine(convertedStrBool);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
