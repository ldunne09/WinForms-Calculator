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
using Database_WPF.DataSetTableAdapters;

namespace Database_WPF
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

        private GameTableAdapter gameTableAdapter = new GameTableAdapter();
        private DataSet dataSet = new DataSet();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Fill(dataSet.Game);
            DataContext = dataSet.Game.DefaultView;
        }


        private void Update_Click(object sender, RoutedEventArgs e)
        {
            gameTableAdapter.Update(dataSet);
        }
    }
}
