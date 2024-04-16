internal class Program
{
    private static void Main(string[] args)
    {
        Circles myCircle = new Circles(12);
        Console.WriteLine($"Dien tich duong tron: {myCircle.Area}");
        Console.WriteLine($"Chu vi duong tron: {myCircle.PermeteCircle}");

        Inventory myIventory = new Inventory();

        foreach (var Item in myIventory.myItem)
        {
            Console.Write(Item.itemName + ",");
            Console.Write(Item.attack + ",");
            Console.Write(Item.health + ",");
        }
    }
}