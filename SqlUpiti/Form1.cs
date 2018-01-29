using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace SqlUpiti
{
    public partial class Form1 : Form
    {
        string connString;
        public Form1()
        {
            InitializeComponent();
            connString = ConfigurationManager.ConnectionStrings["SqlUpiti.Properties.Settings.stud_evidencijaConnectionString"].ConnectionString;
        }

        private void buttonIzvrsi_Click(object sender, EventArgs e)
        {
            string upit = textBoxUpit.Text;
            if (String.IsNullOrEmpty(upit))
            {
                rezultatLabel.Visible = false;
                dataGridView1.Visible = false;

                MessageBox.Show(this,"Niste unijeli SQL upit.\nMolimo unesite SQL upit.","Nema SQL upita",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection konekcija = new SqlConnection(connString);
                try
                {
                    konekcija.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(upit, konekcija);
                    DataTable tablica = new DataTable();
                    adapter.Fill(tablica);
                    dataGridView1.DataSource = new BindingSource(tablica,null);
                    rezultatLabel.Visible = true;
                    dataGridView1.Visible = true;
                }
                catch (SqlException ex)
                {
                    rezultatLabel.Visible = false;
                    dataGridView1.Visible = false;
                    MessageBox.Show(this,"Greška prilikom izvršavanja upita: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    konekcija.Close();
                }
            }
            
        }
    }
}
