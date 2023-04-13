using TSM.Infra.Data.Context;
using TSM.Presentation.Forms.User;

namespace TSMWebDeveloper
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            showLoginForm();
        }

        public void showLoginForm()
        {
            Panel painel = leftPanel;
            var login = new LoginForm(this);
            login.TopLevel = false;
            login.Parent = painel;
            login.Dock = DockStyle.Fill;
            painel.Controls.Clear();
            painel.Controls.Add(login);
            login.Visible = true;
        }

        public void showRegisterForm()
        {
            Panel painel = leftPanel;
            var login = new RegisterForm(this);
            login.TopLevel = false;
            login.Parent = painel;
            login.Dock = DockStyle.Fill;
            painel.Controls.Clear();
            painel.Controls.Add(login);
            login.Visible = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}