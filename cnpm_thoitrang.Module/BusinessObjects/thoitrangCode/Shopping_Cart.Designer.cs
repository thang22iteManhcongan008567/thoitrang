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

    public partial class Shopping_Cart : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Customer fcustomerID;
        [Association(@"Shopping_CartReferencesCustomer")]
        public Customer customerID
        {
            get { return fcustomerID; }
            set { SetPropertyValue<Customer>(nameof(customerID), ref fcustomerID, value); }
        }
        Shop_Order fshopOrderID;
        [Association(@"Shopping_CartReferencesShop_Order")]
        public Shop_Order shopOrderID
        {
            get { return fshopOrderID; }
            set { SetPropertyValue<Shop_Order>(nameof(shopOrderID), ref fshopOrderID, value); }
        }
        [Association(@"Shopping_Cart_ItemReferencesShopping_Cart"), Aggregated]
        public XPCollection<Shopping_Cart_Item> Shopping_Cart_Items { get { return GetCollection<Shopping_Cart_Item>(nameof(Shopping_Cart_Items)); } }
        [Association(@"PaymentReferencesShopping_Cart"), Aggregated]
        public XPCollection<Payment> Payments { get { return GetCollection<Payment>(nameof(Payments)); } }
    }

}