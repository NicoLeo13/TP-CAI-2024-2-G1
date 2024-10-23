using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negocio
{
    public class SugerenciaService
    {
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
    }
}
