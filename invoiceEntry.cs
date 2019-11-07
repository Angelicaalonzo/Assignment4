using System;
using System.Collections.Generic;

class invoiceEntry{
    int lineNum;
    int quantity;
    Item AddedItem;

    public invoiceEntry(int l, int q, Item i)
    {
        lineNum = l; 
        quantity = q;
        AddedItem = i;
    } 
    public int getLineNumber(){
        return lineNum;
    }
    public void setLineNumber(int lineN){
        lineNum = lineN;
    }
    public int getQuantity(){
        return quantity;
    }
    public Item GetItem()
    {
        return AddedItem;
    }



}