using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class formulario102 : Form
    {
        public formulario102()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio f3 = new inicio();
            f3.Show();
            this.Hide();
        }
        int posY = 0;
        int posX = 0;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotalIngresos.Text = (Convert.ToDecimal(txtEmpresarial.Text) + Convert.ToDecimal(txtLibre.Text) + Convert.ToDecimal(txtOcupacion.Text) + Convert.ToDecimal(txtArriendo.Text) + Convert.ToDecimal(txtRegalias.Text)).ToString();
            txtTotalEgresos.Text = (Convert.ToDecimal(txtEducacion.Text) + Convert.ToDecimal(txtSalud.Text) + Convert.ToDecimal(txtLibreEjercicio.Text) + Convert.ToDecimal(txtVestimenta.Text)).ToString();
            txtResultadoFinal.Text = (Convert.ToDecimal(txtTotalIngresos.Text) - Convert.ToDecimal(txtTotalEgresos.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source= DESKTOP-3G0D2OA; Initial Catalog=sri; Integrated Security=True");
            con.Open();

            string Fecha = txtFechaRegistro.Text;
            string Ano = txtAno.Text;
            string Nombres = txtNombre.Text;
            string Ruc = txtRuc.Text;
            
            string Empresarial = txtEmpresarial.Text;
            string Libre = txtLibre.Text;
            string Ocupacional = txtOcupacion.Text;
            string Arriendo = txtArriendo.Text;
            string Regalias = txtRegalias.Text;
            string Totales = txtTotalIngresos.Text;

            string Educacion = txtEducacion.Text;
            string Salud = txtSalud.Text;
            string LibreEjercicio = txtLibreEjercicio.Text;
            string Vestimenta = txtVestimenta.Text;
            string TotalesEgresos = txtTotalEgresos.Text;

            string TotalFormulario = txtResultadoFinal.Text;

            string cadena = "INSERT into formudos (fecha, ano, nombre_apellido,cedula,empresarial,libre,ocupacional,arriendo,regalias,tales_suma,eduacion,salud,libre_ejercicio,vestimenta,total_egreso,total) VALUES ('" + Fecha + "','" + Ano + "','" + Nombres + "','" + Ruc + "','" + Empresarial + "','" + Libre + "','" + Ocupacional + "','" + Arriendo + "','" + Regalias + "','" + Totales + "','" + Educacion + "','" + Salud + "','" + LibreEjercicio + "','" + Vestimenta + "','" + TotalesEgresos + "','" + TotalFormulario + "')";

            SqlCommand cmd = new SqlCommand(cadena, con);
            MessageBox.Show(" DATOS EN PROCESO");
            cmd.ExecuteNonQuery();
            MessageBox.Show("LOS DATOS SE GUARDARON EXITOSAMENTE");
            con.Close();
        }
        private void txtAno_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtRuc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtEmpresarial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtLibre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtOcupacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtArriendo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtRegalias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtEducacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtSalud_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtLibreEjercicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtVestimenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtResultadoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }
    }
}



