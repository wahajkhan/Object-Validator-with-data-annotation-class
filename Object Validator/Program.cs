using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();


            cat = new Cat()
            {
                id = 1,
                age = 5
            };

            var validator = new Validate();

            var result = validator.ObjValidate(cat);

            Console.WriteLine(result.IsValid ? "Valid" : "Invalid");

            foreach ( var error in result.Errors)
            {
                Console.WriteLine(error.Key);
                foreach (var errorMessage in error.Value)
                {
                    Console.WriteLine($"----{errorMessage}");
                }
            }

            Console.ReadKey();


        }
    }
}
