using System;
using System.Collections.Generic;
using System.Text;

class Shop
{
    int coins;
    int shopSize;
    Inventory inventory;
    bool browsing;
    public Shop(int shopSize){
        this.shopSize = shopSize;
        inventory = new Inventory(this.shopSize);
    }
    public void browse(Player player) {
        do
        {
            for (int i = 0; i < inventory.GetInventories().Count; i++)
            {
                Console.WriteLine(inventory.GetInventories()[i].item.name + inventory.GetInventories()[i].item.price);
            }
            int opcion = Convert.ToInt32(Console.ReadLine());
            if (player.coins >= inventory.GetInventories()[0].item.price) {
                player.coins = player.coins - inventory.GetInventories()[opcion].item.price;
            }
        } while (browsing);
    }
}
