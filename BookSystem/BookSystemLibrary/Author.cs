using System.Text.RegularExpressions;

namespace BookSystemLibraryEx1
{
    public class Author
    {
        #region Data Members

        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private string _ContactUrl = string.Empty;
        private string _ResidentCity = string.Empty;
        private string _ResidentCountry = string.Empty;
        #endregion

        #region Properties
        public string FirstName
        {
            get => _FirstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("FirstName is required.");
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
                    throw new ArgumentException("LastName is required.");
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
                    throw new ArgumentException("ContactUrl is required.");
                }

                string pattern = @"^(https?://www\.)?[a-zA-Z0-9]+\.\w{2,}(?!\.)";
                if (!Regex.IsMatch(value.Trim(), pattern))
                {
                    throw new ArgumentException("ContactUrl does not match the acceptable URL pattern.");
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
                    throw new ArgumentException("ResidentCity is required.");
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
                    throw new ArgumentException("ResidentCountry is required.");
                }
                _ResidentCountry = value.Trim();
            }
        }


        // Read-Only properties not to store data.
        public string AuthorName
        {
            get => $"{LastName}, {FirstName}";
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

        // Return a comma-separated value string with no spaces
        #region Methods
        public override string ToString()
        {
            return $"{FirstName},{LastName},{ContactUrl},{ResidentCity},{ResidentCountry}";
        }
        #endregion
    }
}
