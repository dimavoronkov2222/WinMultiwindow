using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WinMultiwindow
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string a = name.Text;
            string b = Surname.Text;
            string c = Addres.Text;
            string d = number.Text;
            string f = login.Text;
            string g = Pass1.Text;
            if (Pass1.Text == Pass2.Text)
            {
                User.name = a;
                User.surname = b;
                User.addres = c;
                User.phone = d;
                User.login = f;
                User.password = g;
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void signup_Load(object sender, EventArgs e)
        {
        }
    }
}