using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
namespace Financeiro
{
    public class Usuario
    {
        public int ID;
        public string NomeUsuario;
        public string Documento;
        public string Endereco;
        public string Cidade;
        public string UF;
        public string CEP;
        public string Numero;
        public string Complemento;
        public byte[] Foto;
        public string Observacao;
        public string Email;
        public string Telefone;
        public string TelefoneCel;
        public DateTime DataNascimento;
        public double Porcentagem;
        public string Senha;

        public bool Carregar()
        {
            if (!Funcoes.Conectado)
            {
                Funcoes.Mensagem("Não conectado a base de dados", "Atenção", "stp");
                return false;
            }
            MySqlConnection con = Funcoes.mConn;
            string sql = "SELECT * FROM usuario WHERE NomeUsuario = ";
            sql += this.NomeUsuario;

            MySqlCommand comand = new MySqlCommand(sql,con);
            MySqlDataReader rdr = comand.ExecuteReader();
            if (!rdr.HasRows)
            {
                Funcoes.Mensagem("Usuário não encontrado!", "Atenção", "inf");
                return false;
            }
            while (rdr.Read())
            {
                this.ID = rdr.GetInt32("ID_USR");
                this.NomeUsuario = rdr.GetString("NomeUsuario");
                this.Documento = string.IsNullOrEmpty(rdr.GetString("Documento")) ? "" : rdr.GetString("Documento");
                this.Endereco = string.IsNullOrEmpty(rdr.GetString("Endereco")) ? "" : rdr.GetString("Endereco");
                this.Cidade = string.IsNullOrEmpty(rdr.GetString("Cidade")) ? "" : rdr.GetString("Cidade");
                this.UF = string.IsNullOrEmpty(rdr.GetString("UF")) ? "" : rdr.GetString("UF");
                this.CEP = string.IsNullOrEmpty(rdr.GetString("CEP")) ? "" : rdr.GetString("CEP");
                this.Numero = string.IsNullOrEmpty(rdr.GetString("Numero")) ? "" : rdr.GetString("Numero");
                this.Complemento = string.IsNullOrEmpty(rdr.GetString("Complemento")) ? "" : rdr.GetString("Complemento");
                //this.Foto = rdr.Get ("NomeUsuario");
                this.Observacao = string.IsNullOrEmpty(rdr.GetString("Observacao")) ? "" : rdr.GetString("Observacao");
                this.Email = string.IsNullOrEmpty(rdr.GetString("Email")) ? "" : rdr.GetString("Email");
                this.Telefone = string.IsNullOrEmpty(rdr.GetString("Telefone")) ? "" : rdr.GetString("Telefone");
                this.TelefoneCel = string.IsNullOrEmpty(rdr.GetString("TelefoneCel")) ? "" : rdr.GetString("TelefoneCel");
                this.DataNascimento = (rdr.GetDateTime("DataNascimento") == null) ? new DateTime() : rdr.GetDateTime("DataNascimento");
                this.Porcentagem = (rdr.GetDouble("Porcentagem") == null) ? 0 : rdr.GetDouble("Porcentagem");
                this.Senha = string.IsNullOrEmpty(rdr.GetString("Senha")) ? "" : rdr.GetString("Senha");
            }
            return false;
        }   
    }
}
