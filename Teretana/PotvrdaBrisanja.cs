using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teretana
{
    public partial class PotvrdaBrisanja : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        int id = -1;
        ProfilClana PC = null;
        public PotvrdaBrisanja(ProfilClana pc, int ID)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
            id = ID;
            PC = pc;
        }

        private void PotvrdaBrisanja_Load(object sender, EventArgs e)
        {

        }

        private void btnNe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDa_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "delete from Clanovi where [IDclan]=" + (double)id + "";
                command.ExecuteNonQuery();
                MessageBox.Show("Clan uspesno obrisan");
                this.Close();
                PC.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri brisanju: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
