using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Financeiro
{
    public class Funcoes
    {

        public static void Mensagem(string msg, string titulo, string tipo)
        {
            MessageBoxIcon icon = new MessageBoxIcon();
            switch (tipo)
            {
                case "inf":
                    icon = MessageBoxIcon.Information;
                    break;
                case "exc":
                    icon = MessageBoxIcon.Exclamation;
                    break;
                case "avi":
                    icon = MessageBoxIcon.Warning;
                    break;
                case "stp":
                    icon = MessageBoxIcon.Stop;
                    break;
                case "han":
                    icon = MessageBoxIcon.Hand;
                    break;

            }
            MessageBox.Show(null, msg, titulo, MessageBoxButtons.OK, icon);
        }

        //privados
        public static MySqlConnection mConn;
        public static bool Conectado = false;
        
        public static bool conecta()
        {
            string con = "Persist Security Info=False;";
            con += "server=" + Properties.Settings.Default.Servidor + ";";
            con += "database=" + Properties.Settings.Default.BaseDeDados + ";";
            con += "uid=" + Properties.Settings.Default.Usuario + ";";
            con += "server=" + Properties.Settings.Default.Servidor + ";";
            con += "database=" + Properties.Settings.Default.BaseDeDados + ";";
            con += "uid=" + Properties.Settings.Default.Usuario + ";";
            con += "pwd=" + Properties.Settings.Default.Senha;

            mConn = new MySqlConnection(con);
            try
            {
                //abre a conexao
                mConn.Open();
                Conectado = true;
                return true;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
