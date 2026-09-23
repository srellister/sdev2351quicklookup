using Fluxor;

namespace InventoryLookup.Store.Inventory;

// ============================================================================
// TASK 3 (≈5 min): Reducer
// ----------------------------------------------------------------------------
// Reducers are pure static functions: (state, action) -> new state.
//
//   [ReducerMethod]
//   public static InventoryState OnSearch(InventoryState state, SearchAction action)
//       -> copy state `with` Query, Results and HasSearched = true
//
//   [ReducerMethod(typeof(ClearAction))]
//   public static InventoryState OnClear(InventoryState state)
//       -> return a brand-new InventoryState()
//
// Never mutate `state` -- always return a new instance.
// ============================================================================
public static class InventoryReducers
{
    // TODO
}
