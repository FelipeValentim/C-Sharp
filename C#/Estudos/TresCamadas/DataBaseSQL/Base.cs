using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseSQL;

namespace DatabaseSQL
{
    public abstract class Base : IPessoa
    {
        public string Nome, Telefone, CPF;  // atributos publicos podem ser acessados de qualquer lugar

        public void SetNome(string nome) //
        {
            this.Nome = nome;
        }
        public void SetTelefone(string telefone)
        {
            this.Telefone = telefone;
        }
        public void SetCPF(string cpf)
        {
            this.CPF = cpf;
        }

        /*private static string Caminho(string caminho) // Tentei fazer dessa forma
        {
            return ConfigurationManager.AppSettings[caminho]; 
        }*/

        /// <summary>
        /// Construtor do usuário
        /// </summary>
        /// <param name="nome">Nome</param>
        /// <param name="telefone">Telefone</param>
        /// <param name="cpf">CPF</param>
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        public Base() { }

        internal string CaminhoDB()
        {
            return ConfigurationManager.AppSettings["SQLConnection"];
        }

        public virtual void Gravar()
        {
            string connectionString = CaminhoDB();
            using (SqlConnection connection = new SqlConnection(
               connectionString))
            {
                string queryString = "insert into " + this.GetType().Name + "s(nome, telefone, cpf) values('" + this.Nome + "','" + this.Telefone + "','" + this.CPF + "');";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            //
        }

    }
}
