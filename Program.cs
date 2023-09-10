// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Text.Json;
using Pet_Store;
var productLogic = new ProductLogic(); // create new instance of ProductLogic
string userInput = "7";


do
{
    Console.WriteLine("Press 1 to add a product");
    Console.WriteLine("Type ‘exit’ to quit");
    userInput = Console.ReadLine();

    if (userInput == "1")// userInput = 1 <- assignment
    {
        CatFood MeowMix = new CatFood();// new instance of CatFood class

        Console.WriteLine("What is the name of the Cat Food?");// Console.WriteLine () <- requesting the input to print to the screen
        string name = Console.ReadLine(); // Name is stored in a value; getting input from the user
        MeowMix.Name = name; //input user provided stored as str Name above,

        Console.WriteLine("How much is the cat food?");
        decimal price = decimal.Parse(Console.ReadLine());
        MeowMix.Price = price;

        Console.WriteLine("How many bags of cat food do we have in store?");
        int quantity = int.Parse(Console.ReadLine());
        MeowMix.Quantity = quantity;

        Console.WriteLine("What does the bag look like?");
        string description = Console.ReadLine();
        MeowMix.Description = description;

        Console.WriteLine("How much does the bag weigh in pounds?");
        double weight = double.Parse(Console.ReadLine());
        MeowMix.WeightPounds = weight;

        Console.WriteLine("Is this ok for kittens to eat?");
        Console.WriteLine("Type 'yes' for yes or 'no' for no.");
        string KittenEdible = Console.ReadLine();
        MeowMix.KittenFood = KittenEdible.ToLower() == "yes";// assigning property to result of comparison 

        void AddProduct(Product product) // (argumentType argument) = addproduct method 
        {
            //_products.Add(product); // add product to the Product List
        }
        Console.WriteLine($" Product was added!");


    }



}
while (userInput.ToLower() != "exit"); // do between 11-24 until not true


//AddProduct();
//Console.ReadLine() <- default output is a str
/*
 

 */