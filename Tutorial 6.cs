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