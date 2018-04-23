Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns

Namespace Solution1.Module
	Partial Public Class MyViewController
		Inherits ViewController

		Private _view As GridView

		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			TargetViewType = ViewType.ListView
		End Sub

		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			Dim lv As ListView = CType(view, ListView)
			AddHandler lv.ControlsCreated, AddressOf MyViewController_ControlsCreated
		End Sub
		Private Sub MyViewController_ControlsCreated(ByVal sender As Object, ByVal e As EventArgs)
			Dim _listView As ListView = CType(View, ListView)
			Dim grid As GridControl = CType(_listView.Control, GridControl)
			_view = CType(grid.DefaultView, GridView)
			AddHandler _view.GridMenuItemClick, AddressOf view_GridMenuItemClick
		End Sub

		Private Sub view_GridMenuItemClick(ByVal sender As Object, ByVal e As GridMenuItemClickEventArgs)
			If e.DXMenuItem.Tag.ToString() = "MenuGroupPanelClearGrouping" Then
				_view.Columns("Field5").VisibleIndex = 0
				_view.Columns("Field4").VisibleIndex = 1
				_view.Columns("Field3").VisibleIndex = 2
				_view.Columns("Field2").VisibleIndex = 3
				_view.Columns("Field1").VisibleIndex = 4
			End If
		End Sub
	End Class
End Namespace

