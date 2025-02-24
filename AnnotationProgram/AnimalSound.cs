using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations; // Import for Data Annotations
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProgram
{
        internal class Animal
        {
            // Name is required and should not exceed 50 characters
            [Required(ErrorMessage = "Animal name is required")]
            [StringLength(50, ErrorMessage = "Animal name cannot exceed 50 characters")]
            public string Name { get; set; }

            // Species is a required field
            [Required(ErrorMessage = "Species is required")]
            public string Species { get; set; }

            // Age must be between 0 and 100
            [Range(0, 100, ErrorMessage = "Age must be between 0 and 100")]
            public int Age { get; set; }

            // Virtual method to allow method overriding
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound.");
            }
        }

        // Derived class: Dog (inherits from Animal)
        public class Dog : Animal
        {
            // Breed is a required property
            [Required(ErrorMessage = "Breed is required")]
            public string Breed { get; set; }

            // Overriding the MakeSound() method to provide Dog-specific behavior
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks: Woof! Woof!");
            }
        }

        class AnimalSound
        {
            static void Main()
            {
                // Creating an instance of Dog with invalid data to demonstrate validation
                Dog myDog = new Dog
                {
                    Name = "",  // Invalid: Name is required
                    Species = "",  // Invalid: Species is required
                    Age = 120,  // Invalid: Age is out of range (must be 0-100)
                    Breed = ""  // Invalid: Breed is required
                };

                // Call method to validate and display errors
                ValidateAnimal(myDog);
            }

            static void ValidateAnimal(object obj)
            {
                var validationResults = new List<ValidationResult>();
                var validationContext = new ValidationContext(obj);
                bool isValid = Validator.TryValidateObject(obj, validationContext, validationResults, true);

                if (!isValid)
                {
                    Console.WriteLine("Validation Errors:");
                    foreach (var error in validationResults)
                    {
                        Console.WriteLine($"- {error.ErrorMessage}");
                    }
                }
                else
                {
                    // If valid, call the overridden MakeSound() method
                    if (obj is Animal animal)
                    {
                        animal.MakeSound();
                    }
                }
            }
        }
    }


}
