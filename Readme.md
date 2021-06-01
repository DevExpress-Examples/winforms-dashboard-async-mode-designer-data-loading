<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/DashboardDesignerAsyncModeExample/Form1.cs) (VB: [Form1.vb](./VB/DashboardDesignerAsyncModeExample/Form1.vb))
<!-- default file list end -->

# Dashboard Designer in Asynchronous Mode with Object Data Source

This example demonstrates the Dashboard Designer application that loads a dashboard bound to the object data source. The application can switch between synchronous and asynchronous mode.

The following actions are available:

* Click **Load Async** to switch to the Async mode and load a sample dashboard.
* Click **Load Sync** to turn off the Async mode and load a sample dashboard.
* Click **Reload Data** to update the object data source and display the data.

![](/images/screenshot.png)

API in this example:

* [DashboardDesigner.AsyncMode](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.AsyncMode) property
* [DashboardDesigner.AsyncDataLoading](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.AsyncDataLoading) event
* [DashboardDesigner.DataLoading](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.DataLoading) event
* [DashboardDesigner.ReloadData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.ReloadData.overloads) method
* [DashboardDesigner.ReloadDataAsync](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner.ReloadDataAsync.overloads) method
* [DashboardDesigner.DataSourceOptions.ObjectDataSourceLoadingBehavior](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.UI.Design.DataSourceOptionsContainer.ObjectDataSourceLoadingBehavior) property

## Documentation
* [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)
