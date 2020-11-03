using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Ejercicio_Validacion
{
    class ValidarTexbox
    {
        //------------------------- Validar que la caja de texto este vacia -------------------------------
        public Boolean Vacio(TextBox Caja, ErrorProvider Error, String MensajeError)
        {
            if (Caja.Text == "")
            {
                Error.SetError(Caja, MensajeError);
                Caja.Focus();
                return true;
            }
            else
            {
                Error.Clear();
                return false;
            }
        }

        //------------------------- Validar que la caja de texto cumpla con entradas de texto -------------------------------

        public Boolean TipoTexto(TextBox Caja, ErrorProvider Error, String MensajeError)
        {
            Regex FormatoTexto = new Regex("^[a-zA-Z ]*$");
            if (!FormatoTexto.IsMatch(Caja.Text))
            {
                Error.SetError(Caja, MensajeError);
                Caja.Focus();
                return false;
            }
            else
            {
                Error.Clear();
                return true;
            }

        }

        //------------------------- Validar que la caja de texto cumpla con entradas numericas -------------------------------

        public Boolean TipoNumerico(TextBox Caja, ErrorProvider Error, String MensajeError)
        {
            Regex FormatoNumerico = new Regex("[0-9]{1,9}(\\.[0-9]{0,2})?$");
            if (!FormatoNumerico.IsMatch(Caja.Text))
            {
                Error.SetError(Caja, MensajeError);
                Caja.Focus();
                return false;
            }
            else
            {
                Error.Clear();
                return true;
            }

        }

        //------------------------- Validar que la caja de texto cumpla con entradas de correo electronico -------------------------------

        public Boolean TipoCorreo(TextBox Caja, ErrorProvider Error, String MensajeError)
        {
            Regex FormatoCorreo = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"
);
            if (!FormatoCorreo.IsMatch(Caja.Text))
            {
                Error.SetError(Caja, MensajeError);
                Caja.Focus();
                return false;
            }
            else
            {
                Error.Clear();
                return true;
            }
        }

        //-----------------------------------Validar que la caja de contraseña sea valida-------------------------------

        public Boolean TipoContraseña(TextBox Caja, ErrorProvider Error, String MensajeError)
        {
            Regex FormatoContraseña = new  Regex(@"^(.{0,7}|[^0-9]*|[^a-z]*|[^A-Z])$");

            if (!FormatoContraseña.IsMatch(Caja.Text))
            {
                Error.SetError(Caja, MensajeError);
                Caja.Focus();
                return false;
            }
           else
           {
                Error.Clear();
                 return true;
           }


        }
        

    }
}


