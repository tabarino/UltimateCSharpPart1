using System;
using PrimitiveTypesAndExpressions;
using NonPrimitiveTypes;
using ControlFlow;
using ArraysAndLists;
using WorkingWithDates;

namespace UltimateCSharpPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrimitiveTypesAndExpressions();

            //NonPrimitiveTypes();

            //ControlFlow();

            //ArraysAndLists();

            WorkingWithDates();
        }

        static void PrimitiveTypesAndExpressions()
        {
            //_ = new VariablesAndConstants();
            //_ = new TypeConversion();
            //_ = new Operators();
        }

        static void NonPrimitiveTypes()
        {
            //var john = new ClassPerson();
            //john.FirstName = "John";
            //john.LastName = "Doe";
            //john.Introduce();

            //_ = new NonPrimitiveTypes.ArraysExample();
            //_ = new StringsExample();
            //_ = new ReferenceTypesAndValueTypes();

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

        static void ControlFlow()
        {
            //_ = new IfElseSwitchCase();
            //_ = new ForLoops();
            //_ = new ForeachLoops();
            //_ = new WhileLoops();
            //_ = new RandomClass();
        }

        static void ArraysAndLists()
        {
            //_ = new ArraysAndLists.ArraysExample();
            //_ = new ListsExample();
        }

        static void WorkingWithDates()
        {
            //_ = new DateTimeExample();
            _ = new TimeSpanExample();
        }
    }
}
