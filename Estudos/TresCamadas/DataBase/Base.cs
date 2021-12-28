using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;

namespace DatabaseTXT
{
    public class Base : IPessoa
    {
        public string Nome, Telefone, CPF, CNPJ;  // atributos publicos podem ser acessados de qualquer lugar

        public void SetNome(string nome)
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

        public void SetCNPJ(string cnpj)
        {
            this.CNPJ = cnpj;
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
        public Base(string nome, string telefone, string cpf, string cnpj)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
            this.CNPJ = cnpj;
        }

        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        public Base() { }

        internal string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["CaminhoDB"] + this.GetType().Name + ".txt";
        }

        public virtual List<IPessoa> Ler()
        {
            var dados = new List<IPessoa>();

            if (File.Exists(CaminhoArquivo()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoArquivo()))
                {
                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        var baseArquivo = linha.Split(';');

                        var pessoa = (IPessoa)Activator.CreateInstance(this.GetType());
                        pessoa.SetNome(baseArquivo[0]);
                        pessoa.SetTelefone(baseArquivo[1]);
                        pessoa.SetCPF(baseArquivo[2]);
                        //var pessoa = new Base(baseArquivo[0], baseArquivo[1], baseArquivo[2]);
                        dados.Add(pessoa);

                    }
                }
            }
            return dados;
        }

        public virtual void Gravar()
        {
            var dados = this.Ler();
            dados.Add(this);

            //if (File.Exists(CaminhoArquivo()))
            //{
            StreamWriter r = new StreamWriter(CaminhoArquivo());
            string conteudo = "nome;telefone;cpf;";
            r.WriteLine(conteudo);
            foreach (Base b in dados)
            {
                r.WriteLine(b.Nome + ";" + b.Telefone + ";" + b.CPF + ";");
            }
            r.Close();
            //}
        }

        protected int CalcularUmMaisDois() // O protected pode ser acessada a partir da herança de outra classe, diferente do private
        {
            return 1 + 2;
        }
        internal int CalcularUmMaisDois2()
        {
            return 1 + 2;
        }
        public int CalcularUmMaisDois3()
        {
            return 1 + 2;
        }

        public virtual void Olhar() // 'virtual' habilita o polimorfismo (sobrescrita)
        {
            Console.WriteLine("O cliente " + this.Nome + " está olhando para mim");
            Console.WriteLine("==================");
        }

    }
}
