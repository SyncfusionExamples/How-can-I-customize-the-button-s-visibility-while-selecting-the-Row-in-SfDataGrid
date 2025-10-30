namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGrid_SelectionChanged(object sender, Syncfusion.Maui.DataGrid.DataGridSelectionChangedEventArgs e)
        {
            if (e.AddedRows.Count > 0 && e.AddedRows[0] is Employee selectedEmployee)
            {
                selectedEmployee.IsButtonVisible = true;
            }
            else if(e.RemovedRows.Count > 0 && e.RemovedRows[0] is Employee removedEmployee)
            {
                removedEmployee.IsButtonVisible = false;
            }
        }
    }
}
