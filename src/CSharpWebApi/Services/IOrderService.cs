namespace CSharpWebApi.Services;

public interface IOrderService
{
    decimal CalculateTotal(int quantity, decimal unitPrice, decimal discountPct);
    bool IsEligibleForFreeShipping(decimal orderTotal);
}
