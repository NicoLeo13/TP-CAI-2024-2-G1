﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Persistencia.Utils;
using Datos;
using FontAwesome.Sharp;
using System.Security.Cryptography.X509Certificates;


namespace Presentacion.Utils
{
    internal class PresentacionUtils
    {
        private static bool formClosing = false;
        private static Form formActivo = null;
        private static Form formPrevio = null;
        private static IconButton menuActivo = null;
        private static Panel panelContenedor = null;

        public static bool isFormClosing { get; set; }
        public static Panel PanelContenedor { get; set; }
        public static Form FormPrevio { get; set; }

        //Metodo para devolver a que pantalla redirigir segun el perfil del usuario, devolviendo el objeto de la pantalla
        public static Form PantallaInicialUsuario(UsuarioWS usuario)
        {
            switch (usuario.Host)
            {
                case 1: // Vendedor
                    return new frmPerfilVendedor(usuario);
                case 2: // Supervisor
                    return new frmPerfilSupervisor(usuario);
                case 3: // Administrador
                    return new frmPerfilAdministrador(usuario);
                default:
                    throw new ArgumentException("Inicio de sesión correcto.\nPerfil de usuario no reconocido.");
            }
        }

        public static void AbrirForm(IconButton boton, Form form, Panel contenedor)
        {
            if (formActivo != null)
            {
                FormPrevio = formActivo;
                if (formActivo.Text == form.Text)
                {
                    //formActivo.Hide();
                    return;
                }
                
                formActivo.Hide();
            }

            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contenedor.Controls.Add(form);
            PanelContenedor = contenedor;
            PanelContenedor.Controls.Add(form);
            form.Show();
        }

        public static void VolverFormPrevio(IconButton boton, Form form, Panel contenedor)
        {
            if (formActivo != null)
            {
                formActivo.Hide();
            }
            if (FormPrevio != null)
            {
                FormPrevio.Show(); 
                formActivo = FormPrevio; 
            }
            contenedor.Controls.Clear();

            formActivo = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contenedor.Controls.Add(form);
            PanelContenedor = contenedor;
            PanelContenedor.Controls.Add(form);
            if (!PanelContenedor.Controls.Contains(form))
            {
                PanelContenedor.Controls.Add(form);
            }
            form.Show();
        }

        public static void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();

                    if (textBox.BackColor == System.Drawing.Color.DarkRed)
                    {
                        textBox.BorderStyle = BorderStyle.Fixed3D;
                        textBox.BackColor = System.Drawing.Color.White;
                        textBox.ForeColor = System.Drawing.Color.Black;
                    }
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;

                    if (comboBox.BackColor == System.Drawing.Color.DarkRed)
                    {
                        comboBox.FlatStyle = FlatStyle.Standard;
                        comboBox.BackColor = System.Drawing.Color.White;
                        comboBox.ForeColor = System.Drawing.Color.Black;
                    }
                }
                else if (control is DateTimePicker dtmPicker)
                {
                    dtmPicker.Value = DateTime.Now;

                    if (dtmPicker.BackColor == System.Drawing.Color.DarkRed)
                    {
                        dtmPicker.BackColor = System.Drawing.Color.White;
                        dtmPicker.ForeColor = System.Drawing.Color.Black;
                    }
                }
                else if (control.HasChildren)
                {
                    LimpiarControles(control);      // Recursividad para limpiar controles del control actual
                }
            }
        }

        public static void HabilitarControles(Control parent)
        {
            //Si parent no tiene controles y es uno solo se habilita
            if (parent.Controls.Count == 0)
            {
                if (parent is TextBox textBox)
                {
                    textBox.Enabled = true;
                    textBox.BackColor = System.Drawing.Color.White;
                }
                else if (parent is ComboBox comboBox)
                {
                    comboBox.Enabled = true;
                    comboBox.BackColor = System.Drawing.Color.White;
                }
                else if (parent is DateTimePicker dtmPicker)
                {
                    dtmPicker.Enabled = true;
                    dtmPicker.BackColor = System.Drawing.Color.White;
                }
                return;
            }

            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = true;
                    textBox.BackColor = System.Drawing.Color.White;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = true;
                    comboBox.BackColor = System.Drawing.Color.White;
                }
                else if (control is DateTimePicker dtmPicker)
                {
                    dtmPicker.Enabled = true;
                    dtmPicker.BackColor = System.Drawing.Color.White;
                }
                else if (control.HasChildren)
                {
                    HabilitarControles(control);      // Recursividad para habilitar controles del control actual
                }
            }
        }

        public static void DeshabilitarControles(Control parent)
        {
            //Si parent no tiene controles y es uno solo se deshabilita
            if (parent.Controls.Count == 0)
            {
                if (parent is TextBox textBox)
                {
                    textBox.Enabled = false;
                    textBox.BackColor = System.Drawing.SystemColors.ControlDark;
                }
                else if (parent is ComboBox comboBox)
                {
                    comboBox.Enabled = false;
                    comboBox.BackColor = System.Drawing.SystemColors.ControlDark;
                }
                else if (parent is DateTimePicker dtmPicker)
                {
                    dtmPicker.Enabled = false;
                    dtmPicker.BackColor = System.Drawing.SystemColors.ControlDark;
                }
                return;
            }

            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                    textBox.BackColor = System.Drawing.SystemColors.ControlDark;
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = false;
                    comboBox.BackColor = System.Drawing.SystemColors.ControlDark;
                }
                else if (control is DateTimePicker dtmPicker)
                {
                    dtmPicker.Enabled = false;
                    dtmPicker.BackColor = System.Drawing.SystemColors.ControlDark;
                }
                else if (control.HasChildren)
                {
                    DeshabilitarControles(control);      // Recursividad para deshabilitar controles del control actual
                }
            }
        }

        public static string HostToString(int host)
        {
            switch (host)
            {
                case 1:
                    return "Vendedor";
                case 2:
                    return "Supervisor";
                case 3:
                    return "Administrador";
                default:
                    return "No definido";
            }
        }
    }
}
