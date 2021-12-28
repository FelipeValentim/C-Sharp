using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseTXT
{
    public interface IPessoa
    {
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetCPF (string cpf);
        void Gravar();
    }
}
