using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public class ShoppingCart
    {

        public int Id { get; set; }

        public List<Product> Products { get; set; }

        [Display(Name = "Total Price")]
        [DataType(DataType.Currency)]
        public float TotalPrice { get; set; }
    }
}
