using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio_Validacion
{
    public partial class Frmvalidaciones : Form
    {
        ValidarTexbox Validacion = new ValidarTexbox();
        public Frmvalidaciones()
        {
            InitializeComponent();
        }

        private void Btnvalidar_Click(object sender, EventArgs e)
        {

            TipoValidaciones();
          
        }


        //----------------------METODOS O FUNCIONES-------------------------------------- 
        private void Limpiar()
        {
            Txtnombre.Clear();
            Txtcodigo.Clear();
            TxtCorreo.Clear();
            Txtcontraseña.Clear();
            Txtnombre.Focus();
        }

        private void TipoValidaciones()
        {
            if (!Validacion.Vacio(Txtnombre, ErrorMensaje, "El Nombre no puede estar vacio"))
                if (Validacion.TipoTexto(Txtnombre, ErrorMensaje, "Solo es permitido ingresar texto"))
                    if (!Validacion.Vacio(Txtcodigo, ErrorMensaje, "El Nombre no puede estar vacio"))
                        if (Validacion.TipoNumerico(Txtcodigo, ErrorMensaje, "Solo es permitido ingresar numeros"))
                            if (!Validacion.Vacio(TxtCorreo, ErrorMensaje, "El Nombre no puede estar vacio"))
                                if (Validacion.TipoCorreo(TxtCorreo, ErrorMensaje, "Solo es permitido ingresar correo electronico valido"))
                                    if (!Validacion.Vacio(Txtcontraseña, ErrorMensaje, "La contraseña no puede estar vacio"))
                                        if (Validacion.TipoContraseña(Txtcontraseña, ErrorMensaje, "Solo es permitido ingresar una contraña valida"))
                                        {
                                            LblMostrarResultado.Text = "Todos los campos estan llenos";
                                            Limpiar();

                                        }

        }
     
    }
}
