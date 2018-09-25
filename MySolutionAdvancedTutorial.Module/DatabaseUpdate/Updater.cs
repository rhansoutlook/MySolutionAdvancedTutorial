using System;
using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.Security;

using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using MySolutionAdvancedTutorial.Module.BusinessObjects.Classes;

namespace MySolutionAdvancedTutorial.Module.DatabaseUpdate {
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppUpdatingModuleUpdatertopic.aspx
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
     public override void UpdateDatabaseAfterUpdateSchema()
        {
            base.UpdateDatabaseAfterUpdateSchema();

            Contact contactMary = ObjectSpace.FindObject<Contact>(
                CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if (contactMary == null)
            {
                contactMary = ObjectSpace.CreateObject<Contact>();
                contactMary.FirstName = "Mary";
                contactMary.LastName = "Tellitson";
                contactMary.Email = "tellitson@example.com";
                contactMary.Birthday = new DateTime(1980, 11, 27);
            }
            //...
            ObjectSpace.CommitChanges();
        }
        //if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
        //    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
        //}
    }
    
    }
