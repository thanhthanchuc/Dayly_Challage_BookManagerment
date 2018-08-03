using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Fa.Model.Model
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string History { get; set; }

        public virtual  IEnumerable<Book> Books { get; set; }
    }
}