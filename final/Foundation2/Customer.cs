 class Customer
    {
        private string name;
        private Address address;

        public string Name { get { return name; } }
        public Address Address { get { return address; } }

        public Customer(string name, Address address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetAddressString()
        {
            return address.ToString();
        }
    }