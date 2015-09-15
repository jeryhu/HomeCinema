using System;
using System.Collections.Generic;

namespace HomeCinema.Entities
{
    public class Stock:IEntityBase
    {
        public int Id { get; set; }

        public Stock()
        {
            Rentals = new List<Rental>();
        }

        public int MovieId { get; set; }
        public Guid UniqueKeyGuid { get; set; }
        public bool IsAvailable { get; set; }

        public virtual ICollection<Rental> Rentals  { get; set; }
    }
}