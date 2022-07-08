using CarFile;
using Class2;
using Constructor;


Console.WriteLine("Hello, World!");
Console.WriteLine("HWLOOO");
Console.WriteLine(3 + 4);

//Write() is same like Writeline() the only diff is write() doent insert new line eg 

Console.Write("Hello, World!");
Console.Write("HWLOOO");
Console.Write(3 + 4);

Console.WriteLine(3 * 2);

//  specify the type of var 
int num = 10;
Console.WriteLine(num + num);

// if you dont want the value to get overwrite or change add const

const string str = "shrey";
Console.WriteLine(str);

// STRING AND VALUE  and string+ string 

const string one = "shreya";

Console.WriteLine("Hello" + one);

// vars of same type can be defined as int x=3,y=0,z=2


// Type casting is when you assign a value of one data type to another type.


/*Implicit Casting (automatically) - converting a smaller type to a larger type size
char -> int -> long -> float -> double*/

/*  Explicit Casting (manually) - converting a larger type to a smaller size type
double -> float -> long -> int -> char      */


// implicit casting :

int num2 = 10;
double num3 = num2;
Console.WriteLine(num2);
Console.WriteLine(num3);


//Explicit casting :

// Explicit casting must be done manually by placing the type in parentheses in front of the value:

double myDouble = 9.78;
int myInt = (int)myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble);   // Outputs 9.78
Console.WriteLine(myInt + "is my int");


// It is also possible to convert data types explicitly:

int InT = 20;



Console.WriteLine(Convert.ToString(InT));


Console.WriteLine(Math.Max(5, 10));
Math.Min(5, 10);
Console.WriteLine(Math.Sqrt(64));
Console.WriteLine(Math.Abs(-8));
Console.WriteLine(Math.Round(9.99));







string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
Console.WriteLine(cars[0]);
// Outputs Volvo

// TO GET USER INPUT  // console.readline is only for string for taking other datatype mention it 

Console.WriteLine("hey wht is your name : ");

var userName = Console.ReadLine();

Console.WriteLine("hey wht is your age : ");

// since convert to data type 
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("hello " + userName + " we just got to know you are " + age + " years old " + "and you are born in " + (2022 - age - 1) + (age < 20 ? " and you are still young >.<" : " and you are oldie!!!"));
// calling car 
Car newCar = new Car();

Console.WriteLine(newCar.color);
//
newCar.Shout();


// class2

myClass newClass = new myClass();

newClass.method1();

// 
Constructort newC = new Constructort();

Console.WriteLine(newC.model);


