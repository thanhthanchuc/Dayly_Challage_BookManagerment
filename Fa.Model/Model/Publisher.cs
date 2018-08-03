using System.ComponentModel.DataAnnotations;

namespace Fa.Model.Model
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}