using System;

namespace NonPrimitiveTypes
{
    public struct StructRgbColor
    {
        // Structs (Structures) are Value Types

        // Value Types
        // - Allocated on stack
        // - Memory Allocation done automatically
        // - Immediately removed when out of scope

        // Classes and Structures have three basic differences:
        // - Classes are reference types and structs are value types;
        // - Structures do not support inheritance;
        // - Structures cannot have default constructor.

        public int Red;
        public int Green;
        public int Blue;
    }
}
