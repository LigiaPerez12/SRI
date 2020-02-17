using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    class LoginValidar
    {
        private string usuarios;
        private string contrasena;

        public string Usuarios
        {
            get { return usuarios; }
            set { usuarios = value; }
        }
        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }

        public bool Validarlogin(string u, string c)
        {
            string conectar = "server=localhost;database=login;Uid=root;pwd=Burbuja02;";
            MySqlConnection con = new MySqlConnection(conectar);
            con.Open();
            MySqlCommand cmn;
            MySqlDataReader dr;

            string sql = "SELECT * FROM usuario where RUC = '" + u + "' and contraseña ='" + c + "' ";
            cmn = new MySqlCommand(sql, con);
            dr = cmn.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                
                return true;

            }
            else
            {
                System.Windows.Forms.MessageBox.Show("conexion erronea");

                return false;
            }

        }

    }
}
