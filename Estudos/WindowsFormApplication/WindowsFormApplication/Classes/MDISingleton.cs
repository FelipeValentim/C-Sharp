using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormApplication.Classes
{
    public class MDISingleton
    {
        private MDISingleton()
        {

        }

        private static MDIParentPrincipal instanciaMDI;
        public static MDIParentPrincipal CriarInstancia()
        {
            if (instanciaMDI == null)
            {
                instanciaMDI = new MDIParentPrincipal();
                return instanciaMDI;
            }
            else
            {
                return instanciaMDI;
            }
        }
    }
}
