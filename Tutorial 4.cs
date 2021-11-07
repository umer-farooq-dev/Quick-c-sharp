/*
Function parameters
Parameters in C# are of three types:

By-Value/In parameters
By-Reference/In-Out parameters
Out parameters
If you have an idea of COM interface and it's parameters types, you will easily understand the C# parameter types.

By-Value/In parameters
The concept of value parameters is same as in C++. The value of the passed value is copied into a location and is passed to the function.
*/
//Example:

SetDay(5);
...
void SetDay(int day) 
{ 
    ....
}

/*

By-Reference/In-Out parameters
The reference parameters in C++ are passed either through pointers or reference operator &. In C# reference parameters are less error prone. Reference parameters are also called In-Out parameters because you pass a reference address of the location, so you pass an input value and get an output value from that function.

You can not pass an un-initialized reference parameter into a function. C# uses a keyword ref for the reference parameters. You also have to use keyword ref with an argument while passing it to a function demanding reference parameter.
*/
//Example:

int a= 5;
FunctionA(ref a); // use ref with argument or you will get compiler error
Console.WriteLine(a); // prints 20

void FunctionA(ref int Val)
{
    int x= Val; 
    Val = x* 4;    
}

/*
Out parameter
Out parameter is the parameter which only returns value from the function. The input value is not required. C# uses a keyword out for the out parameters
*/
//Example:

int Val;
GetNodeValue(Val);

bool GetNodeValue(out int Val)
{
    Val = value;
    return true;
}