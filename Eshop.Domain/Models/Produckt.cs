using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Domain.Models
{
    public class Produckt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { private set; get; }

        public Supplier Supplier { get; set; }

        public string PhotoUrl { get; set; }

    }
}
