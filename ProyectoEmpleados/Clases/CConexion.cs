using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ProyectoEmpleados.Clases
{
    public class CConexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string server = "localhost";
        static string database = "empleados";
        static string user;
        static string password;
        static string port = "3306";
        static string stringConex;
        public bool flag = false;
        
        public MySqlConnection StabConex()
        {
            try
            {
                conex.ConnectionString = stringConex;
                conex.Open();
                //MessageBox.Show("La conexion con la base de datos se establecio correctamente");
                flag = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se logro la conexion con la base de datos \nEror: " + e.ToString());
            }
            return conex;
        }
        public void CloseConex()
        {

        }
        public CConexion(string a, string b)
        {
            user = a;
            password = b;
            stringConex = "server=" + server + ";" + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + database + ";";
        }
        public CConexion()
        {

        }
    }
}
