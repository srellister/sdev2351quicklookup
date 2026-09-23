using InventoryLookup.Models;

namespace InventoryLookup.Services;

/// <summary>Pre-built. Call this directly from your component (no Fluxor effects today).</summary>
public interface IInventoryService
{
    Task<IReadOnlyList<InventoryItem>> SearchAsync(string query, CancellationToken ct = default);
    Task<InventoryItem?> GetByIdAsync(int id, CancellationToken ct = default);
}
