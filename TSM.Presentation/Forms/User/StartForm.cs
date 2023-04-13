using Microsoft.Extensions.DependencyInjection;
using TSM.Application.Interfaces;
using TSM.Application.Services;
using TSM.Presentation.Forms.User;

namespace TSMWebDeveloper
{
    public partial class StartForm : Form
    {

        private readonly IUserService _userService;

        public StartForm(IServiceProvider serviceProvider)
        {
            _userService = serviceProvider.GetRequiredService<IUserService>();

            InitializeComponent();
            showLoginForm();
        }

        public void showLoginForm()
        {
            Panel painel = leftPanel;
            var loginForm = new LoginForm(this);
            loginForm.TopLevel = false;
            loginForm.Parent = painel;
            loginForm.Dock = DockStyle.Fill;
            painel.Controls.Clear();
            painel.Controls.Add(loginForm);
            loginForm.Visible = true;
        }

        public void showRegisterForm()
        {
            Panel painel = leftPanel;
            var registerForm = new RegisterForm(this, _userService);
            registerForm.TopLevel = false;
            registerForm.Parent = painel;
            registerForm.Dock = DockStyle.Fill;
            painel.Controls.Clear();
            painel.Controls.Add(registerForm);
            registerForm.Visible = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}