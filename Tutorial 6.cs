/*
Switch
Switch statement is modified in C#.

Now after executing a case statement, program flow can not jump to next case which was previously allowed in C++.
*/
//Example:

int var = 100;
switch (var) 
{ 
    case 100: Console.WriteLine("<Value is 100>"); // No break here 
    case 200: Console.WriteLine("<Value is 200>"); break; 
}

//Output in C++:
//<Value is 100><Value is 200>
/*
In C# you get compile time error:

Copy Code
error CS0163: Control cannot fall through 
       from one case label ('case 100:') to another
*/

//However you can do this similar to how you do it in C++:
switch (var) 
{
    case 100: 
    case 200: Console.WriteLine("100 or 200<VALUE is 200>"); break; 
}
//You can also use constant variables for case values:
//Example:
const string WeekEnd = "Sunday";
const string WeekDay1 = "Monday";

....

string WeekDay = Console.ReadLine();
switch (WeekDay ) 
{ 
case WeekEnd: Console.WriteLine("It's weekend!!"); break; 
case WeekDay1: Console.WriteLine("It's Monday"); break;

}
/*
Delegates
Delegates let us store function references into a variable. In C++, this is like using and storing function pointer for which we usually use typedef.

Delegates are declared using a keyword delegate. Have a look at this example, and you will understand what delegates are:
*/
//Example:

delegate int Operation(int val1, int val2);
public int Add(int val1, int val2) 
{ 
    return val1 + val2; 
}
public int Subtract (int val1, int val2) 
{ 
    return val1- val2;
}

public void Perform()
{
    Operation Oper;
    Console.WriteLine("Enter + or - ");
    string optor = Console.ReadLine();
    Console.WriteLine("Enter 2 operands");
            
    string opnd1 = Console.ReadLine();
    string opnd2 = Console.ReadLine();
            
    int val1 = Convert.ToInt32 (opnd1);            
    int val2 = Convert.ToInt32 (opnd2);
            
    if (optor == "+")
        Oper = new Operation(Add);
    else
        Oper = new Operation(Subtract);
        
    Console.WriteLine(" Result = {0}", Oper(val1, val2));
}