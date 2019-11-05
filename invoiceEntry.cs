using System;
using System.Collections.Generic;

class invoiceEntry{
    int lineNum;
    int quantity;
    public void invoice(int l, int q){
        lineNum = l; 
        quantity = q;
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

}