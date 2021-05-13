using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameShop.Models
{

    public class Console
    {
        public int Id { get; set; }

        public int ConsoleId { get; set; }
        public List<Product> Games { get; set; }

        public List<Product> Consoles { get; set; }

        public List<Product> Accessories { get; set; }

        public ConsoleType Type { get; set; }
    }
}
