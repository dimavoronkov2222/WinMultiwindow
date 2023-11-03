using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WinMultiwindow.Core;
namespace WinMultiwindow
{
    public partial class EditForm : Form
    {
        public Good? good { get; set; } = null;
        public EditForm()
        {
            InitializeComponent();
        }
        public EditForm(Good good)
        {
            InitializeComponent();
            this.good = good;
            name.Text = good.Name;
            author.Text = good.Author;
            year.Text = good.Year_of_publication;
            genre.Text = good.Genre;
            isbn.Text = good.ISBN;
            return_date.Text = good.Return_date;
            date_of_issue.Text = good.date_of_issue;
            price.Text = good.Price;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (good == null)
            {
                good = new Good();
            }
            good.Name = name.Text;
            good.Author = author.Text;
            good.Year_of_publication = year.Text;
            good.Genre = genre.Text;
            good.ISBN = isbn.Text;
            good.Return_date = return_date.Text;
            good.date_of_issue = date_of_issue.Text;
            good.Price = price.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
