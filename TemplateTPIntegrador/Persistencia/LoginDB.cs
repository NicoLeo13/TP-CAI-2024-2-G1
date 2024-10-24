using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class LoginDB
    {
        public void guardarIntento(String username, int intentos)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            
            //int intentos = obtenerIntentos(username);
            int intentoNuevo = intentos == 0 ? 1 : intentos + 1;

            if (intentoNuevo == 1)
                dbHelper.Insertar(username, intentoNuevo.ToString(), DateTime.Now);
            else
                dbHelper.Modificar(username, intentoNuevo.ToString());
        }

        public (int intentos, DateTime tmsTmp) obtenerIntentos(String username)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            //(String intento, DateTime tmsTmp) = dbHelper.Buscar(username);
            (string intentos, DateTime tmsTmp) = dbHelper.Buscar(username);     //Trabajo con string ya que puede estar vacio ""
            
            if(intentos == null || intentos == "")
                intentos = "0";

            return (int.Parse(intentos), tmsTmp);

        }

        //public String obtenerArray(String user)
        //{
        //    DBHelper dbHelper = new DBHelper("intentos_login");
        //    String valor = dbHelper.Buscar(user);
        //    return valor;
        //}

        //public void modificarDatos(String key, String newValue)
        //{
        //    DBHelper dbHelper = new DBHelper("intentos_login");
        //    dbHelper.Modificar(key, newValue);
        //}

        public void reiniciarIntentos(String key)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            //dbHelper.Modificar(key, null);
            dbHelper.Borrar(key);
        }

        /*        public void guardarArray(List<String> datos)
                {
                    DBHelper dbHelper = new DBHelper("intentos_login");
                    String correosElectronicos = "";
                    foreach(String correo in datos)
                    {
                        correosElectronicos = correosElectronicos + "," + correo;
                    }
                    dbHelper.Insertar("correosElectronicos", correosElectronicos);

                }*/
    }
}
