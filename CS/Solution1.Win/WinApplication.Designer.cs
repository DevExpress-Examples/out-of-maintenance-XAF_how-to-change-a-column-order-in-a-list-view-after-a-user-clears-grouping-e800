namespace Solution1.Win {
    partial class Solution1WindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new Solution1.Module.Solution1Module();
            this.module4 = new Solution1.Module.Win.Solution1WindowsFormsModule();
            this.module5 = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            this.module7 = new DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.securitySimple1 = new DevExpress.ExpressApp.Security.SecuritySimple();
            this.authenticationActiveDirectory1 = new DevExpress.ExpressApp.Security.AuthenticationActiveDirectory();
            ( (System.ComponentModel.ISupportInitialize) ( this ) ).BeginInit();
            // 
            // module5
            // 
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleSetValidationResult ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleSetValidationResultItem ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RulePropertyValueProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleRequiredFieldProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleFromBoolPropertyProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleRangeProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleValueComparisonProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleStringComparisonProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleRegularExpressionProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleCriteriaProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleSearchObjectProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleObjectExistsProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleUniqueValueProperties ) );
            this.module5.AdditionalBusinessClasses.Add( typeof( DevExpress.Persistent.Validation.RuleIsReferencedProperties ) );
            // 
            // securitySimple1
            // 
            this.securitySimple1.Authentication = this.authenticationActiveDirectory1;
            this.securitySimple1.UserType = typeof( DevExpress.Persistent.BaseImpl.BasicUser );
            // 
            // authenticationActiveDirectory1
            // 
            this.authenticationActiveDirectory1.CreateUserAutomatically = true;
            this.authenticationActiveDirectory1.UserType = typeof( DevExpress.Persistent.BaseImpl.BasicUser );
            // 
            // Solution1WindowsFormsApplication
            // 
            this.ApplicationName = "Solution1";
            this.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password=;User ID=Admin;Data Source=Solution1.md" +
                "b;Mode=Share Deny None;";
            this.Modules.Add( this.module1 );
            this.Modules.Add( this.module2 );
            this.Modules.Add( this.module6 );
            this.Modules.Add( this.module3 );
            this.Modules.Add( this.module4 );
            this.Modules.Add( this.module5 );
            this.Modules.Add( this.module7 );
            this.Modules.Add( this.securityModule1 );
            this.Security = this.securitySimple1;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>( this.Solution1WindowsFormsApplication_DatabaseVersionMismatch );
            ( (System.ComponentModel.ISupportInitialize) ( this ) ).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private Solution1.Module.Solution1Module module3;
        private Solution1.Module.Win.Solution1WindowsFormsModule module4;
        private DevExpress.ExpressApp.Validation.ValidationModule module5;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
        private DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule module7;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
        private DevExpress.ExpressApp.Security.SecuritySimple securitySimple1;
        private DevExpress.ExpressApp.Security.AuthenticationActiveDirectory authenticationActiveDirectory1;
    }
}
