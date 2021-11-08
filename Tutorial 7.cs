/*
Inheritance and polymorphism
Only single inheritance is allowed in C#. Multiple inheritance can be achieved using interfaces.
*/
//Example:

class Parent{
}

class Child : Parent
/*
Virtual functions
Virtual functions to implement the concept of polymorphism are same in C#, except you use the override keyword with the virtual function implementation in the child class. The parent class uses the same virtual keyword. Every class which overrides the virtual method will use override keyword.
*/
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Shape.Draw")    ;
    }
}

class Rectangle : Shape

{
    public override void Draw()
    {
        Console.WriteLine("Rectangle.Draw");
    }            
}

class Square : Rectangle
{
    public override void Draw()
    {
        Console.WriteLine("Square.Draw");
    }
}
class MainClass
{
    static void Main(string[] args)
    {
        Shape[] shp = new Shape[3];
        Rectangle rect = new Rectangle();
        
        shp[0] = new Shape();
        shp[1] = rect;
        shp[2] = new Square();
                    
        shp[0].Draw();
        shp[1].Draw();
        shp[2].Draw();
    }
}
/*
Output:
Shape.Draw
Rectangle.Draw
Square.Draw
/*

/*
Hiding parent functions using "new"
You can define in a child class a new version of a function, hiding the one which is in base class. A keyword new is used to define a new version. Consider the example below, which is a modified version of above example and note the output this time, when I replace the keyword override with a keyword new in Rectangle class.
*/
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Shape.Draw")    ;
    }
}

class Rectangle : Shape
{
    public new void Draw()
    {
        Console.WriteLine("Rectangle.Draw");
    }            
}
class Square : Rectangle
{
    //wouldn't let u override it here
    public new void Draw() 
    {
        Console.WriteLine("Square.Draw");
    }
}
class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Using Polymorphism:");
        Shape[] shp = new Shape[3];
        Rectangle rect = new Rectangle();
            
        shp[0] = new Shape();
        shp[1] = rect;
        shp[2] = new Square();
                        
        shp[0].Draw();
        shp[1].Draw();
        shp[2].Draw();
            
        Console.WriteLine("Using without Polymorphism:");
        rect.Draw();            
        Square sqr = new Square();
        sqr.Draw();
    }
}    
/*   
Output:
Using Polymorphism
Shape.Draw
Shape.Draw
Shape.Draw
Using without Polymorphism:
Rectangle.Draw
Square.Draw
*/

/*
See how the polymorphism doesn't take the Rectangle class's Draw method as a polymorphic form of the Shape's Draw method, instead it considers it a different method. So in order to avoid the naming conflict between parent and child, we have used new modifier.

Note: you can not use in the same class the two versions of a method, one with new modifier and other with override or virtual. Like in above example, I can not add another method named Draw in Rectangle class which is a virtual or override method. Also in the Square class, I can't override the virtual Draw method of Shape class.

Calling base class members
If the child class has the data members with same name as that of base class, in order to avoid naming conflicts, base class data members and functions are accessed using a keyword base. See in examples how the base class constructors are called and how the data members are used.
*/
public Child(int val) :base(val)
{
    myVar = 5;
    base.myVar;
}

OR

public Child(int val)
{
    base(val);
    myVar = 5 ;
    base.myVar;
}