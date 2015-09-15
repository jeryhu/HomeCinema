using System.Collections.Generic;

namespace HomeCinema.Entities
{
    public class Genre : IEntityBase
    {
        public Genre()
        {
            Movies = new List<Movie>();
        }

        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public int Id { get; set; }
    }
}