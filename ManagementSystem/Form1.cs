#nullable disable

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ManagementSystem
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string enteredToken = TokenTB.Text;

            using (ManagementSystemContext ctx = new ManagementSystemContext())
            {
                Admin matchingAdmin = ctx.Admins.FirstOrDefault(admin => admin.Token == enteredToken);

                if (matchingAdmin != null)
                {
                    string adminName = matchingAdmin.Name;
                    
                    this.Hide();
                    MenuForm menuForm = new MenuForm(enteredToken, adminName);
                    menuForm.StartPosition = FormStartPosition.CenterScreen;
                    menuForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Token", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}