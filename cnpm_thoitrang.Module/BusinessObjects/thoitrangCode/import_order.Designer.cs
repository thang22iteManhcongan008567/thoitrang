﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace cnpm_thoitrang.Module.BusinessObjects.thoitrang
{

    public partial class import_order : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Product fproductID;
        [Association(@"import_orderReferencesProduct")]
        public Product productID
        {
            get { return fproductID; }
            set { SetPropertyValue<Product>(nameof(productID), ref fproductID, value); }
        }
        Warehouse_receipt freceiptID;
        [Association(@"import_orderReferencesWarehouse_receipt")]
        public Warehouse_receipt receiptID
        {
            get { return freceiptID; }
            set { SetPropertyValue<Warehouse_receipt>(nameof(receiptID), ref freceiptID, value); }
        }
        double fquantity;
        public double quantity
        {
            get { return fquantity; }
            set { SetPropertyValue<double>(nameof(quantity), ref fquantity, value); }
        }
        decimal funitPrice;
        public decimal unitPrice
        {
            get { return funitPrice; }
            set { SetPropertyValue<decimal>(nameof(unitPrice), ref funitPrice, value); }
        }
    }

}