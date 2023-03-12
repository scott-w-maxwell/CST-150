/*
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * This program was written by Scott Maxwell for the Milestone Project in CST-150.
 * This is my own original work.
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 */

using System;

namespace Inventory
{
    class InventoryItem
    {

        // Declare item fields

        public string itemSKU;
        public string itemName;
        public string deviceType;
        public string[] graphicsProcessingUnit;
        public string[] coreProcessingUnit;
        public string[] randomAccessMemory;
        public string[] screen;
        public int quantity;

        // Below methods for modifying item fields

        public string modifyItemSKU(string newSKU)
        {
            itemSKU = newSKU;
            return itemSKU;
        }

        public string modifyItemName(string newName)
        {
            itemName = newName;
            return itemName;
        }

        public string modifyDeviceType(string newType)
        {
            deviceType = newType;
            return deviceType;
        }

        // The field should be formatted like: {GPU Name, # of GDDR Gigabytes}
        public string[] modifyGraphicsProcessingUnit(string[] newGPU)
        {
            graphicsProcessingUnit = newGPU;
            return graphicsProcessingUnit;
        }

        // The field should be formatted like: {CPU Name, # of Cores, # of Threads, Clock Speed}
        public string[] modifyCoreProcessingUnit(string[] newCPU)
        {
            coreProcessingUnit = newCPU;
            return coreProcessingUnit;
        }

        // The field should be formatted like: {RAM Name, DDR#, # of Gb}
        public string[] modifyRandomAccessMemory(string[] newRAM)
        {
            randomAccessMemory = newRAM;
            return coreProcessingUnit;
        }

        // The field should be formatted like: {Screen size, screen resolution}
        public string[] modifyScreen(string[] newScreen)
        {
            screen = newScreen;
            return screen;
        }

        public int modifyQuantity(int newQTY)
        {
            quantity = newQTY;
            return quantity;
        }

        // Driver
        /*
        public static void Main(string[] args)
        {

            // Create a new Item object
            InventoryItem myItem = new InventoryItem();

            // Set the initial values using the modify methods
            myItem.modifyItemSKU("12345");
            myItem.modifyItemName("Asus DMZ3983");
            myItem.modifyDeviceType("Laptop");
            myItem.modifyGraphicsProcessingUnit(new string[] { "Nvidia GeForce GTX 1050", "16GB" });
            myItem.modifyCoreProcessingUnit(new string[] { "Intel Core i5", "4", "16", "3.5" });
            myItem.modifyRandomAccessMemory(new string[] { "GSkill RAM", "8GB", "DDR4" });
            myItem.modifyScreen(new string[] { "15.6 inch", "1920x1080" });
            myItem.modifyQuantity(10);

            // Print out the updated values
            Console.WriteLine("Item SKU: " + myItem.itemSKU);
            Console.WriteLine("Item Name: " + myItem.itemName);
            Console.WriteLine("Device Type: " + myItem.deviceType);
            Console.WriteLine("Graphics Processing Unit: " + string.Join(", ", myItem.graphicsProcessingUnit));
            Console.WriteLine("Core Processing Unit: " + string.Join(", ", myItem.coreProcessingUnit));
            Console.WriteLine("Random Access Memory: " + string.Join(", ", myItem.randomAccessMemory));
            Console.WriteLine("Screen: " + string.Join(", ", myItem.screen));
            Console.WriteLine("Quantity: " + myItem.quantity);

            Console.WriteLine("\n\n--- Modify the values and print them out again ---\n\n");

            // Modify all the values
            myItem.modifyItemSKU("67890");
            myItem.modifyItemName("Dell Inspiron 15");
            myItem.modifyDeviceType("Desktop");
            myItem.modifyGraphicsProcessingUnit(new string[] { "Nvidia GeForce RTX 3080", "32GB" });
            myItem.modifyCoreProcessingUnit(new string[] { "AMD Ryzen 9 5950X", "16", "64", "4.9" });
            myItem.modifyRandomAccessMemory(new string[] { "Corsair RAM", "32GB", "DDR5" });
            myItem.modifyScreen(new string[] { "27 inch", "3840×2160" });
            myItem.modifyQuantity(20);

            // Print out the modified values
            Console.WriteLine("Modified values:\n");
            Console.WriteLine("Item SKU: " + myItem.itemSKU);
            Console.WriteLine("Item Name: " + myItem.itemName);
            Console.WriteLine("Device Type: " + myItem.deviceType);
            Console.WriteLine("Graphics Processing Unit: " + string.Join(", ", myItem.graphicsProcessingUnit));
            Console.WriteLine("Core Processing Unit: " + string.Join(", ", myItem.coreProcessingUnit));
            Console.WriteLine("Random Access Memory: " + string.Join(", ", myItem.randomAccessMemory));
            Console.WriteLine("Screen: " + string.Join(", ", myItem.screen));
            Console.WriteLine("Quantity: " + myItem.quantity);

        }
        */
    }

}