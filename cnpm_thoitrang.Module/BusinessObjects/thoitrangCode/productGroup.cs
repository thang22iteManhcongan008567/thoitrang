using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace cnpm_thoitrang.Module.BusinessObjects.thoitrang
{

    public partial class productGroup
    {
        public productGroup(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
