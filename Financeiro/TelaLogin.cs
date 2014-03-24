using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Financeiro
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void LinkConfiguracoes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new TelaConfig().ShowDialog();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            Funcoes.conecta();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario usr = new Usuario();
            usr.NomeUsuario = txtUsuario.Text;
            usr.Senha = txtSenha.Text;
            usr.Carregar();
        }
    }
}
