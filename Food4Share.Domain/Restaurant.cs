using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food4Share.Domain
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MenuItem> Menu { get; set; }
        public List<Order> Orders { get; set; }
    }
}
