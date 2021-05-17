using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{
    public enum GenreType
    {
        Action,
        Adventure,
        Shooter,
        RolePlayingGames,
        Racing,
        Sport,
        Fighting,
        Consoles,
        Accessories
    }
    public class Product
    {
        public int Id { get; set; }


        [DataType(DataType.ImageUrl)]
        public String Image { get; set; }

        public String Name { get; set; }

        [Display(Name = "Date Of Release")]
        public String DateOfRelease { get; set; }

        [DataType(DataType.Currency)]
        public float Price { get; set; }

        public int Quantity { get; set; }

        public GenreType Genre { get; set; }

        public String Description { get; set; }

        public String Trailer { get; set; }

        public String Consoles { get; set; }
    }
}
