using System.Collections.ObjectModel;
using System.Diagnostics;

namespace DatatTemplatePerfIssue;

public partial class Table : ContentView
{
	public Table()
	{
		InitializeComponent();
    }

    public void Load()
    {
        ObservableCollection<Col> cols = new ObservableCollection<Col>();
        for (int i = 0; i < 7; i++)
        {
            cols.Add(new Col("Title" + i));
        }
        ObservableCollection<Row> rows = new ObservableCollection<Row>();
        for (int i = 0; i < 5; i++)
        {
            rows.Add(new Row("Row " + i, "Description " + i, cols));
        }

        BindableLayout.SetItemsSource(Rows, rows);
    }
}