using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediatek86
{
    public partial class Form2 : Form


    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Nom", "Nom");
            dataGridView1.Columns.Add("Prenom", "Prénom");
            dataGridView1.Columns.Add("Service", "Service");
        }

        private void button1_Click(object sender, EventArgs e)

        {
            Form4 formAjout = new Form4();
            if (formAjout.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add(formAjout.Nom, formAjout.Prenom, formAjout.Service);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
