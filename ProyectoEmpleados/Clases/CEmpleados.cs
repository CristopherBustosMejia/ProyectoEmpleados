using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace ProyectoEmpleados.Clases
{
    internal class CEmpleados
    {
        public void ShowEmployees(DataGridView EmployeeTable)
        {
            try
            {
                Clases.CConexion ObjectC = new Clases.CConexion("root","0000");
                string querry = "select * from empleado	where estado_activiadad = 1;";
                EmployeeTable.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(querry,ObjectC.StabConex());
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                EmployeeTable.DataSource = dataTable;
                ObjectC.CloseConex();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se mostraron los datos de la consulta \nError: " + e.ToString());
            }
        }
        public void SaveEmployees(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o, string p)
        {
            try
            {
                Clases.CConexion ObjectC = new Clases.CConexion("root", "0000");
                string querry = "insert into empleado (curp,nombre,apellido_p,apellido_m,fecha_nacimiento,calle,colonia,municipio,estado_republica,codigo_postal,email,telefono,fecha_entrada,salario,contraseña,estado_activiadad)values ('"+a+"','"+b+"','"+c+"','"+d+"','"+e+"','"+f+"','"+g+"','"+h+"','"+i+"',"+j+",'"+k+"','"+l+"','"+m+"',"+n+",'"+o+"',"+p+");";
                MySqlCommand command = new MySqlCommand(querry, ObjectC.StabConex());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se guardo correctamente el registro");
                while (reader.Read())
                {

                }
                ObjectC.CloseConex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se guardo el registro \nError: " + ex.ToString());
            }
        }
        public void SelectEmployees(DataGridView tableEmployee,TextBox a, TextBox b, TextBox c, TextBox d, TextBox e, TextBox f, TextBox g, TextBox h, TextBox i, TextBox j, TextBox k, TextBox l, TextBox m, TextBox n, TextBox o, TextBox p)
        {
            try
            {
                a.Text = tableEmployee.CurrentRow.Cells[0].Value.ToString();
                b.Text = tableEmployee.CurrentRow.Cells[1].Value.ToString();
                c.Text = tableEmployee.CurrentRow.Cells[2].Value.ToString();
                d.Text = tableEmployee.CurrentRow.Cells[3].Value.ToString();
                e.Text = tableEmployee.CurrentRow.Cells[4].Value.ToString();
                f.Text = tableEmployee.CurrentRow.Cells[5].Value.ToString();
                g.Text = tableEmployee.CurrentRow.Cells[6].Value.ToString();
                h.Text = tableEmployee.CurrentRow.Cells[7].Value.ToString();
                i.Text = tableEmployee.CurrentRow.Cells[8].Value.ToString();
                j.Text = tableEmployee.CurrentRow.Cells[9].Value.ToString();
                k.Text = tableEmployee.CurrentRow.Cells[10].Value.ToString();
                l.Text = tableEmployee.CurrentRow.Cells[11].Value.ToString();
                m.Text = tableEmployee.CurrentRow.Cells[12].Value.ToString();
                n.Text = tableEmployee.CurrentRow.Cells[13].Value.ToString();
                o.Text = tableEmployee.CurrentRow.Cells[14].Value.ToString();
                p.Text = tableEmployee.CurrentRow.Cells[15].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro seleccionar \nError: " + ex.ToString());
            }
        }
        public void ModifyEmployees(string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o)
        {
            try
            {
                Clases.CConexion ObjectC = new Clases.CConexion("root", "0000");
                string querry = "update empleado set nombre='" + b + "', apellido_p='" + c + "', apellido_m='" + d + "', fecha_nacimiento='" + e + "', calle='" + f + "', colonia='" + g + "', municipio='" + h + "', estado_republica='" + i + "', codigo_postal=" + j + ", email='" + k + "', telefono='" + l + "', fecha_entrada='" + m + "', salario=" + n + ", contraseña='" + o + "' where curp= '" + a+"';";
                MySqlCommand command = new MySqlCommand(querry, ObjectC.StabConex());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se modifico correctamente el registro");
                while (reader.Read())
                {

                }
                ObjectC.CloseConex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se modifico el registro \nError: " + ex.ToString());
            }
        }
        public void DeleteEmployees(string a)
        {
            try
            {
                Clases.CConexion ObjectC = new Clases.CConexion("root", "0000");
                string querry = "update empleado set estado_activiadad=" + 0 + " where curp= '" + a + "';";
                MySqlCommand command = new MySqlCommand(querry, ObjectC.StabConex());
                MySqlDataReader reader = command.ExecuteReader();
                MessageBox.Show("Se elimino correctamente el registro");
                while (reader.Read())
                {

                }
                ObjectC.CloseConex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino el registro \nError: " + ex.ToString());
            }
        }
    }
}
