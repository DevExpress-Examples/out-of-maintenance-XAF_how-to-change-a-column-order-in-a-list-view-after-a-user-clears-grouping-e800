using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;

namespace Solution1.Module.Win {
    public class Updater : ModuleUpdater {
           public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
           public override void UpdateDatabaseAfterUpdateSchema() {
                base.UpdateDatabaseAfterUpdateSchema();
           }
    }
}
