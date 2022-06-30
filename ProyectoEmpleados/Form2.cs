using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEmpleados
{
    public partial class Form2 : Form
    {
        public Form1 form1;
        public Form2()
        {
            InitializeComponent();
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.ShowEmployees(dgvEmployees);
        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.SaveEmployees(txtBoxCURP.Text, txtBoxName.Text, txtBoxFLastN.Text, txtBoxSLastN.Text, txtBoxBirthDate.Text, txtBoxStreet.Text, txtBoxCol.Text, txtBoxMun.Text, txtBoxState.Text, txtBoxPostal.Text, txtBoxEmail.Text, txtBoxTelephone.Text, txtBoxInDate.Text, txtBoxSalary.Text, Clases.Encrypt.GetSHA256(txtBoxPsswrd.Text), txtBoxActivity.Text);
            ObjectE.ShowEmployees(dgvEmployees);
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
            ObjectE.SelectEmployees(dgvEmployees, txtBoxCURP, txtBoxName, txtBoxFLastN, txtBoxSLastN, txtBoxBirthDate, txtBoxStreet, txtBoxCol, txtBoxMun, txtBoxState, txtBoxPostal, txtBoxEmail, txtBoxTelephone, txtBoxInDate,txtBoxSalary, txtBoxPsswrd, txtBoxActivity);
            ObjectE.ShowEmployees(dgvEmployees);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.ModifyEmployees(txtBoxCURP.Text, txtBoxName.Text, txtBoxFLastN.Text, txtBoxSLastN.Text, txtBoxBirthDate.Text, txtBoxStreet.Text, txtBoxCol.Text, txtBoxMun.Text, txtBoxState.Text, txtBoxPostal.Text, txtBoxEmail.Text, txtBoxTelephone.Text, txtBoxInDate.Text, txtBoxSalary.Text, txtBoxPsswrd.Text);
            ObjectE.ShowEmployees(dgvEmployees);
            CreateAndSend(txtBoxEmail.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.CEmpleados ObjectE = new Clases.CEmpleados();
            ObjectE.DeleteEmployees(txtBoxCURP.Text);
            ObjectE.ShowEmployees(dgvEmployees);
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
    }
}
