using EF_Posts.Models;

namespace EF_Posts
{
    public partial class Form1 : Form
    {
        PostsContext context = new PostsContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //var result = context.Authors.Select(e => new { e.ID, e.Name, e.Age,e.Email,e.Password }).ToList();

            var result = context.Authors.Select(e => new { e.ID, e.Name, e.Age, e.Email, e.Password }).ToList();
            dgv_Authors.DataSource = result;
            ButtonsDisplay(true);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = new Author()
                {
                    Name = txt_name.Text,
                    Age = (int)nup_age.Value,
                    Email = txt_email.Text,
                    Password = txt_password.Text,
                };
                context.Authors.Add(author);
                context.SaveChanges();
                MessageBox.Show("Data have been added");
                dgv_Authors.DataSource = context.Authors.Select(e => new { e.ID, e.Name, e.Age, e.Email, e.Password }).ToList();
                ClearInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Something went wrong\n{ex}");
            }
        }

        int id = 0;
        private void dgv_Authors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dgv_Authors.SelectedRows[0].Cells[0].Value;
            Author author =context.Authors.Where(a=>a.ID== id).SingleOrDefault();
            txt_name.Text = author.Name;
            txt_email.Text = author.Email;
            nup_age.Value = author.Age;
            txt_password.Text = author.Password;
            ButtonsDisplay(false);

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = context.Authors.Where(a => a.ID == id).SingleOrDefault();
                author.Name = txt_name.Text;
                author.Email = txt_email.Text;
                author.Age = (int)nup_age.Value;
                author.Password = txt_password.Text;

                context.SaveChanges();
                MessageBox.Show("Data have been Updated");
                dgv_Authors.DataSource = context.Authors.Select(e => new { e.ID, e.Name, e.Age, e.Email, e.Password }).ToList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n{ex}");

            }
            ButtonsDisplay(true);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                Author author = context.Authors.Where(a => a.ID == id).SingleOrDefault();
                context.Authors.Remove(author);
                context.SaveChanges();
                MessageBox.Show("Data have been deleted");
                dgv_Authors.DataSource = context.Authors.Select(e => new { e.ID, e.Name, e.Age, e.Email, e.Password }).ToList();
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Something went wrong\n{ex}");
            }
            ButtonsDisplay(true);
        }

        void ClearInputs()
        {
            txt_email.Text = txt_name.Text = txt_password.Text = "";
            nup_age.Value = 0;
        }

        void ButtonsDisplay(bool visible)
        {
            btn_add.Visible = visible;
            btn_Update.Visible = !visible;
            btn_Delete.Visible = !visible;
        }
    }
}