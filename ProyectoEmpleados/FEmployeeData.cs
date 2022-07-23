using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;

namespace ProyectoEmpleados
{
    public partial class FEmployeeData : Form
    {
        public FLogIn form1;
        string Rute = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Clases.CEmpleados ObjectE = new Clases.CEmpleados();
        public FEmployeeData()
        {
            InitializeComponent();
            ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	where estado_activiadad = 1;");
        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.SaveEmployees(txtBoxCURP.Text, txtBoxName.Text, txtBoxFLastN.Text, txtBoxSLastN.Text, GetDateFromCurp(txtBoxCURP), txtBoxStreet.Text, txtBoxCol.Text, txtBoxMun.Text, txtBoxState.Text, txtBoxPostal.Text, txtBoxEmail.Text, txtBoxTelephone.Text, txtBoxInDate.Text, txtBoxSalary.Text, Clases.Encrypt.GetSHA256(txtBoxPsswrd.Text), txtBoxActivity.Text);
            ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	where estado_activiadad = 1;");
            Clases.CMail objLogic = new Clases.CMail();
            string body = @"<style>
                            h1{color:dodgerblue;}
                            h2{color:black;}
                            </style>
                            <h1>¡Bienvenido!</h1></br>
                            <h2>Pascal Games le da la mas cordial bienvenida y lo exhorta a informarse mas a cerca de la vision y mision empresarial </br></br></br>Este mensaje esta automatizado, por favor no responda</h2>";
            objLogic.sendMail(txtBoxEmail.Text, "Este correo fue enviado via C-sharp", body);
        }

        private void dgvEmployees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.SelectEmployees(dgvEmployees, txtBoxCURP, txtBoxName, txtBoxFLastN, txtBoxSLastN, txtBoxBirthDate, txtBoxStreet, txtBoxCol, txtBoxMun, txtBoxState, txtBoxPostal, txtBoxEmail, txtBoxTelephone, txtBoxInDate,txtBoxSalary, txtBoxPsswrd, txtBoxActivity, txtBoxSex,txtBoxAge,txtBoxTimeIn);
            ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	where estado_activiadad = 1;");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.ModifyEmployees(txtBoxCURP.Text, txtBoxName.Text, txtBoxFLastN.Text, txtBoxSLastN.Text, GetDateFromCurp(txtBoxCURP), txtBoxStreet.Text, txtBoxCol.Text, txtBoxMun.Text, txtBoxState.Text, txtBoxPostal.Text, txtBoxEmail.Text, txtBoxTelephone.Text, txtBoxInDate.Text, txtBoxSalary.Text, Clases.Encrypt.GetSHA256(txtBoxPsswrd.Text));
            ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	where estado_activiadad = 1;");
            CreateAndSend(txtBoxEmail.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.DeleteEmployees(txtBoxCURP.Text);
            ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	where estado_activiadad = 1;");
            CreateAndSend(txtBoxEmail.Text);
        }
        public void CreateAndSend(string to)
        {
            Clases.CMail objLogic = new Clases.CMail();
            string body = @"<style>
                            h1{color:dodgerblue;}
                            h2{color:darkorange;}
                            </style>
                            <h1>Pascal Games</h1></br>
                            <h2>Se ha detectado un cambio en los registros de la empresa, si no lo ha solicitado usted, porfavor contactese con el departamento de Recursos Humanos</h2>";
            objLogic.sendMail(to, "Este correo fue enviado via C-sharp", body);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form1.Close();
            this.Close();
        }

        private void txtBoxPostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBoxSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtBoxActivity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (e.KeyChar != '1') && (e.KeyChar != '0'))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public string GetDateFromCurp(System.Windows.Forms.TextBox Curp)
        {
            string fec;
            char[] curpArr = Curp.Text.ToCharArray();
            if (int.Parse((curpArr[4].ToString() + curpArr[5].ToString())) < 20)
            {
                fec = "20";
            }
            else
            {
                fec = "19";
            }
            fec = fec + curpArr[4].ToString() + curpArr[5].ToString() + '-' + curpArr[6].ToString() + curpArr[7].ToString() + '-' + curpArr[8].ToString() + curpArr[9].ToString();
            return fec;
        }

        private void txtBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnGoReport_Click(object sender, EventArgs e)
        {
            if (raBtnActive.Checked == true)
            {
                ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	where estado_activiadad = 1;");
            }
            if (raBtnAll.Checked == true)
            {
                ObjectE.ShowEmployees(dgvEmployees, "select * from empleado;");
            }
            if (raBtnCode.Checked == true)
            {
                ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	order by curp;");
            }
            if (raBtnOrderByName.Checked == true)
            {
                ObjectE.ShowEmployees(dgvEmployees, "select * from empleado	order by apellido_p;");
            }
            if (txtBoxReportName.Text != "")
            {
                try
                {
                    objExcel.Application objAplication = new objExcel.Application();
                    Workbook objBook = objAplication.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet objSheet = (Worksheet)objAplication.ActiveSheet;

                    objAplication.Visible = false;

                    foreach (DataGridViewColumn column in dgvEmployees.Columns)
                    {
                        objSheet.Cells[1, column.Index + 1] = column.HeaderText;
                        foreach (DataGridViewRow row in dgvEmployees.Rows)
                        {
                            objSheet.Cells[row.Index + 2, column.Index + 1] = row.Cells[column.Index].Value;
                        }
                    }
                    objBook.SaveAs(Rute + "\\" + txtBoxReportName.Text);
                    objBook.Close();
                    objAplication.Quit();
                    MessageBox.Show("Reporte generado con exito en la ruta: \n" + Rute.ToString());
                }
                catch (Exception r)
                {
                    MessageBox.Show("Ha ocurrido un error al intentar generar el reporte. \n \nError: " + r.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre en el campo de: 'Nombre del Reporte'");
            }
        }
    }
}
