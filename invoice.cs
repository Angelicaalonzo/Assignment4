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
            invoiceEntry x = new invoiceEntry(LineItems.Count, ReqQuantity);            
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
        t = total;

        
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
        
    }


}

