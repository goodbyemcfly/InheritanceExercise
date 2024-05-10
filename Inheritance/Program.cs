using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal 

            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class




            /* DONE Create an object of your Bird class
             * give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var penguin = new Bird();

            penguin.Name = "penguin";
            penguin.CanFly = false;
            penguin.Diet = "fish";
            penguin.WingSpan = 76;

            Console.WriteLine("Hello! Today we will be learning about two differnt animals.");
            Console.WriteLine($"First up we have my favorite type of bird, the {penguin.Name}!");
            Console.WriteLine($"A {penguin.Name}'s wingspan can get up to {penguin.WingSpan}cm long, but since they are unable to fly they use these wings to help them swim underwater.");
            Console.WriteLine($"To the despair of children everywhere, despite their portrayal in the 2007 children's movie 'Surf's Up', {penguin.Name}s cannot surf.");
            Console.WriteLine($"However, since they spend most of their time near in water and often live in frigid environments, their main diet consists of {penguin.Diet}");
            Console.WriteLine("We hope you enjoyed learning about penguins. We wish that they could surf too.");




            /* DONE Create an object of your Reptile class
             * give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var alligator = new Reptile();

            alligator.Name = "Alligator";
            alligator.CanSwim = true;
            alligator.MaxSize = 15;
            alligator.IsPoisonous = false;

            Console.WriteLine($"Next we have the {alligator.Name}");
            Console.WriteLine($"The largest {alligator.Name} ever recorded clocked in at over {alligator.MaxSize} feet long!");
            Console.WriteLine($"These animals are often confused with crocodiles and to be honest I didn't google the difference between them before making this, so I can't help with that.");
            Console.WriteLine($"However, both crocodiles and {alligator.Name}s are considered vary dangerous and should be avoided unless your name is Steve Erwin.");
        }
    }
}
