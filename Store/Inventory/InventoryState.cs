using Fluxor;
using InventoryLookup.Models;

namespace InventoryLookup.Store.Inventory;

// ============================================================================
// TASK 1 (≈4 min): State
// ----------------------------------------------------------------------------
// Turn this into a Fluxor feature state:
//   • Decorate it with [FeatureState] so Fluxor discovers and registers it.
//   • Make it an immutable record.
//   • Add three init-only properties with sensible defaults:
//       string                      Query        -> ""
//       IReadOnlyList<InventoryItem> Results     -> empty
//       bool                        HasSearched  -> false
//   • Fluxor needs a parameterless constructor (the implicit one is fine).
// ============================================================================
[FeatureState]
public sealed record InventoryState
{
    // TODO 1
    public bool HasSearched {get; init;} = false;

    public string Query {get; init;} = string.Empty;

    public IReadOnlyList<InventoryItem> Results {get; init; } = [];
}
