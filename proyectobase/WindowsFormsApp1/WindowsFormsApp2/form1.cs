using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace WindowsFormsApp2
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        /*Declararemos las posiciones de nuestras variables */
        int posY = 0;
        int posX = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            /*Declaramos un Objeto*/

            LoginValidar lg = new LoginValidar();
            lg.Usuarios = txtRUC.Text;
            lg.Contrasena = txtContraseña.Text;

            if (lg.Validarlogin(lg.Usuarios, lg.Contrasena))
            {
                inicio f3 = new inicio();
                f3.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show("conexion erronea");

            }
        }


    }
}
