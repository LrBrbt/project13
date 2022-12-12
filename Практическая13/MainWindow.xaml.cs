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
using LibMas;

namespace Практическая13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Matrix<int> matrix;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FindColumn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void FillDataGrid_Click(object sender, RoutedEventArgs e)
        {
            matrix = new(int.Parse(Rows.Text), int.Parse(Columns.Text));
            matrix.
        }
    }
}
