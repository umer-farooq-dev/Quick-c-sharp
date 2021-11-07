/* Program structure
Like C++, C# is case-sensitive. Semi colon (;) is the statement separator. Unlike C++, there are no separate declaration (header) and implementation (CPP) files in C#. All code (class declaration and implementation) is placed in one file with extension cs.

Have a look at this Hello world program in C#. */

//Code Example

using System;

namespace MyNameSpace

{

class HelloWorld

{
    static void Main(string[] args)
    {
        Console.WriteLine ("Hello World");
     }
}

}

/*
Everything in C# is packed into a class and classes in C# are packed into namespaces (just like files in a folder). Like C++, a main method is the entry point of your program. C++'s main function is called main whereas C#'s main function starts with capital M and is named as Main.

No need to put a semi colon after a class block or struct definition. It was in C++, C# doesn't require that. */


/*
Namespace
Every class is packaged into a namespace. Namespaces are exactly the same concept as in C++, but in C# we use namespaces more frequently than in C++. You can access a class in a namespace using dot (.) qualifier. MyNameSpace is the namespace in hello world program above.

Now consider you want to access the HelloWorld class from some other class in some other namespace.*/

//Example Code

using System;
namespace AnotherNameSpace
{    
    class AnotherClass
    {
        public void Func()
        {
            Console.WriteLine ("Hello World");
        }
    }
}

//Now from your HelloWorld class you can access it as:

//Example Code

using System;
using AnotherNameSpace; // you will add this using statement
namespace MyNameSpace
{
class HelloWorld
{
    static void Main(string[] args) 
    { 
        AnotherClass obj = new AnotherClass(); 
        obj.Func();
    }
}
}

/*
In .NET library, System is the top level namespace in which other namespaces exist. By default there exists a global namespace, so a class defined outside a namespace goes directly into this global namespace and hence you can access this class without any qualifier.

You can also define nested namespaces.

Using
The #include directive is replaced with using keyword, which is followed by a namespace name. Just as using System as above. System is the base level namespace in which all other namespaces and classes are packed. The base class for all objects is Object in the System namespace.

Variables
Variables in C# are almost the same as in C++ except for these differences:

Variables in C# (unlike C++), always need to be initialized before you access them, otherwise you will get compile time error. Hence, it's impossible to access an un-initialized variable.
You can't access a “dangling” pointer in C#.
An expression that indexes an array beyond its bounds is also not accessible.
There are no global variables or functions in C# and the behavior of globals is achieved through static functions and static variables.
*/


*/

Data types
All types of C# are derived from a base class object. There are two types of data types:

Basic/ built-in types
User-defined types
Following is a table which lists built-in C# types:

Type	Bytes	Description
byte	1	unsigned byte
sbyte	1	signed byte
short	2	signed short
ushort	2	unsigned short
int	4	signed integer
uint	4	unsigned integer
long	8	signed long
ulong	8	unsigned long
float	4	floating point number
double	8	double precision number
decimal	8	fixed precision number
string		Unicode string
char		Unicode char
bool	true, false	boolean
Note: Type range in C# and C++ are different, example, long in C++ is 4 bytes, and in C# it is 8 bytes. Also the bool and string types are different than those in C++. bool accepts only true and false and not any integer.

User defined types includes:

Classes
Structs
Interfaces
Memory allocation of the data types divides them into two types:

Value types
Reference types
Value types
Values types are those data types which are allocated in stack. They include:

All basic or built-in types except strings
Structs
Enum types
Reference types
Reference types are allocated on heap and are garbage collected when they are no longer being used. They are created using new operator, and there is no delete operator for these types unlike C++ where user has to explicitly delete the types created using delete operator. In C#, they are automatically collected by garbage collector.

Reference types include:

Classes
Interfaces
Collection types like Arrays
String
Enumeration
Enumerations in C# are exactly like C++. Defined through a keyword enum.
*/

//Example Code:

C#
Copy Code
enum Weekdays
{
    Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
}
