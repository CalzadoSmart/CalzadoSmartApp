using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Framework
{
    public static class SesionUsuario
    {
        private static Usuario _usuario;

        public static Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

    }
}
