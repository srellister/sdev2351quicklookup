using InventoryLookup.Models;

namespace InventoryLookup.Services;

/// <summary>Pre-built fake backend with a small artificial delay so async paths are visible.</summary>
public sealed class InMemoryInventoryService : IInventoryService
{
    private static readonly IReadOnlyList<InventoryItem> Items = new List<InventoryItem>
    {
        new(1,  "CBL-USBC-2M",  "USB-C Cable 2m",            "Cables",      142, 12.99m, "A1-03"),
        new(2,  "CBL-HDMI-1M",  "HDMI 2.1 Cable 1m",         "Cables",        8, 18.50m, "A1-04"),
        new(3,  "MON-27-4K",    "27\" 4K Monitor",           "Displays",     23, 429.00m, "B2-01"),
        new(4,  "MON-24-FHD",   "24\" FHD Monitor",          "Displays",      4, 189.00m, "B2-02"),
        new(5,  "KB-MECH-TKL",  "Mechanical Keyboard TKL",   "Peripherals",  57, 119.00m, "C3-07"),
        new(6,  "MS-WL-ERGO",   "Wireless Ergonomic Mouse",  "Peripherals",  61, 64.99m,  "C3-08"),
        new(7,  "DOCK-TB4",     "Thunderbolt 4 Dock",        "Docks",        12, 289.00m, "B1-05"),
        new(8,  "DOCK-USBC",    "USB-C Travel Dock",         "Docks",         3, 89.00m,  "B1-06"),
        new(9,  "HS-WL-ANC",    "Wireless ANC Headset",      "Audio",        34, 199.00m, "D4-02"),
        new(10, "WEBCAM-1080",  "1080p Webcam",              "Audio",        19, 79.00m,  "D4-03"),
        new(11, "SSD-1TB-NVME", "1TB NVMe SSD",              "Storage",      88, 109.00m, "E5-01"),
        new(12, "SSD-2TB-NVME", "2TB NVMe SSD",              "Storage",       6, 199.00m, "E5-02"),
    };

    public async Task<IReadOnlyList<InventoryItem>> SearchAsync(string query, CancellationToken ct = default)
    {
        await Task.Delay(400, ct); // simulate network
        if (string.IsNullOrWhiteSpace(query)) return Items;

        return Items
            .Where(i => i.Name.Contains(query, StringComparison.OrdinalIgnoreCase)
                     || i.Sku.Contains(query, StringComparison.OrdinalIgnoreCase)
                     || i.Category.Contains(query, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public async Task<InventoryItem?> GetByIdAsync(int id, CancellationToken ct = default)
    {
        await Task.Delay(200, ct);
        return Items.FirstOrDefault(i => i.Id == id);
    }
}
