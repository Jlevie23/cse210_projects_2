class Program
    {
        static void Main(string[] args)
        {
            // Create customers
            Address address1 = new Address("123 Main St", "City", "State", "Country");
            Customer customer1 = new Customer("John Doe", address1);

            Address address2 = new Address("456 Elm St", "City", "State", "USA");
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create products
            Product product1 = new Product("Product 1", "P001", 10.99m, 2);
            Product product2 = new Product("Product 2", "P002", 5.99m, 3);
            Product product3 = new Product("Product 3", "P003", 7.49m, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product2);
            order2.AddProduct(product3);

            // Display packing label, shipping label, and total price for each order
            Console.WriteLine("Order 1:");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

            Console.WriteLine();

            Console.WriteLine("Order 2:");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());
        }
    }