using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BookSystemLibraryEx1
{
    public class Reviewer
    {
        #region
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private string _Organization;

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

        public string Email
        {
            get => _Email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !IsValidEmail(value))
                {
                    throw new ArgumentException("Email must be a valid email address.");
                }
                _Email = value.Trim();
            }
        }

        public string Organization
        {
            get => _Organization;
            set => _Organization = value?.Trim();  // Optional, null allowed
        }

        // Read-Only property that builds from FirstName and LastName
        public string FullName
        {
            get => $"{FirstName} {LastName}";
        }

        #endregion

        #region Constructor
        public Reviewer(string firstName, string lastName, string email, string organization = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Organization = organization;
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {Email}, {Organization ?? "Independent"}";
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w.-]+@[\w.-]+\.\w{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        #endregion
    }
}
