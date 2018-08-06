﻿using System.ComponentModel.DataAnnotations;

namespace Fa.Model.Model
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        public Book Book { get; set; }

        [Required]
        public int OrderId { get; set; }

        public Order Order { get; set; }

        [Required]
        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}