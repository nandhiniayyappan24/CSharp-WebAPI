using System;

namespace CSharpWebApi.Services
{
    public static class RetailOrderProcessor
    {
        public static decimal ProcessOrder(int quantity, decimal unitPrice, decimal discountPct)
        {
            if (quantity <= 0) throw new ArgumentException("quantity must be positive");
            var subtotal = quantity * unitPrice;
            var discount = subtotal * (discountPct / 100m);
            var total = subtotal - discount;
            var tax = total * 0.08m;
            return total + tax;
        }
    }
}
