using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fa.Model.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        
        public string CategoryName { get; set; }

        public virtual IEnumerable<Book> Books { get; set; }
    }
}
