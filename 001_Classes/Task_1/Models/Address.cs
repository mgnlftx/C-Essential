namespace Task_1
{
    internal class Address
    {
        public int Index { get; set; }

        private string country;

        public string Country
        {
            set
            {
                country = value;
            }

            get
            {
                return country;
            }
        }

        private string city;

        public string City
        {
            set
            {
                city = value;
            }

            get
            {
                return city;
            }
        }

        private string street;

        public string Street
        {
            set
            {
                street = value;
            }

            get
            {
                return street;
            }
        }

        private int house;

        public int House
        {
            set
            {
                house = value;
            }

            get
            {
                return house;
            }
        }

        private int apartment;

        public int Apartament
        {
            set
            {
                apartment = value;
            }

            get
            {
                return apartment;
            }
        }
    }
}
