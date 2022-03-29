﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApplication.Models
{
    public class CartPizza : Pizza
    {
        public int Quantity { get; set; }
        public override string ToString()
        {
            return base.ToString()+
                "\nQuantity Ordered : "+Quantity;
        }
    }
}
