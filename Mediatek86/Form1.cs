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

namespace Mediatek86
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;    
            string pwd = textBox2.Text;      

            string chaineConnexion = "server=localhost;user=mediatekuser;password=motdepasseUser;database=mediatek86;";
            using (MySqlConnection connexion = new MySqlConnection(chaineConnexion))
            {
                connexion.Open();
                string requete = "SELECT COUNT(*) FROM responsable WHERE login = @login AND pwd = SHA2(@pwd, 256)";
                using (MySqlCommand cmd = new MySqlCommand(requete, connexion))
                {
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@pwd", pwd);
                    int nb = Convert.ToInt32(cmd.ExecuteScalar());
                    if (nb == 1)
                    {
                        // Affiche la fenêtre gestion du personnel
                        Form2 formMain = new Form2();
                        formMain.Show();

                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Identifiants incorrects");
                    }
                }
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

