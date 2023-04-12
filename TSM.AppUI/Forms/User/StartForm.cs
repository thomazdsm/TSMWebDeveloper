using TSM.AppUI.Forms.User;
using TSM.Infra.Data;

namespace TSMWebDeveloper
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            showLoginForm();
        }

        private void showLoginForm()
        {
            Panel painel = leftPanel;
            var login = new LoginForm();
            login.TopLevel = false;
            login.Parent = painel;
            login.Dock = DockStyle.Fill;
            painel.Controls.Clear();
            painel.Controls.Add(login);
            login.Visible = true;
        }

        private void showRegisterForm()
        {
            Panel painel = leftPanel;
            var login = new RegisterForm();
            login.TopLevel = false;
            login.Parent = painel;
            login.Dock = DockStyle.Fill;
            painel.Controls.Clear();
            painel.Controls.Add(login);
            login.Visible = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            showLoginForm();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            showRegisterForm();
        }
    }
}