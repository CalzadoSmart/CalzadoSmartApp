using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrameWork.Negocio;
using Entidades.Framework;

namespace Framework.Vista
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            OcultarError();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String NombreUsuario = txtUsuario.Text;
            String Contrasenia = txtContrasenia.Text;
            OcultarError();
            try {
                new LoginBU().Login(NombreUsuario, Contrasenia);
                if (SesionUsuario.Usuario != null)
                {
                    //ABRIR FORMULARIO PRINCIPAL;
                    System.Windows.Forms.MessageBox.Show("Bienvenido al sistema CalzadoSmart");
                }
                else
                {
                    MostrarError();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void MostrarError()
        {
            this.pnlError.Height = 73;
            this.Height += this.pnlError.Height;
        }

        private void OcultarError()
        {
            this.Height -= this.pnlError.Height;
            this.pnlError.Height = 0;
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
            
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //GetNextControl(ActiveControl, true).Focus();
                btnIngresar.Focus();
                btnIngresar.PerformClick();
            }
        }
    }
}
