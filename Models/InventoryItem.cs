namespace InventoryLookup.Models;

/// <summary>A single stock-keeping unit in the warehouse. Pre-built -- do not edit.</summary>
public sealed record InventoryItem(
    int Id,
    string Sku,
    string Name,
    string Category,
    int QuantityOnHand,
    decimal UnitPrice,
    string Location)
{
    public bool IsLowStock => QuantityOnHand < 10;
}
