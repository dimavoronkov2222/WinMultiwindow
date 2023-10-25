namespace WinMultiwindow
{
    public partial class LoginForm : Form
    {
        string username = "admin";
        string password = "admin";
        public LoginForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbLogin.Text == username && password == tbPassword.Text)
            {
                this.Visible = false;
                MessageBox.Show("Â³òàºìî, " + username + "!", "Óñï³õ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomeForm homeForm = new HomeForm(this);
                var result = homeForm.ShowDialog();
                if (DialogResult.Cancel == result)
                {
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error opening the form!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Incorrect login or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}