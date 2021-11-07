/*

Arrays
Arrays in C# are much better than C++. Arrays are allocated in heap and thus are reference types. You can't access an out of bound element in an array. So C# prevents you from that type of bugs. Also some helper functions to iterate array elements are provided. foreach is the statement for such iteration. The difference between the syntax of C++ and C# array is:

The square brackets are placed after the type and not after the variable name
You create element locations using new operator.
C# supports single dimensional, multi dimensional, and jagged arrays (array of array).
*/
//Examples:

int[] array = new int[10]; // single-dimensional array of int
for (int i = 0; i < array.Length; i++) 
    array[i] = i; 

int[,] array2 = new int[5,10]; // 2-dimensional array of int
array2[1,2] = 5;

int[,,] array3 = new int[5,10,5]; // 3-dimensional array of int
array3[0,2,4] = 9;

int[][] arrayOfarray = new int[2]; // Jagged array - array of array of int
arrayOfarray[0] = new int[4]; 
arrayOfarray[0] = new int[] {1,2,15};

/*

Indexers
Indexer is used to write a method to access an element from a collection, by straight way of using [], like an array. All you need is to specify the index to access an instance or element. Syntax of Indexer is same as that of class properties, except they take the input parameter, that is the index of the element.

Example:

Note: CollectionBase is the library class used for making collections. List is the protected member of CollectionBase which stores the collection list.
*/

class Shapes: CollectionBase 
{ 
    public void add(Shape shp)
    { 
        List.Add(shp);
    }

    //indexer
    public Shape this[int index]
    { 
        get { 
            return (Shape) List[index];
        } 
        set {
            List[index] = value ;
         }
     }
}

/*

Boxing/Unboxing
The idea of boxing is new in C#. As mentioned above, all data types, built-in or user defined, are derived from a base class object in the System namespace. So the packing of basic or primitive type into an object is called boxing, whereas the reverse of this known as unboxing.
*/
//Example:

class Test
{
   static void Main() 
   {
      int myInt = 12;
      object obj = myInt ;      // boxing
      int myInt2 = (int) obj;   // unboxing
   }
}