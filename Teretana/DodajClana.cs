using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using QRCoder;

namespace Teretana
{
    public partial class DodajClana : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private string filename = null;
        private Boolean IZABRANASLIKA = false;
        public DodajClana()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
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

        private void DodajClana_Load(object sender, EventArgs e)
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
        }

        private void btnSlika_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog chooseImageFromPCFileDialog = new OpenFileDialog();
                chooseImageFromPCFileDialog.Title = "Izaberi sliku";
                DialogResult chooseImageFromPCDialogResult = chooseImageFromPCFileDialog.ShowDialog();
                if (chooseImageFromPCDialogResult == DialogResult.OK)
                {
                    IZABRANASLIKA = true;
                    filename = chooseImageFromPCFileDialog.FileName;
                    pbSlika.Image = new Bitmap(filename);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri odabiru slike: " + ex);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            String pol = "/";
            if (rbM.Checked == true)
            {
                pol = "M";
            }
            else if (rbZ.Checked == true)
            {
                pol = "Z";
            }
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                if (IZABRANASLIKA == true)
                {
                    command.CommandText = "insert into Clanovi ([Ime], [Prezime], [BrTel], [Email], [Adresa], [Index], [Pol], [Slika]) " +
                        "values('" + tbIme.Text.ToString() + "','" + tbPrezime.Text.ToString() + "','" + tbBrTel.Text.ToString() + "','" + tbEmail.Text.ToString() + "','" + tbAdresa.Text.ToString() + "','" + tbBrIndex.Text.ToString() + "','" + pol.ToString() + "', ?)";
                    command.Parameters.AddWithValue("[Slika]", OleDbType.Binary).Value = convertImageToByteArray(Image.FromFile(filename));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno uneto u bazu podataka");
                    command.Dispose();
                }
                else
                {
                    command.CommandText = "insert into Clanovi ([Ime], [Prezime], [BrTel], [Email], [Adresa], [Index], [Pol]) " +
                        "values('" + tbIme.Text.ToString() + "','" + tbPrezime.Text.ToString() + "','" + tbBrTel.Text.ToString() + "','" + tbEmail.Text.ToString() + "','" + tbAdresa.Text.ToString() + "','" + tbBrIndex.Text.ToString() + "','" + pol.ToString() + "')";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno uneto u bazu podataka");
                    command.Dispose();
                }
            }
            catch (Exception ey)
            {
                MessageBox.Show("Error pri unosu: " + ey);
            }
            finally
            {
                connection.Close();

                //QR GENERACIJA
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    command.CommandText = "select IDclan from Clanovi where [BrTel]='" + tbBrTel.Text.ToString() + "' and [Email]='" + tbEmail.Text.ToString() + "'";
                    OleDbDataReader reader = command.ExecuteReader();
                    double ClanID = -1;
                    while (reader.Read())
                    {
                        ClanID = Double.Parse(reader.GetValue(0).ToString());
                    }
                    reader.Close();



                    QRCodeGenerator QG = new QRCodeGenerator();
                    QRCodeData data = QG.CreateQrCode(ClanID.ToString(), QRCodeGenerator.ECCLevel.H);
                    QRCode code = new QRCode(data);
                    pbQR.Image = code.GetGraphic(100);
                    String location = @"QRCode\";
                    var dialog = new SaveFileDialog();
                    dialog.InitialDirectory = location;
                    dialog.Filter = "PNG|*.png|JPEG|*.jpeg|BPM|*.bmp|GIF|*.gif";
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        pbQR.Image.Save(dialog.FileName);
                    }

                }
                catch (Exception eu)
                {
                    MessageBox.Show("Error pri kreiranju QR koda: " + eu);
                }
                finally
                {
                    connection.Close();
                }

                this.Close();
            }
        }


    }
}
