using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace cnpm_thoitrang.Module.BusinessObjects.thoitrang
{

    public partial class Shop_Order
    {
        public Shop_Order(Session session) : base(session) { }
        public override void AfterConstruction() 
        { 
            base.AfterConstruction(); 
            if (Session.IsNewObject(this))
            {
                dateOrder = DateTime.Now;
            }
        }
    }

}
