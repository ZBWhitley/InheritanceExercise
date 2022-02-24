using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
             * Creatively display the class member values 
             */
            var b1 = new Bird();
            
            b1.Genus = "Aves";
            b1.Species = "Cardinal";
            b1.Name = "Roger";
            b1.Sex = 'M';            
            b1.Color = "Red, Black";
            b1.WingSpan = "10 inches";
            b1.Weight = "2.05 OZ";
            b1.Migratory = "Is Migratory";
                                    

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var r1 = new Reptile();
            r1.Genus = "Agkistrodon piscivorus";
            r1.Species = "Cottonmouth, Water Moccasin";
            r1.Name = "Slim";
            r1.Sex = 'M';                     
            r1.Color = "Dark Brown";
            r1.Length = "30 Inches";
            r1.NativeTo = "Southeastern US";
            r1.Diet = "Carnivorous";






            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(b1))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(b1);
                Console.WriteLine("{0}={1}", name, value);
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(r1))
            {
                string name = descriptor.Name;
                object value = descriptor.GetValue(r1);
                Console.WriteLine("{0}={1}", name, value);
            }

        }
    }
}
