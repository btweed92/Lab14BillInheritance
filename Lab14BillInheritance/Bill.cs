﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14BillInheritance
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill()
        {

        }
        public Bill(double subtotal, double taxRate)
        {

        }

        public virtual double CalcTotal()
        {
            double total = (Subtotal * (1 + TaxRate));
            return total;
        }
    }
}
