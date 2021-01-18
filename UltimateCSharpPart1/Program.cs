using System;
using NonPrimitiveTypes;
using PrimitiveTypesAndExpressions;

namespace UltimateCSharpPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------------------
            // Primitive Types and Expressions
            //--------------------------------
            //_ = new VariablesAndConstants();
            //_ = new TypeConversion();
            //_ = new Operators();

            //--------------------
            // Non-Primitive Types
            //--------------------
            //var john = new ClassPerson();
            //john.FirstName = "John";
            //john.LastName = "Doe";
            //john.Introduce();

            //_ = new ArraysExample();
            //_ = new StringsExample();
            _ = new ReferenceTypesAndValueTypes();

            // Enums Example
            //var shippingMethod = EnumShippingMethod.Express;
            //Console.WriteLine(shippingMethod.ToString());
            //Console.WriteLine((int)shippingMethod);
            //var methodId = 2;
            //Console.WriteLine((EnumShippingMethod)methodId);
            //var methodName = "RegularAirMail";
            //var parseMethod = (EnumShippingMethod)Enum.Parse(typeof(EnumShippingMethod), methodName);
            //Console.WriteLine(parseMethod);
        }
    }
}
