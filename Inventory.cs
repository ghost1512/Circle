public class Inventory
{
    List<Item> myItem = new List<Item>();
    public Inventory()
    {
        Item item1 = new Item();
        Item.itemName = "Sw";
        Item.attack = 10;
        Item.health = 15;
        myItem.Add(item1);

        Item item2 = new Item();
        Item.itemName = "Bow";
        Item.attack = 20;
        Item.health = 5;
        myItem.Add(item2);

        Item item3 = new Item();
        Item.itemName = "Shield";
        Item.attack = 5;
        Item.health = 50;
        myItem.Add(item3);
    }
}