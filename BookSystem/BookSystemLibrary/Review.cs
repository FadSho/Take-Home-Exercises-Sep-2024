using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSystem
{
    public class Review
    {
        #region Data Members
        private string _ISBN = string.Empty;
        private string _Comment = string.Empty;
        private Reviewer _Reviewer ;

        #endregion

        #region Properties
        public string ISBN
        {
            get => _ISBN;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ISBN must be provided.");
                }
                _ISBN = value.Trim();
            }
        }

        public Reviewer Reviewer
        {
            get => _Reviewer;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Reviewer must be provided.");
                }
                _Reviewer = value;
            }
        }

        public RatingType Rating { get; set; }  // No validation needed for the enum

        public string Comment
        {
            get => _Comment;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Comment must be provided.");
                }
                _Comment = value.Trim();
            }
        }

        #endregion

        #region Constructor
        public Review(string isbn, Reviewer reviewer, RatingType rating, string comment)
        {
            ISBN = isbn;            
            Reviewer = reviewer;    
            Rating = rating;       
            Comment = comment;    
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{ISBN}, {Reviewer.ReviewerName}, {Rating}, {Comment}";
        }
        #endregion
    }
}
