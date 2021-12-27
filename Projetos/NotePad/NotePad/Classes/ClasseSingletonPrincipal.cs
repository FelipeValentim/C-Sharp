using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace NotePad
{
    public class ClasseSingletonPrincipal
    {
        private ClasseSingletonPrincipal() { }
        private static FormPrincipal instanciaSingleton;

        public static FormPrincipal CriarInstanciaSingleton()
        {
            if (instanciaSingleton == null)
            {
                instanciaSingleton = new FormPrincipal();
                return instanciaSingleton;
            }
            else
            {
                return instanciaSingleton;
            }
            
        }
    }

}
