<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128588109/11.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E80005)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Model.DesignedDiffs.xafml](./CS/Solution1.Module.Win/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/Solution1.Module.Win/Model.DesignedDiffs.xafml))
* [Updater.cs](./CS/Solution1.Module.Win/Updater.cs) (VB: [Updater.vb](./VB/Solution1.Module.Win/Updater.vb))
* [WinModule.cs](./CS/Solution1.Module.Win/WinModule.cs) (VB: [WinModule.vb](./VB/Solution1.Module.Win/WinModule.vb))
* [Model.DesignedDiffs.xafml](./CS/Solution1.Module/Model.DesignedDiffs.xafml) (VB: [Model.DesignedDiffs.xafml](./VB/Solution1.Module/Model.DesignedDiffs.xafml))
* [Module.cs](./CS/Solution1.Module/Module.cs) (VB: [Module.vb](./VB/Solution1.Module/Module.vb))
* [MyDomainObject.cs](./CS/Solution1.Module/MyDomainObject.cs) (VB: [MyDomainObject.vb](./VB/Solution1.Module/MyDomainObject.vb))
* [MyViewController.cs](./CS/Solution1.Module/MyViewController.cs) (VB: [MyViewController.vb](./VB/Solution1.Module/MyViewController.vb))
* [Updater.cs](./CS/Solution1.Module/Updater.cs) (VB: [Updater.vb](./VB/Solution1.Module/Updater.vb))
* [Model.xafml](./CS/Solution1.Win/Model.xafml) (VB: [Model.xafml](./VB/Solution1.Win/Model.xafml))
* [Program.cs](./CS/Solution1.Win/Program.cs) (VB: [Program.vb](./VB/Solution1.Win/Program.vb))
* [WinApplication.cs](./CS/Solution1.Win/WinApplication.cs) (VB: [WinApplication.vb](./VB/Solution1.Win/WinApplication.vb))
<!-- default file list end -->
# How to change a column order in a list view after a user clears grouping.


<p>To change the column order of your listView after a user cleared grouping use the following method.</p><p>First, it is necessary to access grid control.<br />
Refer to the <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2739">Access Grid Control Properties in Windows Forms Applications</a> help topic, for more details.</p><p>Then, it is necessary to subscribe to the GridMenuItemClick event of the GridControl's view:<br />


```cs
<newline/>
public partial class MyViewController : ViewController {<newline/>
    GridView view;<newline/>
    ...<newline/>
protected override void OnActivated() {<newline/>
    base.OnActivated();<newline/>
    View.ControlsCreated += new EventHandler( MyViewController_ControlsCreated );<newline/>
}<newline/>
void MyViewController_ControlsCreated( object sender, EventArgs e ) {<newline/>
    ListView _listView = (ListView) View;<newline/>
    GridControl grid = (GridControl) _listView.Control;<newline/>
    view = (GridView) grid.DefaultView;<newline/>
    view.GridMenuItemClick += new GridMenuItemClickEventHandler( view_GridMenuItemClick );<newline/>
}<newline/>

```



```vb
<newline/>
Partial Public Class MyViewController<newline/>
   Inherits ViewController<newline/>
   Private _view As GridView<newline/>
  ...<newline/>
Protected Overrides Sub OnActivated()<newline/>
  MyBase.OnActivated()<newline/>
  Dim lv As ListView = CType(view, ListView)<newline/>
  AddHandler lv.ControlsCreated, AddressOf MyViewController_ControlsCreated<newline/>
End Sub<newline/>
Private Sub MyViewController_ControlsCreated(ByVal sender As Object, ByVal e As EventArgs)<newline/>
  Dim _listView As ListView = CType(View, ListView)<newline/>
  Dim grid As GridControl = CType(_listView.Control, GridControl)<newline/>
  _view = CType(grid.DefaultView, GridView)<newline/>
  AddHandler _view.GridMenuItemClick, AddressOf view_GridMenuItemClick<newline/>
End Sub<newline/>

```

</p><p>Then, reorder the columns order, if the user clicks on the "Clear Grouping" item of the GridMenu:<br />


```cs
<newline/>
void view_GridMenuItemClick( object sender, GridMenuItemClickEventArgs e ) {<newline/>
    if( e.DXMenuItem.Tag.ToString() == "MenuGroupPanelClearGrouping" ) {<newline/>
       // for example, in the reverse order<newline/>
        view.Columns["Field5"].VisibleIndex = 0;                <newline/>
        view.Columns["Field4"].VisibleIndex = 1;        <newline/>
        view.Columns["Field3"].VisibleIndex = 2;        <newline/>
        view.Columns["Field2"].VisibleIndex = 3;        <newline/>
        view.Columns["Field1"].VisibleIndex = 4;        <newline/>
    }<newline/>
}<newline/>
<code lang="vb"><newline/>
Private Sub view_GridMenuItemClick(ByVal sender As Object, ByVal e As GridMenuItemClickEventArgs)<newline/>
  If e.DXMenuItem.Tag.ToString() = "MenuGroupPanelClearGrouping" Then<newline/>
     _view.Columns("Field5").VisibleIndex = 0<newline/>
     _view.Columns("Field4").VisibleIndex = 1<newline/>
     _view.Columns("Field3").VisibleIndex = 2<newline/>
     _view.Columns("Field2").VisibleIndex = 3<newline/>
     _view.Columns("Field1").VisibleIndex = 4<newline/>
  End If<newline/>
End Sub<newline/>

```

</code></p>

<br/>


