using System;
using System.Runtime.ConstrainedExecution;


namespace Pet_Store

{
    public class Product
    {
        //properties
        public string Name { get; set; /*sets fields in background*/}

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string Description { get; set; }
    }
    // classes are types; variable have type; line 11 str could make str of catfood


    class CatFood : Product
    {
        public double WeightPounds
        { get; set; }

        public bool KittenFood
        { get; set; }
    }

    class DogLeash : Product
    {
        public int LengthInches
        { get; set; }

        public string Material
        { get; set; }
    }

    class ProductLogic
    {
        private List<Product> _products;

        public ProductLogic() // Constructor
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product) // (argumentType argument)
        {
            _products.Add(product); // add product to the Product List
        }

        List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}

/* Add a product -> create object -> print to console; going to need Parse methods
Console.Write() - get input
Console.ReadLine() - add input to object 
*/
/* Where does this while loop go?
 


*/