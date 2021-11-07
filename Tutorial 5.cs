/*
Variable number of parameters and arrays
Arrays in C# are passed through a keyword params. An array type parameter should always be the right most argument of the function. Only one parameter can be of array type. You can pass any number of elements as an argument of type of that array. You can better understand it from example below:

Note: This is the only way C# provides for optional or variable number of parameters, that is using array.
*/
//Example:

void Func(params int[] array)
{
    Console.WriteLine("number of elements {0}", array.Length);
}

Func(); // prints 0
Func(5); // prints 1
Func(7,9); // prints 2
Func(new int[] {3,8,10}); // prints 3
int[] array = new int[8] {1,3,4,5,5,6,7,5};
Func(array); // prints 8

/*
Operators and expressions
Operators are exactly the same as of C++ and thus the expression also. However some new and useful operators are also added. Some of them are discussed here.

is operator
is operator is used to check whether the operand types are equal or convert-able. The is operator is particularly useful in the polymorphism scenarios. is operator takes two operands and the result is a boolean. See the example:
*/
void function(object param)
{ 
    if(param is ClassA)
        //do something 
    else if(param is MyStruct)
        //do something         
    }
}