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

/*
as operator
as operator checks if the type of the operands are convert-able or equal (as is done by is operator) and if it is, the result is a converted or boxed object (if the operand can be boxed into the target type, see boxing/unboxing). If the objects are not convert-able or box-able, the return is a null. Have a look at the example below to better understand the concept.
*/

Shape shp = new Shape(); 
Vehicle veh = shp as Vehicle; // result is null, types are not convertable

Circle cir = new Circle(); 
Shape shp = cir; 
Circle cir2 = shp as Circle;  //will be converted

object[] objects = new object[2];
objects[0] = "Umer";
object[1] = new Shape();

string str;
for(int i=0; i&< objects.Length; i++)
{
    str = objects[i] as string;
    if(str == null)
        Console.WriteLine("can not be converted");
    else
        Console.WriteLine("{0}",str);
}
/*
Output:
Umer
can not be converted
*/

/*

Statements
Statements in C# are just like in C++ except some additions of new statements and modifications in some statements.

Followings are new statements:

foreach
For iteration of collections like arrays etc.
*/
//Example:

foreach (string s in array)
    Console.WriteLine(s);

/*
lock
Used in threads for locking a block of code making it a critical section.

checked/unchecked
The statements are for overflow checking in numeric operations.
*/
//Example:

int x = Int32.MaxValue; x++; // Overflow checked 
{ 
x++; // Exception 
}
unchecked
{
x++; // Overflow}
}