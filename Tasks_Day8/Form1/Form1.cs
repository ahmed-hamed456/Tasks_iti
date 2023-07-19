namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text == "Admin" && txt_password.Text == "123456")
            {
                MessageBox.Show($"Login button have been clicked\n" +
                                $"Username : {txt_username.Text},Password:{txt_password.Text}\n" +
                                $"is allowed to use the app");
                Calculator calc = new Calculator();
                this.Hide();
                calc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry,Worng username or password");
            }
        }
    }
}