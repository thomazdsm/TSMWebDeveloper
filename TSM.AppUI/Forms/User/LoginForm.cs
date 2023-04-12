using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TSMWebDeveloper;

namespace TSM.AppUI.Forms.User
{
    public partial class LoginForm : Form
    {
        private readonly StartForm startForm;

        public LoginForm(StartForm startForm)
        {
            InitializeComponent();
            mailTextBox.Focus();
            this.startForm = startForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            startForm.showRegisterForm();
        }
    }
}
