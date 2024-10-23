using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Persistencia.Utils;
using Datos;
using FontAwesome.Sharp;


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

        // Método para configurar el autocompletado en un TextBox
        public static void ConfigurarAutoComplete(TextBox textBox, string nombreArchivo)
        {
            DBHelper dbHelper = new DBHelper(nombreArchivo);
            List<string> datos = dbHelper.Listar();

            AutoCompleteStringCollection dataCollection = new AutoCompleteStringCollection();
            dataCollection.AddRange(datos.ToArray());

            textBox.AutoCompleteCustomSource = dataCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        // Método para guardar una sugerencia en el archivo
        public static void GuardarSugerencia(string dato, string nombreArchivo)
        {
            DBHelper dbHelper = new DBHelper(nombreArchivo);
            List<string> datosGuardados = dbHelper.Listar();

            if (!datosGuardados.Contains(dato))
            {
                nombreArchivo = string.Concat(nombreArchivo, ".txt");
                datosGuardados.Add(dato);
                File.WriteAllLines(nombreArchivo, datosGuardados);
            }
        }

        //metodo para borrar una sugerencia de todos los archivos
        public static void BorrarSugerencia(string dato)
        {
            string solutionDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //Busca todos los archivos en el directorio actual de la solucion
            string[] archivos = Directory.GetFiles(solutionDirectory, "*.txt", SearchOption.TopDirectoryOnly);

            foreach (string archivo in archivos)
            {
                DBHelper dbHelper = new DBHelper(archivo);
                List<string> datosGuardados = dbHelper.Listar();

                if (datosGuardados.Contains(dato))
                {
                    datosGuardados.Remove(dato);
                    File.WriteAllLines(archivo, datosGuardados);
                }
            }
        }

        //Metodo para devolver a que pantalla redirigir segun el perfil del usuario, devolviendo el objeto de la pantalla
        public static Form PantallaInicialUsuario(UsuarioWS usuario)
        {
            switch (usuario.Host)
            {
                case 1: // Vendedor
                    //return new Perfil_Vendedor();
                case 2: // Supervisor
                    //return new Perfil_Supervisor();
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
                if (formActivo.Text == form.Text)
                {
                    //formActivo.Hide();
                    return;
                }
                formActivo.Hide();
            }

            FormPrevio = formActivo;
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
                if (formActivo.Text == form.Text)
                {
                    //formActivo.Hide();
                    return;
                }
                formActivo.Hide();
            }

            formActivo = FormPrevio;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            contenedor.Controls.Add(form);
            PanelContenedor = contenedor;
            PanelContenedor.Controls.Add(form);
            form.Show();
        }
    }
}
