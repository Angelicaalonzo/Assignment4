using System;
using System.Collections.Generic;


class Invoice
{
    int InvNum;
    string nvDate;
    float total;
    
    List<invoiceEntry> LineItems = new List<invoiceEntry>();

    public Invoice(int i, string d)
    {
        InvNum = i; 
        nvDate = d; 
    }

    public bool addInvEntry(Item item, int ReqQuantity)
    {
        if(item.getAvlblQnty() >= ReqQuantity)
        {
            //upade available item quantity
            item.updtAvlblQnty(ReqQuantity*-1);
            //add a new invoice entry        //line number      //quantity added
            invoiceEntry x = new invoiceEntry(LineItems.Count, ReqQuantity, item);
            LineItems.Add(x);            
            return true;
        }
        //if there is not enough stock to fill the order do not allow it to be added to the invoice
        else
        {
            return false;
        }
    }

    public bool removeInvEntry(int lineNo)
    {
        invoiceEntry toRemove = null; 

        foreach(invoiceEntry l in LineItems)
        if(l.getLineNumber() == lineNo)
        {
            toRemove= l; 
        }
        LineItems.Remove(toRemove);

        if(toRemove !=null)
        {
            return true; 
        }
        else
        {
            return false; 
        }
        
        
    }
    public void updateTotal(float t)
    {
        t += total;
        /*
        foreach(invoiceEntry e in LineItems)
        {
            total += e.getQuantity() * e.GetItem().getPrice();
        }
        */
        
    }
    public void updateLineNumbers()
    {
        int Cntr = 1; // 
        foreach(invoiceEntry e in LineItems)
        {
            e.setLineNumber(Cntr);
            Cntr++;
        }   
    }

    public void printInvoice()
    {
        Console.WriteLine("Invoice #: " + InvNum + "Date: "+ nvDate);
        Console.WriteLine("{0,4} {1,6} {2,15} {3,6} {4,5}", "Line #", "Ln", "Item", "Price", "Availble Qty" , "Total");
        Console.WriteLine("------    --------------- -------- ----------");
        foreach ( invoiceEntry e in LineItems)
        {
            float linetotal = 0;
            linetotal = e.GetItem().getPrice() * e.getQuantity();
            Console.WriteLine(e.getLineNumber() + "\t" + e.GetItem().getItemID() +  "\t" + e.GetItem().getItemDescription() +  "\t"   + e.GetItem().getPrice() + "\t"  + e.GetItem().getPrice() + e.getQuantity() +  "\t" + linetotal );
        }
        
        
    }


}

