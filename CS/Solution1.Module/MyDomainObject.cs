using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace Solution1.Module {
    [DefaultClassOptions]
    public class MyDomainObject : BaseObject {
        public MyDomainObject( Session session )
            : base( session ) {
        }
        private string field1;
        public  string Field1 {
            set {
                SetPropertyValue("Field1", ref field1, value);
            }
            get {
                return field1;
            }
        }
        private string field2;
        public string Field2 {
            set {
                SetPropertyValue( "Field2", ref field2, value );
            }
            get {
                return field2;
            }
        }
        private string field3;
        public string Field3 {
            set {
                SetPropertyValue( "Field3", ref field3, value );
            }
            get {
                return field3;
            }
        }
        private string field4;
        public string Field4 {
            set {
                SetPropertyValue( "Field4", ref field4, value );
            }
            get {
                return field4;
            }
        }
        private string field5;
        public string Field5 {
            set {
                SetPropertyValue( "Field5", ref field5, value );
            }
            get {
                return field5;
            }
        }
    }

}
