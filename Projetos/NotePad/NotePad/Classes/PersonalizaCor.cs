using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Classes
{
    public class PersonalizaCor
    {
        private PersonalizaCor() { }
        private PersonalizaCor(int quantidadeElementos)
        {
            GetColor = new int[quantidadeElementos];
        }

        public int[] GetColor
        {
            get;
            set;
        }
        
        public static PersonalizaCor Instance = new PersonalizaCor(3);
        // public static readonly PersonalizaCor Instance = new PersonalizaCor(3);

    }
}
