using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Financeiro
{
    public partial class TelaConfig : Form
    {
        public TelaConfig()
        {
            InitializeComponent();
        }

        private void BtnTestar_Click(object sender, EventArgs e)
        {
            if (Testar())
            {
                Funcoes.Mensagem("Conectado com Sucesso\nNão se esqueça de Salvar","Conectado","exc");
            }
        }

        
        public bool Testar()
        {
            string con = "Persist Security Info=False;";
            con += "server=" + txtServidor.Text.Trim() + ";";
            con += "database=" + txtBase.Text.Trim() + ";";
            con += "uid=" + txtUsuario.Text.Trim() + ";";
            con += "server=" + txtServidor.Text.Trim() + ";";
            con += "database=" + txtBase.Text.Trim() + ";";
            con += "uid=" + txtUsuario.Text.Trim() + ";";
            con += "pwd=" + txtSenha.Text.Trim();
            MySqlConnection mConn = new MySqlConnection(con);
            try
            {
                //abre a conexao
                mConn.Open();
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();

        }

        void Salvar()
        {
            Properties.Settings.Default.Servidor    = txtServidor.Text.Trim();
            Properties.Settings.Default.Porta       = txtPorta.Text.Trim();
            Properties.Settings.Default.BaseDeDados = txtBase.Text.Trim();
            Properties.Settings.Default.Usuario     = txtUsuario.Text.Trim();
            Properties.Settings.Default.Senha       = txtSenha.Text.Trim();
            Properties.Settings.Default.Save();
        }

        void Carregar()
        {
            txtServidor.Text = Properties.Settings.Default.Servidor;
            txtPorta.Text = Properties.Settings.Default.Porta;
            txtBase.Text = Properties.Settings.Default.BaseDeDados;
            txtUsuario.Text = Properties.Settings.Default.Usuario;
            txtSenha.Text = Properties.Settings.Default.Senha;
        }

        private void TelaConfig_Load(object sender, EventArgs e)
        {
            Carregar();
        }
    }
}
