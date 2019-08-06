using System;

namespace Lab14BillInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill()
            {
                Subtotal = 15.80,
                TaxRate = 0.06
            };

            Pay(bill);

            TippableBill bill2 = new TippableBill()
            {
                Subtotal = 8.50,
                TaxRate = 0.06,
                Tip = 2.00
            };

            Pay(bill2);
        }
        public static void Pay(Bill bill)
        {
            Console.WriteLine($"${bill.CalcTotal()}");
            
        }
    }
}
