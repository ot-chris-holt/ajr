using System;

namespace AJr.Domain
{
    public class Review
    {
        public virtual Guid Id { get; set; }
        public virtual Guid CustomerId { get; set; }
        public virtual Guid ProductId { get; set; }
        public virtual string ReviewText { get; set; }
        public virtual int GivenRating { get; set; }
        public virtual DateTime CreatedOn { get; set; }
    }
}
