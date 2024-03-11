using KeyAuth;
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

namespace LicenseSystem
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static api KeyAuthApp = new api(
    name: "", //your name
    ownerid: "", //your ownerid
    secret: "", //your secret
    version: "" //Your version (For example 1.0)
);
        public MainWindow()
        {
            InitializeComponent();
            KeyAuthApp.init(); //Fix the KeyAuthApp.init(); error
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            KeyAuthApp.license(licenseTextbox.Text);
            if(KeyAuthApp.response.success)
            {
                MessageBox.Show("Valid License!\nWelcome",
                    "Succes", //Your Title
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                new Main().Show();
                this.Hide();
            }
            else 
            {
                //When the License is invalid or the HWID doesn't match
                MessageBox.Show(KeyAuthApp.response.message,
                    "Error", //Your Title
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}
