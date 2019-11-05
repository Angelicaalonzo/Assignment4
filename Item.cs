using System;
using System.Collections.Generic;

class Item
{
    int ID;
    string Description;
    float UnitPrice;
    float AvailableQty;

    public Item(int id, string desc, float prc, int AvailQuant)
    {
        ID = id;
        Description = desc;
        UnitPrice = prc;
        AvailableQty = AvailQuant;
    }

    public string getItemDescription()
    {
        return Description;
    }

    public float getPrice()
    {
        return UnitPrice;
    }

    public int getItemID()
    {
        return ID;
    }

    public void updtAvlblQnty(float Qup)
    {
        AvailableQty += Qup;
        Console.WriteLine("New Quantity is: " + AvailableQty);
    }

    public float getAvlblQnty()
    {
        return AvailableQty;
    }

    public void displayItem()
    {
        getItemID();
        getItemDescription();
        getPrice();
        getAvlblQnty();
    }
}
