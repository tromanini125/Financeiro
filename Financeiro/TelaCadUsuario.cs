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
    public partial class TelaCadUsuario : Form
    {
        public TelaCadUsuario()
        {
            InitializeComponent();
        }

        public void CarregarTodos()
        {
            string sql = "SELECT * FROM usuario ORDER BY NomeUsuario";
            
        }
    }
}
