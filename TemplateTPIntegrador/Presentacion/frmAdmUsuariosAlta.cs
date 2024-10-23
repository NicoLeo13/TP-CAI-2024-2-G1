﻿using Presentacion.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class frmAdmUsuariosAlta : Form
    {
        public frmAdmUsuariosAlta()
        {
            InitializeComponent();
        }

        private void frmAdmUsuariosAlta_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> hosts = new Dictionary<int, string>
            {
                { 3, "Administrador" },
                { 2, "Supervisor" },
                { 1, "Usuario" }
            };

            comboBoxHost.DataSource = new BindingSource(hosts, null);
            comboBoxHost.DisplayMember = "Value";
            comboBoxHost.ValueMember = "Key";
            comboBoxHost.SelectedIndex = -1;
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamo al método de agregar usuario de la capa de negocio
                string nombreUsuario = txtBoxUsuario.Text;

                UsuarioService usuarioService = new UsuarioService();
                usuarioService.AgregarUsuario(
                    Guid.NewGuid(),
                    txtBoxNombre.Text,
                    txtBoxApellido.Text,
                    txtBoxDireccion.Text,
                    txtBoxTelefono.Text,
                    txtBoxEmail.Text,
                    dtpFechaNac.Value,
                    txtBoxUsuario.Text,
                    (int)comboBoxHost.SelectedValue,
                    Convert.ToInt32(txtBoxDni.Text),
                    txtBoxContraseña.Text
                );

                MessageBox.Show($"Usuario {nombreUsuario} agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException ex)
            {
                // Capturar excepciones específicas como FormatException
                MessageBox.Show($"Error en el formato de los datos: {ex.Message} - {ex.Source}", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error interno:\n{ex.Message} - {ex.Source}", "Error programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Capturar cualquier otra excepción
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
        }

        private void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                else if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            PresentacionUtils.VolverFormPrevio((IconButton)sender, PresentacionUtils.FormPrevio, PresentacionUtils.PanelContenedor);
        }

    }
}
