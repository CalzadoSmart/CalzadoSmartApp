using System;

namespace Entidades.Framework
{
    public class Usuario
    {
        private int usuarioid;
        private String username;
        private String claveacceso;
        private DateTime fechacreacion;
        private int colaboradorid;
        private bool activo;

        public Usuario() { }
        public Usuario(int usuarioid, String username, String claveacceso, DateTime fechacreacion, int colaboradorid, bool activo)
        {
            this.usuarioid = usuarioid;
            this.username = username;
            this.claveacceso = claveacceso;
            this.fechacreacion = fechacreacion;
            this.colaboradorid = colaboradorid;
            this.activo = activo;
        }

        public int UsuarioId 
        { 
            get { return usuarioid; } 
            set { usuarioid = value; }
        }
        
        public String UserName
        {
            get { return username; }
            set { username = value; }
        }

        public String ClaveAcceso
        {
            get { return claveacceso; }
            set { claveacceso = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechacreacion; }
            set { fechacreacion = value; }
        }

        public int ColaboradorId
        {
            get { return colaboradorid; }
            set { colaboradorid = value; }
        }

        public bool Activo
        {
            get { return activo; }
            set { activo = value; }
        }

    }
}
