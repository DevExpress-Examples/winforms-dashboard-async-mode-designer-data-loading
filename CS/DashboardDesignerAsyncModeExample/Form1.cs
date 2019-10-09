using System;
using System.Threading.Tasks;
using DevExpress.DashboardCommon;

namespace DashboardDesignerAsyncModeExample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        static object myData;
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.AsyncMode = true;
            dashboardDesigner1.DataSourceOptions.ObjectDataSourceLoadingBehavior = DevExpress.DataAccess.DocumentLoadingBehavior.LoadAsIs;
            dashboardDesigner1.DataLoading += DashboardDesigner1_DataLoading;
            dashboardDesigner1.AsyncDataLoading += DashboardDesigner1_AsyncDataLoading;
            Task.Run(async () => await LoadData());
        }

        private void DashboardDesigner1_DataLoading(object sender, DataLoadingEventArgs e)
        {
            if (!dashboardDesigner1.AsyncMode)
                e.Data = myData;
        }

        private void DashboardDesigner1_AsyncDataLoading(object sender, DataLoadingEventArgs e)
        {
            if (dashboardDesigner1.AsyncMode)
                e.Data = myData;
        }

        private void btnLoadAsync_Click(object sender, EventArgs e)
        {
            dashboardDesigner1.AsyncMode = true;
            lblMode.Text = "ASYNC";
            dashboardDesigner1.LoadDashboard("test.xml");
        }

        private void btnLoadSync_Click(object sender, EventArgs e)
        {
            dashboardDesigner1.AsyncMode = false;
            lblMode.Text = "SYNC";
            dashboardDesigner1.LoadDashboard("test.xml");
        }

        private async void btnReloadData_Click(object sender, EventArgs e)
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            if (dashboardDesigner1.AsyncMode)
                await LoadDataAsynchronously();
            else
                LoadDataSynchronously();
        }
        private async Task LoadDataAsynchronously()
        {
            string s = lblMode.Text;
            lblMode.Text = "Loading...";
            await Task.Run(() => {
                myData = SalesData.CreateData();
            })
            .ContinueWith((t) => {
                dashboardDesigner1.ReloadDataAsync();
            });
            lblMode.Text = s;
        }
        private void LoadDataSynchronously()
        {
            myData = SalesData.CreateData();
            dashboardDesigner1.ReloadData();
        }
    }
}
