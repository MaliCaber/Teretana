using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teretana
{
    public partial class ProfilClana : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        int id = -1;
        public ProfilClana(int ID)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
            id = ID;
        }

        public byte[] convertImageToByteArray(Image imageToConvert)
        {
            MemoryStream convertImageMemoryStream = new MemoryStream();
            imageToConvert.Save(convertImageMemoryStream, imageToConvert.RawFormat);
            return convertImageMemoryStream.ToArray();
        }

        public Image convertByteArrayToImage(byte[] byteArrayToConvert)
        {
            MemoryStream convertByteArrayToImageMemoryStream = new MemoryStream(byteArrayToConvert);
            Image convertedImage = Image.FromStream(convertByteArrayToImageMemoryStream);
            return convertedImage;
        }

        private void ProfilClana_Load(object sender, EventArgs e)
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
            tbIDclana.Text = id.ToString();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select [Ime], [Prezime], [BrTel], [Email], [Adresa], [Index], [Pol], [Slika] from Clanovi where [IDclan]=" + Double.Parse(tbIDclana.Text);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tbIme.Text = reader.GetString(0);
                    tbPrezime.Text = reader.GetString(1);
                    tbBrTel.Text = reader.GetString(2);
                    tbEmail.Text = reader.GetString(3);
                    tbAdresa.Text = reader.GetString(4);
                    tbBrIndex.Text = reader.GetString(5);
                    if (reader.GetString(6) == "M")
                    {
                        rbM.Checked = true;
                    }
                    else
                    {
                        rbZ.Checked = true;
                    }
                    pbSlika.Image = convertByteArrayToImage((byte[])reader[7]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri prikazu podataka clanarine: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
