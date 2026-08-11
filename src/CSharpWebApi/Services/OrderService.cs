namespace CSharpWebApi.Services;

public sealed class OrderService : IOrderService
{
    public decimal CalculateTotal(int quantity, decimal unitPrice, decimal discountPct)
    {
        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be positive.", nameof(quantity));
        }

        var subtotal = quantity * unitPrice;
        var discount = subtotal * (discountPct / 100m);
        return subtotal - discount;
    }

    public bool IsEligibleForFreeShipping(decimal orderTotal) => orderTotal >= 50m;
}
