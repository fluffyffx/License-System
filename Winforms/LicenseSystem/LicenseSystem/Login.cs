using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseSystem
{
    public partial class Login : Form
    {
        public static api KeyAuthApp = new api(
    name: "", //your name
    ownerid: "", //your ownerid
    secret: "", //your secret
    version: "" //Your version (For example 1.0)
);
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false; //Disable the Maximize Box
            KeyAuthApp.init(); //fix the KeyAuthApp.init(); Error

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.license(textBox1.Text);
            if(KeyAuthApp.response.success)
            {
                MessageBox.Show("Valid License!\nWelcome",
                    "Succes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                new Main().Show();
                this.Hide();
            }
            else
            {
                //When the key is invalid or the HWID doesn't match

                MessageBox.Show(KeyAuthApp.response.message,
                    "Error", //set your title
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
