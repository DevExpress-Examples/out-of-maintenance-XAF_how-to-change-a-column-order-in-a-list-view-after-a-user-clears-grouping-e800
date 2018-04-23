using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;

namespace Solution1.Module {
    public partial class MyViewController : ViewController {

        GridView view;

        public MyViewController() {
            InitializeComponent();
            RegisterActions( components );
            TargetViewType = ViewType.ListView;
        }

        protected override void OnActivated() {
            base.OnActivated();
            View.ControlsCreated += new EventHandler( MyViewController_ControlsCreated );
        }
        void MyViewController_ControlsCreated( object sender, EventArgs e ) {
            ListView _listView = (ListView) View;
            GridControl grid = (GridControl) _listView.Control;
            view = (GridView) grid.DefaultView;
            view.GridMenuItemClick += new GridMenuItemClickEventHandler( view_GridMenuItemClick );
        }

        void view_GridMenuItemClick( object sender, GridMenuItemClickEventArgs e ) {
            if( e.DXMenuItem.Tag.ToString() == "MenuGroupPanelClearGrouping" ) {
                view.Columns["Field5"].VisibleIndex = 0;                
                view.Columns["Field4"].VisibleIndex = 1;        
                view.Columns["Field3"].VisibleIndex = 2;        
                view.Columns["Field2"].VisibleIndex = 3;        
                view.Columns["Field1"].VisibleIndex = 4;        
            }
        }
    }
}

