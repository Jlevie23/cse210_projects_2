class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public bool IsInUSA()
        {
            return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"Street Address: {streetAddress}\nCity: {city}\nState/Province: {stateProvince}\nCountry: {country}";
        }
    }








