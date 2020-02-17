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
    public partial class Dato : Form
    {
        public Dato()
        {
            InitializeComponent();
        }

        private void Dato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sriDataSet1.formudos' Puede moverla o quitarla según sea necesario.
            this.formudosTableAdapter.Fill(this.sriDataSet1.formudos);
            // TODO: esta línea de código carga datos en la tabla 'sriDataSet.formusiet' Puede moverla o quitarla según sea necesario.
            this.formusietTableAdapter.Fill(this.sriDataSet.formusiet);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3G0D2OA; Initial Catalog=sri; Integrated Security=True");
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inicio f3 = new inicio();
            f3.Show();
            this.Hide();
        }
    }
}
