using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DrinkExample_Feb7
{
    class Program : ICoffee, ITea
    {
        //MethodOverriding 
        public void Show()
        {
            Console.WriteLine("All Tea Details are");
        }

        //Polymorphism with Method Overloading 
        //public static int printCoffeeDetails(int numberOfCoffees, int cost)
        //{
        //    return numberOfCoffees * cost;
        //}

        //public static int printCoffeeDetails(int price, int quantity, int extracharges)
        //{
        //    return extracharges + quantity * price;
        //} 
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Cost();
            program.Type();
            program.Color();
            program.Taste();
            Console.WriteLine();

            Console.WriteLine("With Polymorphism is: ");
            CoffeeProperties coffee= new CoffeeProperties();
            Console.WriteLine("The Cost is : " + coffee.printCoffeeDetails(2, 150));
            Console.WriteLine("The Cost with GST is: " + coffee.printCoffeeDetails(150, 3, 100));

            Console.WriteLine();
            Child child = new Child();
            child.Show();

            try
            {
                var drinks = new List<string>();
                drinks.Add("Capichuno");
                drinks.Add("Lemon Tea");
                drinks.Add("Green Tea");
                drinks.Add("Strong Coffee");
                Console.WriteLine();
                Console.WriteLine("Various Types are:");
                foreach (var drink in drinks)
                {
                    Console.WriteLine(drink);

                 }
            }
            catch (IndexOutOfRangeException index)
            {
                Console.WriteLine(index.Message);
            }
            catch (ArgumentException argex)
            {
                Console.WriteLine(argex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

    

        public void Cost()
        {
            Console.WriteLine("Tea Cost ");
        }
    

        public void Taste()
        {
            Console.WriteLine("Coffee taste is good"); 

        }

        public void Type()
        {
            Console.WriteLine("Strong Coffee"); 
        }

        public void Color()
        {
            Console.WriteLine("Tea Color"); 
        }
    }
}
