

namespace Constructor

{
    class Constructort
    {
        public string model;  // Create a field
        private string models = "Private shit";


        public Constructort() // constructor
        {
           model = "Mustang"; // Set the initial value for model
        }
         public void Main(string[] args)
        {
            Constructort someThing = new Constructort();  // Create an object of the  Constructor_trial Class (this will call the constructor)
            Console.WriteLine(someThing.model);  // Print the value of model
            Console.WriteLine(someThing.models);
        }
    }
    }


