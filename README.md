# How to customize the button's visibility while selecting the Row in SfDataGrid?
In this article, we will show you how to customize the button's visibility while selecting the Row in [.Net Maui DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

## xaml
```
<ContentPage.BindingContext>
    <local:EmployeeViewModel x:Name="viewModel" />
</ContentPage.BindingContext>

<syncfusion:SfDataGrid x:Name="dataGrid"
                       ColumnWidthMode="Auto"
                       GridLinesVisibility="Both"
                       HeaderGridLinesVisibility="Both"
                       AutoGenerateColumnsMode="None"
                       SelectionMode="Multiple"
                       SelectionChanged="dataGrid_SelectionChanged"
                       ItemsSource="{Binding Employees}">

    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridNumericColumn MappingName="EmployeeID"
                                          Format="#"
                                          HeaderText="Employee ID" />
        <syncfusion:DataGridTextColumn MappingName="Name"
                                       HeaderText="Employee Name" />
        <syncfusion:DataGridTextColumn MappingName="Title"
                                       HeaderText="Designation" />
        <syncfusion:DataGridTemplateColumn HeaderText="Template">
            <syncfusion:DataGridTemplateColumn.CellTemplate>
                <DataTemplate>
                    <Button Text="click Here"
                            IsVisible="{Binding IsButtonVisible}" />
                </DataTemplate>
            </syncfusion:DataGridTemplateColumn.CellTemplate>
        </syncfusion:DataGridTemplateColumn>

    </syncfusion:SfDataGrid.Columns>

</syncfusion:SfDataGrid>
``` 

## C#
The code below demonstrates how to customize the button's visibility while selecting the Row in DataGrid.
```
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
```

 ![visibility.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjM0MDA1Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.ffKFsZIWdHdU1y3rlsuUmUQowGlZyhkRbOjvjzxKHd0)

[View sample in GitHub](https://github.com/SyncfusionExamples/How-can-I-customize-the-button-s-visibility-while-selecting-the-Row-in-SfDataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to customize the button's visibility while selecting the Row in .NET MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!