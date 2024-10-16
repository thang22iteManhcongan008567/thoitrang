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

    public partial class Shop_Order_Detail : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Product fproductID;
        [Association(@"Shop_Order_DetailReferencesProduct")]
        public Product productID
        {
            get { return fproductID; }
            set { SetPropertyValue<Product>(nameof(productID), ref fproductID, value); }
        }
        Shop_Order fshopOrderID;
        [Association(@"Shop_Order_DetailReferencesShop_Order")]
        public Shop_Order shopOrderID
        {
            get { return fshopOrderID; }
            set { SetPropertyValue<Shop_Order>(nameof(shopOrderID), ref fshopOrderID, value); }
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
        [PersistentAlias("ToDecimal([quantity]) * [unitPrice] + [tax]")]
        public decimal intoMoney
        {
            get { return (decimal)(EvaluateAlias(nameof(intoMoney))); }
        }
        [PersistentAlias("ToDecimal([quantity]) * [unitPrice] * (10 / 100)")]
        public decimal tax
        {
            get { return (decimal)(EvaluateAlias(nameof(tax))); }
        }
    }

}