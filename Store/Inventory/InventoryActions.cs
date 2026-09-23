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

// TODO: public sealed record SearchAction(...);
// TODO: public sealed record ClearAction;
