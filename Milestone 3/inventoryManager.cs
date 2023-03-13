/*
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * This program was written by Scott Maxwell for the Milestone Project in CST-150.
 * This is my own original work.
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 */

using Inventory;

class InventoryManager
{

    // Dictates size of array
    int inventorySize;

    // Tracks first open spot in array
    int count;

    // Array that holds inventoryItems
    InventoryItem[] inventoryList;

    // Constructor
    public InventoryManager(int initialSize = 10)
    {
        inventorySize = initialSize;
        inventoryList = new InventoryItem[inventorySize];
        count = 0;
    }

    // Adds items to inventoryList
    public void add(InventoryItem item)
    {
        if (count >= inventorySize)
        {
            // Double inventorySize
            inventorySize *= 2;
            Array.Resize(ref inventoryList, inventorySize);
        }
        inventoryList[count] = item;
        count++;
    }

    // Removes items from inventoryList
    public void remove(int itemIndex)
    {

        // Shift all values in the array right of the removed value left
        for (int index = itemIndex; index < inventoryList.Length-1; index++)
        {
            inventoryList[index] = inventoryList[index + 1];
        }

        // Decrease the count of items in array
        count--;

        // Resize Array to be smaller if only using 1/4 of it.
        if ((double)count / ((double)inventorySize) <= (1.0 / 4.0))
        {
            inventorySize /= 2;
            
            Array.Resize(ref inventoryList, inventorySize);
        }
        
    }

    // Adds QTY to a paticular item in inventoryList
    public void restock(int itemIndex, int qtyIncrease)
    {
        int currentQTY = inventoryList[itemIndex].quantity;
        inventoryList[itemIndex].modifyQuantity(currentQTY + qtyIncrease);
    }

    // Shows items in inventoryList
    public void display()
    {
        Console.Write("[");
        for (int index = 0; index < count; index++)
        {
            if(index+1 == count)
            {
                Console.Write(inventoryList[index].itemName);
            }
            else
            {
                Console.Write(inventoryList[index].itemName + ",");
            }
            
        }
        Console.Write("]\n\n");
    }

    // Returns a list of items that match provided params
    public List<InventoryItem> search(string? name = null, int? qty = null, string? deviceType = null)
    {


        // List to store matches
        List<InventoryItem> matchesQuery = new List<InventoryItem>();

        // Loop over inventoryList to find matches
        for (int index = 0; index < count; index++)
        {

            InventoryItem item = inventoryList[index];

            // Used to record match or a non-match
            bool matches = false;

            // If parameter was specified
            if (name != null)
            {
                if (item.itemName == name)
                {
                    matches = true;
                }
                else
                {
                    matches = false;
                }

            }

            // If parameter was specified
            if (qty != null)
            {
                if (item.quantity == qty)
                {
                    matches = true;
                }
                else
                {
                    matches = false;
                }
            }

            // If parameter was specified
            if (deviceType != null)
            {
                if (item.deviceType == deviceType)
                {
                    matches = true;
                }
                else
                {
                    matches = false;
                }
            }

            if (matches)
            {
                matchesQuery.Add(item);
            }
        }

        return matchesQuery;
    }

    public override string ToString()
    {
        return $"\n# of Items:{this.count}\nSize of Array: {this.inventorySize}";
    }

    // Driver
    public static void Main(string[] args)
    {

        // Unit tests 

        // Create object from InventoryManager Class
        InventoryManager inventoryManager = new InventoryManager();

        // Create several different Items and add them to the inventoryManager object
        for(int count=1; count <= 12; count++)
        {
            InventoryItem item = new InventoryItem();
            item.itemName = $"item{count}";
            item.deviceType = "Laptop";
            item.quantity = 30;

            // Test add method
            inventoryManager.add(item);
        }

        Console.WriteLine("\n===================================================\n");

        // Test display method
        Console.WriteLine("@TEST: display & add methods\n");
        inventoryManager.display();

        Console.WriteLine("\n===================================================\n");

        // Test remove method
        Console.WriteLine("@TEST: remove method");
        Console.WriteLine("\ninventoryManager before remove: ");
        inventoryManager.display();
        inventoryManager.remove(5);
        Console.WriteLine("inventoryManager after remove: ");
        inventoryManager.display();

        Console.WriteLine("\n===================================================\n");

        // Test remove method that will cause the array to be resized
        Console.WriteLine("@TEST: remove method that causes resize");
        Console.WriteLine("\ninventoryManager before remove with resize: ");
        Console.WriteLine("\ninventoryList Size: " + inventoryManager.inventorySize);
        inventoryManager.display();
        for (int index = 0; index < 7; index++)
        {
            inventoryManager.remove(0);
        }
        Console.WriteLine("inventoryManager after remove with resize (removes first 7): ");
        Console.WriteLine("\ninventoryList Size: " + inventoryManager.inventorySize);
        inventoryManager.display();


        Console.WriteLine("\n===================================================\n");


        // Test restock method
        Console.WriteLine("@TEST: restock method");
        Console.WriteLine("\nItem QTY before Restock (+20): " + inventoryManager.inventoryList[3].quantity);
        inventoryManager.restock(3, 20);
        Console.WriteLine($"{inventoryManager.inventoryList[3].itemName} QTY after Restock (+20): " + inventoryManager.inventoryList[3].quantity);


        Console.WriteLine("\n===================================================\n");


        // Test search method
        Console.WriteLine("@TEST: search method with passing name 'item10' param: ");
        Console.WriteLine(inventoryManager.search("item10")[0].itemName);

        Console.WriteLine("\n===================================================\n");

        Console.WriteLine("@TEST: search method with qty=50, deviceType = laptop params: ");
        Console.WriteLine(inventoryManager.search(null,50, "Laptop")[0].itemName);

        Console.WriteLine("\n===================================================\n");

        Console.WriteLine("@TEST: search method with qty=30 param: ");
        foreach(InventoryItem item in inventoryManager.search(null, 30, null))
        {
            Console.WriteLine(item.itemName);
        }

    }
}