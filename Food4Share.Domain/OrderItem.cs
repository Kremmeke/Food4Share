﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food4Share.Domain
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}
