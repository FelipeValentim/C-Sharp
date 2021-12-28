using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormApplication
{
    public class Estado
    {
        public int Id
        {
            get;
            set;
        }
        public string Nome
        {
            get;
            set;
        }

        public int DDD 
        {
            get;
            set;
        } 

        public override string ToString()
        {
            return this.Nome;
        }

        public static List<Estado> Lista()
        {
            var lista = new List<Estado>();
            var estado1 = new Estado();
            estado1.Id = 1;
            estado1.Nome = "São Paulo";
            lista.Add(estado1);

            estado1 = new Estado();
            estado1.Id = 2;
            estado1.Nome = "Rio de Janeiro";
            lista.Add(estado1);

            estado1 = new Estado();
            estado1.Id = 3;
            estado1.Nome = "Rio Grande do Sul";
            lista.Add(estado1);

            estado1 = new Estado();
            estado1.Id = 4;
            estado1.Nome = "Minas Gerais";
            lista.Add(estado1);

            estado1 = new Estado();
            estado1.Id = 5;
            estado1.Nome = "Bahia";
            lista.Add(estado1);

            return lista;

        }
    }
}
