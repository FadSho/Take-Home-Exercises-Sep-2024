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
        #region Data Members
        private string _FirstName = string.Empty;
        private string _LastName = string.Empty;
        private string _Email = string.Empty;
        private string? _Organization = string.Empty;
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
                string pattern = @"^[\w.-]+@[\w.-]+\.\w{2,}$";
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value.Trim(), pattern))
                    throw new ArgumentException("Email must be a valid email address.");
                _Email = value.Trim();
            }
        }

        public string? Organization
        {
            get => _Organization;
            set => _Organization = value?.Trim() ?? null;
        }

        // Property that combines FirstName and LastName
        public string ReviewerName
        {
            get => $"{FirstName} {LastName}";
        }

        #endregion

        #region Constructor
        public Reviewer(string firstName, string lastName, string email, string? organization = null)
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

        #endregion
    }
}