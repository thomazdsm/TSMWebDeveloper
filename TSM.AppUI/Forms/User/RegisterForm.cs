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
    public partial class RegisterForm : Form
    {
        private readonly StartForm startForm;

        public RegisterForm(StartForm startForm)
        {
            InitializeComponent();
            nameTextBox.Focus();
            this.startForm = startForm;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            startForm.showLoginForm();
        }
    }
}
