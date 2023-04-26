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
    public partial class Posete : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Posete()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
        }

        private void Posete_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT c.[IDclan], c.[Ime], c.[Prezime], p.[Datum]" +
                    "FROM Clanovi AS c INNER JOIN Posete AS p ON c.[IDclan]=p.[IDclana]" +
                    "ORDER BY p.[IDposete] DESC";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVelika.DataSource = dt;

                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Uplate tabela: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
