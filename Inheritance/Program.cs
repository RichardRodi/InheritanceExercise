using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             *
             * Creatively display the class member values 
             */
            var pelican = new Bird();
            pelican.Genus = "Pelecanus";
            pelican.Weight = 22;
            pelican.Habitat = "Fresh Water Marshes";
            pelican.DeadorAlive = true;
            pelican.BirdName = "Pelican";
            pelican.BeakSize = 16;
            pelican.FeatherColor = "White";
            pelican.WingSpan = 11;

            Console.WriteLine($"The Genus of a Pelican is {pelican.Genus}. It usually weighs {pelican.Weight} lbs, " +
                $"Its Habitat is {pelican.Habitat}. This pelican is alive: {pelican.DeadorAlive}. The name of this bird is {pelican.BirdName} and its beaksize is {pelican.BeakSize} inches." +
                $" Its Feather Color is {pelican.FeatherColor} and its wingspan is over {pelican.WingSpan} feet.\n");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var salamander = new Reptile();
            salamander.Genus = " Urodela";
            salamander.Weight = 20;
            salamander.Habitat = "Forests/woodlands";
            salamander.DeadorAlive = true;
            salamander.ReptileName = "Salamnder";
            salamander.ScaleColor = "Orange";
            salamander.ScaleShape = "Oval or Rounded";
            salamander.TongueSize = 3;
            Console.WriteLine($"The Genus of a Salamnder is {salamander.Genus}. It usually weighs {salamander.Weight} lbs, " +
                $"Its Habitat is {salamander.Habitat}. This salamander is alive: {salamander.DeadorAlive}. This reptile is called a {salamander.ReptileName}. " +
                $"Its scale color is {salamander.ScaleColor} and its shape is {salamander.ScaleShape}. It's tongue size is {salamander.TongueSize} centimeters");

        }
    }
    }
