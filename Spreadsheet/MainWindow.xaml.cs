using System.Collections.ObjectModel;
using System.Windows;

namespace SimpleSpreadsheetWPF
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<SpreadsheetRow> Rows { get; set; }
        public ObservableCollection<string> TypeOptions { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            TypeOptions = new ObservableCollection<string> { "Option 1", "Option 2", "Option 3" };

            Rows = new ObservableCollection<SpreadsheetRow>();
            for (int i = 0; i < 10; i++)
            {
                Rows.Add(new SpreadsheetRow { TypeOptions = TypeOptions });
            }

            DataContext = this;
        }
    }

    public class SpreadsheetRow
    {
        public ObservableCollection<string> TypeOptions { get; set; }
        public string SelectedType { get; set; } = "Option 1";

        public string ColumnA { get; set; } = "";
        public string ColumnB { get; set; } = "";
        public string ColumnC { get; set; } = "";
        public string ColumnD { get; set; } = "";
        public string ColumnE { get; set; } = "";
    }
}
