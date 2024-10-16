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

    [DefaultProperty("name")]
    public partial class Product : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fname;
        [Size(30)]
        public string name
        {
            get { return fname; }
            set { SetPropertyValue<string>(nameof(name), ref fname, value); }
        }
        string fdescription;
        [Size(50)]
        public string description
        {
            get { return fdescription; }
            set { SetPropertyValue<string>(nameof(description), ref fdescription, value); }
        }
        string fimage;
        public string image
        {
            get { return fimage; }
            set { SetPropertyValue<string>(nameof(image), ref fimage, value); }
        }
        decimal fsell_price;
        [DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "### ### ### ###"), DevExpress.ExpressApp.Model.ModelDefault("EditMask", "### ### ### ###")
]
        public decimal sell_price
        {
            get { return fsell_price; }
            set { SetPropertyValue<decimal>(nameof(sell_price), ref fsell_price, value); }
        }
        statictis fstatictisID;
        [Association(@"ProductReferencesstatictis")]
        public statictis statictisID
        {
            get { return fstatictisID; }
            set { SetPropertyValue<statictis>(nameof(statictisID), ref fstatictisID, value); }
        }
        productGroup fproductGroupID;
        [Association(@"ProductReferencesproductGroup")]
        public productGroup productGroupID
        {
            get { return fproductGroupID; }
            set { SetPropertyValue<productGroup>(nameof(productGroupID), ref fproductGroupID, value); }
        }
        [Association(@"Shop_Order_DetailReferencesProduct"), Aggregated]
        public XPCollection<Shop_Order_Detail> Shop_Order_Details { get { return GetCollection<Shop_Order_Detail>(nameof(Shop_Order_Details)); } }
        [Association(@"import_orderReferencesProduct"), Aggregated]
        public XPCollection<import_order> import_orders { get { return GetCollection<import_order>(nameof(import_orders)); } }
        [Association(@"Shopping_Cart_ItemReferencesProduct"), Aggregated]
        public XPCollection<Shopping_Cart_Item> Shopping_Cart_Items { get { return GetCollection<Shopping_Cart_Item>(nameof(Shopping_Cart_Items)); } }
        [Association(@"InventoryReferencesProduct"), Aggregated]
        public XPCollection<Inventory> Inventories { get { return GetCollection<Inventory>(nameof(Inventories)); } }
        [Association(@"evaluateReferencesProduct"), Aggregated]
        public XPCollection<evaluate> evaluates { get { return GetCollection<evaluate>(nameof(evaluates)); } }
    }

}
