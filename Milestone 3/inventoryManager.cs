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
    public void add(InventoryItem item){
        if(count >= inventorySize)
        {
            // Double inventorySize
            inventorySize *= 2;
            Array.Resize(ref inventoryList, inventorySize);
        }
        inventoryList[count] = item;
        count++;
    }

    // Removes items from inventoryList
    public void remove(int itemIndex){

        // Shift all values in the array right of the removed value left
        for(int index = itemIndex; index < inventoryList.Length; index++)
        {
            inventoryList[index] = inventoryList[index + 1];
        }

        // Decrease the count of items in array
        count--;

        // Resize Array to be smaller if only using 1/4 of it.
        if((inventorySize / count) <= (1.0/4.0)){
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

    // lists items in inventoryList
    public void display(){
        for(int index = 0; index < count; index++)
        {
            Console.WriteLine(inventoryList[index]);
        }
    }

    // Returns a list of items that match provided params
    public List<InventoryItem> search(string? name = null, int? qty = null, string? deviceType = null){


        // List to store matches
        List<InventoryItem> matchesQuery = new List<InventoryItem>();

        // Loop over inventoryList to find matches
        for (int index = 0; index < count; count++)
        {

            InventoryItem item = inventoryList[index];

            // Used to record match or a non-match
            bool matches = false;

            // If parameter was specified
            if(name != null)
            {
                if(item.itemName == name)
                {
                    matches = true;
                }
                else
                {
                    matches = false;
                }

            }

            // If parameter was specified
            if(qty != null)
            {
                if(item.quantity == qty)
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
                if(item.deviceType == deviceType)
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

    // Driver
    public static void Main(string[] args)
    {

        InventoryManager inventoryManager = new InventoryManager();

        InventoryItem item = new InventoryItem();

        inventoryManager.add(item);
        inventoryManager.display();
    }
}
