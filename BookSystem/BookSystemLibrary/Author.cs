namespace BookSystemLibrary
{
    public class Author
    {
        #region Data Members

        private string _FirstName;
        private string _LastName;
        private string _ContactUrl;
        private string _ResidentCity;
        private string _ResidentCountry;
        #endregion

        #region Properties
        public string FirstName
        {
            get => _FirstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName must be provided.");
                }
                _FirstName = value.Trim();
            }
        }

        public string LastName
        {
            get => _LastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LastName must be provided.");
                }
                _LastName = value.Trim();
            }
        }

        public string ContactUrl
        {
            get => _ContactUrl;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ContactUrl should be the web site of the author.");
                }
                _ContactUrl = value.Trim();
            }
        }

        public string ResidentCity
        {
            get => _ResidentCity;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ResidentCity should be current city author is residing.");
                }
                _ResidentCity = value.Trim();
            }
        }

        public string ResidentCountry
        {
            get => _ResidentCountry;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ResidentCountry should be current city author is residing.");
                }
                _ResidentCountry = value.Trim();
            }
        }


        // Read-Only properties not to store data.
        public string AuthorName
        {
            get => $"{FirstName} {LastName}";
        }
        #endregion

        #region Constructors
        public Author(string firstname, string lastname, string contacturl, string city, string country)
        {
            FirstName = firstname;
            LastName = lastname;
            ContactUrl = contacturl;
            ResidentCity = city;
            ResidentCountry = country;
        }
        #endregion

        // Return a comma-separated value string
        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {ContactUrl}, {ResidentCity}, {ResidentCountry}";
        }
    }
}
