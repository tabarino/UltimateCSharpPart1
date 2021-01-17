using System;

namespace PrimitiveTypesAndExpressions
{
    public class Operators
    {
        public Operators()
        {
            // Arithmetic Operators
            var a = 10;
            var b = 2;
            var c = 1;
            Console.WriteLine(a + b);

            var x = 10;
            var y = 3;
            Console.WriteLine((float)x / (float)y);

            // Comparison Operators
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != x);
            Console.WriteLine(!(a != x));

            // Assignment Operators
            c += 2;
            Console.WriteLine(c);

            // Logical Operators
            Console.WriteLine(a > b && a > c);
            Console.WriteLine(a > b && a == c);
            Console.WriteLine(a > b || a == c);

            // Bitwise Operators
            int l = 60; // 60 = 0011 1100 
            int m = 13; // 13 = 0000 1101
            int n = 0;

            // Binary AND Operator copies a bit to the result if it exists in both operands.
            n = l & m; // 12 = 0000 1100
            Console.WriteLine("Line 1 - Value of c is {0}", n);

            // Binary OR Operator copies a bit if it exists in either operand.
            n = l | m; // 61 = 0011 1101
            Console.WriteLine("Line 2 - Value of c is {0}", n);

            // Binary XOR Operator copies the bit if it is set in one operand but not both.
            n = l ^ m; // 49 = 0011 0001
            Console.WriteLine("Line 3 - Value of c is {0}", n);

            // Binary Ones Complement Operator is unary and has the effect of 'flipping' bits.
            n = ~l; // -61 = 1100 0011
            Console.WriteLine("Line 4 - Value of c is {0}", n);

            // Left shift (Moves the bits against the left side by the specified amount.)
            n = l << 2; // 240 = 1111 0000
            Console.WriteLine("Line 5 - Value of c is {0}", n);

            // Right shift (Moves the bits against the right side by the specified amount.)
            n = l >> 2; // 15 = 0000 1111
            Console.WriteLine("Line 6 - Value of c is {0}", n);
        }
    }
}
