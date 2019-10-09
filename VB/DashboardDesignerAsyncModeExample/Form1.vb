Imports System
Imports System.Threading.Tasks
Imports DevExpress.DashboardCommon

Namespace DashboardDesignerAsyncModeExample
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Private Shared myData As Object
		Public Sub New()
			InitializeComponent()
			dashboardDesigner1.AsyncMode = True
			dashboardDesigner1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs
			AddHandler dashboardDesigner1.DataLoading, AddressOf DashboardDesigner1_DataLoading
            AddHandler dashboardDesigner1.AsyncDataLoading, AddressOf DashboardDesigner1_AsyncDataLoading
            Task.Run(Async Function()
                         Await LoadData()
                     End Function)
        End Sub

		Private Sub DashboardDesigner1_DataLoading(ByVal sender As Object, ByVal e As DataLoadingEventArgs)
			If Not dashboardDesigner1.AsyncMode Then
				e.Data = myData
			End If
		End Sub

		Private Sub DashboardDesigner1_AsyncDataLoading(ByVal sender As Object, ByVal e As DataLoadingEventArgs)
			If dashboardDesigner1.AsyncMode Then
				e.Data = myData
			End If
		End Sub

		Private Sub btnLoadAsync_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadAsync.Click
			dashboardDesigner1.AsyncMode = True
			lblMode.Text = "ASYNC"
			dashboardDesigner1.LoadDashboard("test.xml")
		End Sub

		Private Sub btnLoadSync_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoadSync.Click
			dashboardDesigner1.AsyncMode = False
			lblMode.Text = "SYNC"
			dashboardDesigner1.LoadDashboard("test.xml")
		End Sub

		Private Async Sub btnReloadData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReloadData.Click
			Await LoadData()
		End Sub
		Private Async Function LoadData() As Task
			If dashboardDesigner1.AsyncMode Then
				Await LoadDataAsynchronously()
			Else
				LoadDataSynchronously()
			End If
		End Function
		Private Async Function LoadDataAsynchronously() As Task
            Dim s As String = lblMode.Text
            lblMode.Text = "Loading..."
            Await Task.Run(Sub()
                               myData = SalesData.CreateData()
                           End Sub).ContinueWith(Sub(t)
                                                     dashboardDesigner1.ReloadDataAsync()
                                                 End Sub)
            lblMode.Text = s
        End Function
		Private Sub LoadDataSynchronously()
			myData = SalesData.CreateData()
			dashboardDesigner1.ReloadData()
		End Sub
	End Class
End Namespace
