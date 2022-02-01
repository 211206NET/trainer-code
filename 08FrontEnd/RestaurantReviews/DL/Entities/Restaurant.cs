using System;
using System.Collections.Generic;

namespace DL.Entities
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? City { get; set; }
        public string? State { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}
