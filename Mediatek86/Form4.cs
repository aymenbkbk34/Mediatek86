using System;
using System.Windows.Forms;

namespace Mediatek86
{
    public partial class Form4 : Form
    {
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public string Service { get; private set; }

        public Form4()
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Prêt");
            comboBox1.Items.Add("Administratif");
            comboBox1.Items.Add("Médiation culturelle");
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            Nom = textBox2.Text;
            Prenom = textBox1.Text;
            Service = comboBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
