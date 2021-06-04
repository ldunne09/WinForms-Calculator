using Database_WPF.DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Linq;

namespace Database_WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        public string Name;
        public string Password;

        private UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        private DataSet dataSet = new DataSet();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            usersTableAdapter.Fill(dataSet.Users);
            DataContext = dataSet.Users.DefaultView;

        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var query = from user in dataSet.Users
                        where (user.Name == txtName.Text)
                        where (user.Password == txtPassword.Text)
                        select user;
           
            if (query.Count() > 0)
            {
                MainWindow mainWindows = new MainWindow();
                mainWindows.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User Does Not Exist", "Submit", MessageBoxButton.OK, MessageBoxImage.Error);
                txtName.Clear();
                txtPassword.Clear();
            }
        }

        private void RegistarButton_Click(object sender, RoutedEventArgs e)
        {
            DataSet.UsersRow row = (DataSet.UsersRow)dataSet.Users.NewRow();
            row.Name = txtName.Text;
            row.Password = txtPassword.Text;

            dataSet.Users.AddUsersRow(row);
            usersTableAdapter.Update(dataSet);

            MessageBox.Show("User Was Added", "Registar", MessageBoxButton.OK, MessageBoxImage.Information);

            txtName.Clear();
            txtPassword.Clear();

        }
    
    }
}
