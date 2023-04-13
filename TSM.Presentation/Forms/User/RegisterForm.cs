using TSM.Application.Interfaces;
using TSM.Application.ViewModels;
using TSMWebDeveloper;

namespace TSM.Presentation.Forms.User
{
    public partial class RegisterForm : Form
    {
        private readonly StartForm _startForm;
        private readonly IUserService _userService;

        public RegisterForm(StartForm startForm, IUserService userService)
        {
            InitializeComponent();
            nameTextBox.Focus();

            _startForm = startForm;
            _userService = userService;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _startForm.showLoginForm();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria um novo usuário com os dados informados
                var user = new UserViewModel
                {
                    Name = nameTextBox.Text,
                    Email = mailTextBox.Text,
                    Password = passwordTextBox.Text
                };

                // Adiciona o novo usuário
                _userService.AddUser(user);

                // Exibe uma mensagem de sucesso
                MessageBox.Show("Usuário cadastrado com sucesso!");

                // Redireciona para a página de login
                _startForm.showLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
