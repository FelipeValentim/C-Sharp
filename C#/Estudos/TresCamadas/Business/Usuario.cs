using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using DatabaseSQL;

namespace Business
{
    public class Usuario : Base 
    {
        public Usuario(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        public Usuario() { }
    }
}
