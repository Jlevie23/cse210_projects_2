class Order
    {
        private List<Product> products;
        private Customer customer;

        public Order(Customer customer)
        {
            this.customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price * product.Quantity;
            }

            // Add shipping cost
            if (customer.Address.IsInUSA())
            {
                totalPrice += 5.0m;
            }
            else
            {
                totalPrice += 35.0m;
            }

            return totalPrice;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (Product product in products)
            {
                packingLabel += $"Product: {product.Name}, Product ID: {product.ProductId}\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return "Shipping Label:\n" + customer.GetAddressString();
        }
    }