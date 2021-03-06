/*

Classes and structs
Classes and structs are same as in C++, except the difference of their memory allocation. Objects of classes are allocated in heap, and are created using new, where as structs are allocated in stack. Structs in C# are very light and fast data types. For heavy data types, you should create classes.
*/
//Examples:

struct Date
{
    int day;
    int month;
    int year;
}
        
class Date
{
    int day;
    int month;
    int year;
    string weekday; 
    string monthName;
    public int GetDay()
    { 
        return day;
    }
    public int GetMonth() 
    { 
        return month;
    }
    public int GetYear() 
    { 
        return year;
    }
    public void SetDay(int Day) 
    { 
        day = Day ;
    }
    public void SetMonth(int Month)
    {
        month = Month;
    }
    public void SetYear(int Year)
    { 
        year = Year;
    }
    public bool IsLeapYear()
    {
        return (year/4 == 0);
    }
    public void SetDate (int day, int month, int year)
    {
    }
    ...
}

/*
Properties
If you are familiar with the object oriented way of C++, you must have an idea of properties. Properties in above example of Date class are day, month and year for which in C++, you write Get and Set methods. C# provides a more convenient, simple and straight forward way of accessing properties.
*/
//So above class can be written as:


using System;
class Date
{
    public int Day{
        get {
            return day; 
        }
        set {
            day = value; 
        }
    }
    int day;

    public int Month{
        get { 
            return month;
        }
        set {
            month = value; 
        }
    }
    int month;

    public int Year{
        get { 
            return year;
        }
        set {
            year = value;
        }
    }
    int year;

    public bool IsLeapYear(int year)
    {
        return year%4== 0 ? true: false; 
    }
    public void SetDate (int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
}

Here is the way you will get and set these properties:
class User
{
   public static void Main()
   { 
        Date date = new Date(); 
        date.Day = 27; 
        date.Month = 6; 
        date.Year = 2003;
        Console.WriteLine
         ("Date: {0}/{1}/{2}", date.Day, date.Month, date.Year);
    }
}

/*
Modifiers
You must be aware of public, private and protected modifiers that are commonly used in C++. I will here discuss some new modifiers introduced by C#.

readonly
readonly modifier is used only for the class data members. As the name indicates, the readonly data members can only be read, once they are written either by directly initializing them or assigning values to them in constructor. The difference between the readonly and const data members is that const requires you to initialize with the declaration, that is directly. See example code:
*/

class MyClass
{
    const int constInt = 100; //directly
    readonly int myInt = 5; //directly
    readonly int myInt2;
    
    public MyClass()
    {
        myInt2 = 8;        //Indirectly
    }
    public Func()
    {
        myInt = 7; //Illegal
        Console.WriteLine(myInt2.ToString());
    }
    
}

/*
sealed
sealed modifier with a class don't let you derive any class from it. So you use this sealed keyword for the classes which you don't want to be inherited from.
*/

sealed class CanNotbeTheParent
{
    int a = 5;
}

/*

unsafe
You can define an unsafe context in C# using unsafe modifier. In unsafe context, you can write an unsafe code, example: C++ pointers etc. See the following code:

*/

public unsafe MyFunction( int * pInt, double* pDouble)
{
    int* pAnotherInt = new int;
    *pAnotherInt  = 10;
    pInt = pAnotherInt;
    ...
    *pDouble = 8.9;    
}


/*

Interfaces
If you have an idea of COM, you will immediately know what I am talking about. An interface is the abstract base class containing only the function signatures whose implementation is provided by the child class. In C#, you define such classes as interfaces using the interface keyword. .NET is based on such interfaces. In C#, where you can't use multiple class inheritance, which was previously allowed in C++, the essence of multiple inheritance is achieved through interfaces. That's your child class may implement multiple interfaces.

*/

using System;
interface myDrawing
{
    int originx
    {
        get;
        set;
    }
    int originy
    {
        get;
        set;
    }
    void Draw(object shape);            
}

class Shape: myDrawing
{
    int OriX;
    int OriY;
    
    public int originx
    {
        get{
            return OriX;
        }
        set{
            OriX = value;
        }
    }
    public int originy
    {
        get{
            return OriY;
        }
        set{
            OriY = value;
        }
    }
    public void Draw(object shape)
    {
        ... // do something 
    }
    
    // class's own method
    public void MoveShape(int newX, int newY)
    {
    .....
    }        
    
}