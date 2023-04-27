using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teretana
{
    public partial class ProfilClana : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        int id = -1;
        private string filename = null;
        private Boolean IZABRANASLIKA = false;
        ListaClanova LC = null;
        public ProfilClana(ListaClanova lc, int ID)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
            id = ID;
            LC = lc;
        }
        public ProfilClana(Posete pos, int ID)
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
                    if (reader[7] != DBNull.Value)
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
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT [IDuplate] AS 'ID Uplate', [DatumUplate] AS 'Datum Uplate', [DatumIsteka] AS 'Datum Isteka', [IznosUplate] AS 'Iznos Uplate' " +
                    "FROM Clanarine " +
                    "WHERE [IDclana] = " + Double.Parse(tbIDclana.Text) + " ORDER BY [IDuplate]";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgUplate.DataSource = dt;

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
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT [IDposete] AS 'ID Posete', [Datum] AS 'Datum i vreme posete' " +
                    "FROM Posete " +
                    "WHERE [IDclana] = " + Double.Parse(tbIDclana.Text) + " ORDER BY [IDposete] DESC";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgPosete.DataSource = dt;

                command.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Posete tabela: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
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
                    command.CommandText = "update Clanovi set [Ime]='" + tbIme.Text.ToString() + "', [Prezime]='" + tbPrezime.Text.ToString() + "', [BrTel]='" + tbBrTel.Text.ToString() + "', [Email]='" + tbEmail.Text.ToString() + "', [Adresa]='" + tbAdresa.Text.ToString() + "', [Index]='" + tbBrIndex.Text.ToString() + "', [Pol]='" + pol.ToString() + "', [Slika]=? " +
                        "where [IDclan] = " + Double.Parse(tbIDclana.Text) + "";
                    command.Parameters.AddWithValue("[Slika]", OleDbType.Binary).Value = convertImageToByteArray(Image.FromFile(filename));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno uneto u bazu podataka");
                    command.Dispose();
                }
                else
                {
                    command.CommandText = "update Clanovi set [Ime]='" + tbIme.Text.ToString() + "', [Prezime]='" + tbPrezime.Text.ToString() + "', [BrTel]='" + tbBrTel.Text.ToString() + "', [Email]='" + tbEmail.Text.ToString() + "', [Adresa]='" + tbAdresa.Text.ToString() + "', [Index]='" + tbBrIndex.Text.ToString() + "', [Pol]='" + pol.ToString() + "'" +
                        "where [IDclan] = " + Double.Parse(tbIDclana.Text) + "";
                    command.ExecuteNonQuery();
                    MessageBox.Show("Uspesno uneto u bazu podataka");
                    command.Dispose();
                }
            }
            catch (Exception ey)
            {
                MessageBox.Show("Error pri unosu: " + ey);
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

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                PotvrdaBrisanja pb = new PotvrdaBrisanja(this, int.Parse(tbIDclana.Text));
                pb.Owner = this;
                pb.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri brisanju: " + ex);
            }
            finally
            {
                //this.Close();
            }
        }

        private void ProfilClana_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (LC != null)
                LC.OsveziListu();
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator QG = new QRCodeGenerator();
            QRCodeData data = QG.CreateQrCode(id.ToString(), QRCodeGenerator.ECCLevel.H);
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
    }
}
