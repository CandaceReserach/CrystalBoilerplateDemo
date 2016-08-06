using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrystalBoilerplateDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        SampleDataSet ds = new SampleDataSet();
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("..\\..\\SampleCrystalReport.rpt");
            using (SampleModel db = new SampleModel())
            {
                
                SampleDataSet dataset = new SampleDataSet();
                System.Data.DataSet dsCopy = dataset.Copy();
                
                SampleDataSetTableAdapters.batchTableAdapter adapter = new SampleDataSetTableAdapters.batchTableAdapter();
                adapter.Fill(dataset.batch);
                report.SetDataSource(dataset);
                
              
            }
            crystalReportsViewer1.ViewerCore.ReportSource = report;
        }
    }
}
