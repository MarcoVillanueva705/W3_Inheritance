using System;

namespace W3_Inheritance
{
    class Program
    {
        //It is possible to inherit fields and methods from one class to another


        //Base Class (parent) - the class being inherited from
         class Vehicle
         {
            public string make = "Tesla";//Vehicle field
            public void Honk()//Vehicle method
            {
                Console.WriteLine("Honk-Honk!!!");
            }
         }

        //Derived Class (child) - the class that inherits from another class
        //To inherit from a class, use the : symbol.
        class Car : Vehicle
        {
            public string model = "X";//Car field
        }


        static void Main(string[] args)
        {
            //create an instance of a car with variable myCar
            Car myCar = new Car();

            //call the honk() method from the Vehicle class on the myCar object
            myCar.Honk();

            //display the value of the make field from the Vehicle class
            //and the value of the model field from the Car class
            Console.WriteLine(myCar.make + " " + myCar.model);
        }
        //Why And When To Use "Inheritance"?
        //It is useful for code reusability: reuse fields and methods of an 
        //existing class when you create a new class.


    }
}
