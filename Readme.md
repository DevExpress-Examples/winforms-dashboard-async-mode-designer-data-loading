<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/213933664/19.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828247)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/DashboardDesignerAsyncModeExample/Form1.cs) (VB: [Form1.vb](./VB/DashboardDesignerAsyncModeExample/Form1.vb))
<!-- default file list end -->

# Dashboard for WinForms - Dashboard Designer in asynchronous mode with Object Data Source

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

- [Asynchronous Mode](https://docs.devexpress.com/Dashboard/401305)

## More Examples

- [Dashboard for WinForms - How to get filter values and set Master Filter asynchronously](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-random-filter)
- [Dashboard for WinForms - How to invoke the Data Inspector asynchronously when the Dashboard is loaded](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-show-data-inspector)
- [Dashboard for WinForms - How to create a slide show with asynchronous Maximize and Restore methods](https://github.com/DevExpress-Examples/winforms-dashboard-async-mode-maximize-slide-show)
