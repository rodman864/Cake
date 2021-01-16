using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using CS_133_Projects.GenericClasses;


namespace CS_133_Projects

{
    class Program
    {
        static void Main(string[] args)
        {

            TypeOfCake GenericClasses = new TypeOfCake();

            

            List<TypeOfCake> myObject = new List<TypeOfCake>();

            TypeOfCake firstCake = new TypeOfCake();
            firstCake.Type = "Wedding";
            firstCake.Flavor = "Vanilla";

            TypeOfCake secondCake = new TypeOfCake();
            secondCake.Type = "Birthday Cake";
            secondCake.Flavor = "Chocolate";

            
            

            myObject.Add(firstCake);
            myObject.Add(secondCake);


            TypeOfCake myCakeObject = myObject.First();
            

     

            Console.WriteLine(myCakeObject.Type);
            Console.WriteLine(myCakeObject.Flavor);

           
            
         

        }

        
    }
}
