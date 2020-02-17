
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
    public partial class formulario107 : Form
    {
        public formulario107()
        {
            InitializeComponent();
        }
        /*Declararemos las posiciones de nuestras variables */
        int posY = 0;
        int posX = 0;
        private void formulario107_Load(object sender, EventArgs e)
        {

        }
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
            inicio f3 = new inicio();
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3G0D2OA; Initial Catalog=sri; Integrated Security=True");
            con.Open();

            string fecha = txtFecha.Text;
            string ano = txtAno.Text;
            string nombre_apellido = txtNombres.Text;
            string cedula = txtRuc.Text;
            string sueldo_salario = txtSueldo.Text;
            string comision_bono = txtComisiones.Text;
            string participacion = txtParticipacion.Text;
            string ingreso = txtIngresos.Text;
            string decimo_tercer = txtTercero.Text;
            string decimo_cuarto = txtCuarto.Text;
            string fondo = txtFondos.Text;
            string ingreso_noagra = txtGravados.Text;
            string aporte_empleador = txtEmpleador.Text;
            string aporte_empleadores = txtEmpleadores.Text;
            string exo_discapacidad = txtDiscapacidad.Text;
            string exo_tercera = txtEdadTercera.Text;
            string imp_renta = txtRenta.Text;

            string cadena = "INSERT into formusiet (fecha,ano,nombre_apellido,cedula,sueldo_salario,comision_bono,participacion,ingreso,decimo_tercer ,decimo_cuarto,fondo,ingreso_noagra,aporte_empleador,aporte_empleadores,exo_discapacidad,exo_tercera,imp_renta ) VALUES ('" + fecha + "','" + ano +  "','" + nombre_apellido + "','" + cedula + "','" + sueldo_salario + "','" + comision_bono + "','" + participacion + "','" + ingreso + "','" + decimo_tercer + "','" + decimo_cuarto + "','" + fondo + "','" + ingreso_noagra + "','" + aporte_empleador + "','" + aporte_empleadores + "','" + exo_discapacidad + "','" + exo_tercera + "','" + imp_renta + "')";

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

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtComisiones_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtParticipacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtIngresos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtTercero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtCuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtFondos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtGravados_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtEmpleador_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtEmpleadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtDiscapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtEdadTercera_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }

        private void txtRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimal(e);
        }
    }
}
