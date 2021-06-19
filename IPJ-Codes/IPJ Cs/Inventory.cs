using System;
using System.Collections.Generic;
using System.Text;

//Composicion: Clase que se compone de otras.
//Herencia: Clases padre, hijo, instancia.
//Abstract: Idea de objeto. No puede ser utilizable para constructor.
//Sealed: Objeto que no necesite herencia.
//Is: Comparativo. Term1 Is Term2?.
//As: Transforma la variable. Term1 ES Term2.
//UPCASTING: Heredar de clase padre.
//DownCASTING: Heredar de clase hijo.
//Polimorfismo: virtual indica que funcion de que clase usar, conecta con override.
public class Inventory
{
    private List<InventorySlot> inventory;
    private int size;

    public Inventory(int size)
    {
        this.size = size;
    }
    public List<InventorySlot> GetInventories() {
        return inventory;
    }
    public void Additem(Item item, int amount)
    {
        bool alreadyContained = false;
        for (int i = 0; i < inventory.Count; i++)
        {
            if (inventory[i].item.name == item.name)
            {
                alreadyContained = true;
            }
        }

        if (alreadyContained)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].item.name == item.name)
                {
                    inventory[i].amount += amount;
                }
            }
        }
        else
        {
            if (inventory.Count < size)
            {
                inventory.Add(new InventorySlot(item, amount));
            }
        }
    }
}

public class InventorySlot
{
    public Item item;
    public int amount;

    public InventorySlot(Item item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }
}
public class Item
{
    public string name;
    public int price;
    protected string description;

    public Item(string name, int price, string description, int quantity)
    {
        this.name = name;
        this.price = price;
        this.description = description;
    }
}

abstract public class Consumables:Item {
    int _quantity;
    public Consumables(string name, int price, string description, int quantity) : base(name, price, description,quantity) {
        _quantity = quantity;
    }
}
public class Potions : Consumables {
    public Potions(string name, int price, string description, int quantity) : base(name, price, description, quantity)
    {

    }
}

public class Food : Consumables {
    public Food(string name, int price, string description, int quantity) : base(name, price, description, quantity)
    {

    }
}

sealed public class Arrow:Consumables {
    public Arrow(string name, int price, string description, int quantity) : base(name, price, description, quantity)
    {

    }
}

abstract public class Equipment:Item { }

abstract public class Armor:Equipment { }

sealed public class ArmorCuero { }

sealed public class ArmorIron { }