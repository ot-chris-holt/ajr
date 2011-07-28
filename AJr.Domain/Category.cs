using System;

namespace AJr.Domain
{
    public class Category
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime CreatedOn { get; set; } 
    }
}
