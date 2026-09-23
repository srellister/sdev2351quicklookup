using Fluxor;
using InventoryLookup.Models;

namespace InventoryLookup.Store.Inventory;

// ============================================================================
// TASK 2 (≈3 min): Actions
// ----------------------------------------------------------------------------
// Actions are plain immutable messages -- records are perfect.
//
//   SearchAction  carries the Query string AND the Results the component
//                 already fetched from IInventoryService. (No effects today:
//                 the component does the async call, then dispatches.)
//
//   ClearAction   carries nothing; it resets the slice.
// ============================================================================

// TODO 2: public sealed record SearchAction(...);
// TODO 2: public sealed record ClearAction;
public sealed record SearchAction(string Query, IReadOnlyList<InventoryItem> Results);
public sealed record ClearAction;
 