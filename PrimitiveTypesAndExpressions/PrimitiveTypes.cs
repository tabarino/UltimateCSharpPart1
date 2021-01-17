using System;

namespace PrimitiveTypesAndExpressions
{
    public class PrimitiveTypes
    {
        public void IntegralNumbersExample()
        {
            // Every time you see the letter u in these C# types, it means Unsigned

            sbyte testSbute = 12; // Bytes = 1, Range = -128 to 127

            byte testByte = 0; // Bytes = 1, Range = 0 to 255

            short testShort = 23; // Bytes = 2, Range = -32768 to 32767

            ushort testUshort = 45; // Bytes = 2, Range = 0 to 65535

            int testInt = 12; // Bytes = 4, Range = -2,147,483,648 to 2,147,483,647

            uint testUint = 12; // Bytes = 4, Range = 0 to 4,294,967,295

            long testLong = 123245234; // Bytes = 8, Range = -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            ulong testUlong = 1232234; // Bytes = 8, Range = 0 to 18,446,744,073,709,551,615
        }

        public void RealNumbersExample()
        {
            float testFloat = 1.2f; // Bytes = 4, Precision = ~6-9 digits, Range = ±1.5 x 10−45 to ±3.4 x 1038

            double testDouble = 1.2d; // Bytes = 8, Precision = ~15-17 digits, Range = ±5.0 × 10−324 to ±1.7 × 10308

            decimal testDecimal = 1.2m; // Bytes = 16, Precision = 28-29 digits, Range = ±1.0 x 10-28 to ±7.9228 x 1028
        }

        public void CharacterExample()
        {
            char testChar = 's'; // Bytes = 2, Range = Unicode Characters
        }

        public void BooleanExample()
        {
            bool testBool = true; // Bytes = 1, Range = true/false
        }
    }
}
