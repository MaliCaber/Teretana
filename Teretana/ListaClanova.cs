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
    public partial class ListaClanova : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public ListaClanova()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
        }

        private void ListaClanova_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                lbConnection.Text = "Baza je povezana";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol], MAX(clana.[DatumUplate]) AS 'Datum Uplate', MAX(clana.[DatumIsteka]) AS 'Datum Isteka', MAX(pos.[Datum]) AS 'Datum Posete'" +
                    "FROM (Clanovi AS clan LEFT OUTER JOIN Clanarine AS clana ON clan.[IDclan]=clana.[IDclana]) LEFT OUTER JOIN Posete AS pos ON clan.[IDclan]=pos.[IDclana]" +
                    "GROUP BY clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol]";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVelika.DataSource = dt;

                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            if (tbIme.Text != "" && tbPrezime.Text != "")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol], MAX(clana.[DatumUplate]) AS 'Datum Uplate', MAX(clana.[DatumIsteka]) AS 'Datum Isteka', MAX(pos.[Datum]) AS 'Datum Posete'" +
                        "FROM (Clanovi AS clan LEFT OUTER JOIN Clanarine AS clana ON clan.[IDclan]=clana.[IDclana]) LEFT OUTER JOIN Posete AS pos ON clan.[IDclan]=pos.[IDclana]" +
                        "WHERE clan.[Ime]='" + tbIme.Text.ToString() + "' OR clan.[Prezime]='" + tbPrezime.Text.ToString() + "'" +
                        "GROUP BY clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol]";

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgVelika.DataSource = dt;

                    command.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else if (tbIme.Text != "" && tbPrezime.Text == "")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol], MAX(clana.[DatumUplate]) AS 'Datum Uplate', MAX(clana.[DatumIsteka]) AS 'Datum Isteka', MAX(pos.[Datum]) AS 'Datum Posete'" +
                        "FROM (Clanovi AS clan LEFT OUTER JOIN Clanarine AS clana ON clan.[IDclan]=clana.[IDclana]) LEFT OUTER JOIN Posete AS pos ON clan.[IDclan]=pos.[IDclana]" +
                        "WHERE clan.[Ime]='" + tbIme.Text.ToString() + "'" +
                        "GROUP BY clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol]";

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgVelika.DataSource = dt;

                    command.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else if (tbIme.Text == "" && tbPrezime.Text != "")
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol], MAX(clana.[DatumUplate]) AS 'Datum Uplate', MAX(clana.[DatumIsteka]) AS 'Datum Isteka', MAX(pos.[Datum]) AS 'Datum Posete'" +
                        "FROM (Clanovi AS clan LEFT OUTER JOIN Clanarine AS clana ON clan.[IDclan]=clana.[IDclana]) LEFT OUTER JOIN Posete AS pos ON clan.[IDclan]=pos.[IDclana]" +
                        "WHERE clan.[Prezime]='" + tbPrezime.Text.ToString() + "'" +
                        "GROUP BY clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol]";

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgVelika.DataSource = dt;

                    command.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol], MAX(clana.[DatumUplate]) AS 'Datum Uplate', MAX(clana.[DatumIsteka]) AS 'Datum Isteka', MAX(pos.[Datum]) AS 'Datum Posete'" +
                        "FROM (Clanovi AS clan LEFT OUTER JOIN Clanarine AS clana ON clan.[IDclan]=clana.[IDclana]) LEFT OUTER JOIN Posete AS pos ON clan.[IDclan]=pos.[IDclana]" +
                        "GROUP BY clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol]";

                    OleDbDataAdapter da = new OleDbDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgVelika.DataSource = dt;

                    command.Dispose();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            try
            {
                connection.Open();
                lbConnection.Text = "Baza je povezana";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol], MAX(clana.[DatumUplate]) AS 'Datum Uplate', MAX(clana.[DatumIsteka]) AS 'Datum Isteka', MAX(pos.[Datum]) AS 'Datum Posete'" +
                    "FROM (Clanovi AS clan LEFT OUTER JOIN Clanarine AS clana ON clan.[IDclan]=clana.[IDclana]) LEFT OUTER JOIN Posete AS pos ON clan.[IDclan]=pos.[IDclana]" +
                    "GROUP BY clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol]";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVelika.DataSource = dt;

                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dgVelika_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ProfilClana pc = new ProfilClana(this, int.Parse(dgVelika.CurrentRow.Cells[0].Value.ToString()));
                pc.Owner = this;
                pc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri otvaranju profila: " + ex);
            }
        }
        public void OsveziListu()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol], MAX(clana.[DatumUplate]) AS 'Datum Uplate', MAX(clana.[DatumIsteka]) AS 'Datum Isteka', MAX(pos.[Datum]) AS 'Datum Posete'" +
                    "FROM (Clanovi AS clan LEFT OUTER JOIN Clanarine AS clana ON clan.[IDclan]=clana.[IDclana]) LEFT OUTER JOIN Posete AS pos ON clan.[IDclan]=pos.[IDclana]" +
                    "GROUP BY clan.[IDclan], clan.[Ime], clan.[Prezime], clan.[BrTel], clan.[Email], clan.[Adresa], clan.[Index], clan.[Pol]";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgVelika.DataSource = dt;

                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
