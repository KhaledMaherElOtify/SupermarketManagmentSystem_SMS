﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagmentSystem_SMS.Models
{
    public class SaleItem
    {
        [Key]
        public int SaleItemID { get; set; }

        // Foreign Keys
        public int SaleId { get; set; }
        public int ProductId { get; set; }

        // Fields
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitPrice { get; set; }

        // Navigation
        public Sale Sale { get; set; }
        public Product Product { get; set; } 
    }
}
