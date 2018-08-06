using System;
using System.ComponentModel.DataAnnotations;

namespace Fa.Model.Model
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public string Status { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Phone]
        public int Phone { get; set; }
    }
}