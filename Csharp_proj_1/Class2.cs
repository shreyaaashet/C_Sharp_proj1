
namespace Class2
{
    //Fields and methods inside classes are often referred to as "Class Members":
    //variables inside a class are called fields
    class myClass
    {
        // class members:
      
        string place= "abc";        // field
        int maxSpeed = 200;          // field
        public void method1()   // method
        {
            Console.WriteLine("The car is going to "+ place +" at speed of " + maxSpeed + " per hour");
        }


    }
}
