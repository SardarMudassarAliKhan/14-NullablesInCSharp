using System;

class Program
{
    static void Main()
    {
        // Declaring nullable types
        int? nullableInt = null;
        double? nullableDouble = 3.14;
        bool? nullableBool = true;

        // Assigning values to nullable types
        nullableInt = 10;
        nullableDouble = null;
        nullableBool = false;

        // Checking if nullable types have values or are null
        if(nullableInt.HasValue)
        {
            Console.WriteLine("nullableInt has a value: " + nullableInt.Value);
        }
        else
        {
            Console.WriteLine("nullableInt is null");
        }

        if(nullableDouble.HasValue)
        {
            Console.WriteLine("nullableDouble has a value: " + nullableDouble.Value);
        }
        else
        {
            Console.WriteLine("nullableDouble is null");
        }

        if(nullableBool.HasValue)
        {
            Console.WriteLine("nullableBool has a value: " + nullableBool.Value);
        }
        else
        {
            Console.WriteLine("nullableBool is null");
        }

        // Accessing values of nullable types safely
        int result1 = nullableInt ?? 0; // Assigns 0 if nullableInt is null
        double result2 = nullableDouble ?? 0.0; // Assigns 0.0 if nullableDouble is null
        bool result3 = nullableBool ?? false; // Assigns false if nullableBool is null

        Console.WriteLine("result1: " + result1);
        Console.WriteLine("result2: " + result2);
        Console.WriteLine("result3: " + result3);

        // Using null-conditional operator
        string message = nullableInt?.ToString(); // message will be null if nullableInt is null

        Console.WriteLine("Message: " + message);

        // Using null-coalescing assignment operator
        int? newNullableInt = null;
        newNullableInt ??= 20; // Assigns 20 to newNullableInt if it's null

        Console.WriteLine("newNullableInt: " + newNullableInt);
    }
}
