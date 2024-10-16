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

    public partial class statictis : DevExpress.Persistent.BaseImpl.BaseObject
    {
        DateTime ftime;
        public DateTime time
        {
            get { return ftime; }
            set { SetPropertyValue<DateTime>(nameof(time), ref ftime, value); }
        }
        string fstatistic_type;
        public string statistic_type
        {
            get { return fstatistic_type; }
            set { SetPropertyValue<string>(nameof(statistic_type), ref fstatistic_type, value); }
        }
        double forder_count;
        public double order_count
        {
            get { return forder_count; }
            set { SetPropertyValue<double>(nameof(order_count), ref forder_count, value); }
        }
        decimal frevenue;
        public decimal revenue
        {
            get { return frevenue; }
            set { SetPropertyValue<decimal>(nameof(revenue), ref frevenue, value); }
        }
        decimal fdiscount_total;
        public decimal discount_total
        {
            get { return fdiscount_total; }
            set { SetPropertyValue<decimal>(nameof(discount_total), ref fdiscount_total, value); }
        }
        decimal frefund_total;
        public decimal refund_total
        {
            get { return frefund_total; }
            set { SetPropertyValue<decimal>(nameof(refund_total), ref frefund_total, value); }
        }
        int fcustomer_count;
        public int customer_count
        {
            get { return fcustomer_count; }
            set { SetPropertyValue<int>(nameof(customer_count), ref fcustomer_count, value); }
        }
        decimal faverage_orderValue;
        public decimal average_orderValue
        {
            get { return faverage_orderValue; }
            set { SetPropertyValue<decimal>(nameof(average_orderValue), ref faverage_orderValue, value); }
        }
        decimal fimcome;
        public decimal imcome
        {
            get { return fimcome; }
            set { SetPropertyValue<decimal>(nameof(imcome), ref fimcome, value); }
        }
        [Association(@"Shop_OrderReferencesstatictis"), Aggregated]
        public XPCollection<Shop_Order> Shop_Orders { get { return GetCollection<Shop_Order>(nameof(Shop_Orders)); } }
        [Association(@"ProductReferencesstatictis"), Aggregated]
        public XPCollection<Product> Products { get { return GetCollection<Product>(nameof(Products)); } }
    }

}