public class ShoppingCart
{
    public List<GroupedShopItem> Groceries = [];

    public void AddItem(ShopItem item)
    {
        GroupedShopItem groupedItem = new(item);
        Groceries.Add(groupedItem);
    }

    public GroupedShopItem? FindItem(ShopItem item)
    {
        foreach(GroupedShopItem grocerie in Groceries)
        {
            if(grocerie.Item.ID == item.ID)
            {
                return new(item);
            }
        }
        return null;
    }

    public string GetContentsOverview()
    {
        string overview = "";
        foreach(GroupedShopItem grocerie in Groceries)
        {
            overview += $"{grocerie.Item.Name} x {grocerie.Quantity}\n";
        }
        return overview;
    }

    public double GetTotalPrice()
    {
        double amount = 0;
        foreach(GroupedShopItem grocerie in Groceries)
        {
            amount += grocerie.Item.Price * grocerie.Quantity;
        }
        return amount;
    }
}