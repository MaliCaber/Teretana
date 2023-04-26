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
using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;
using ZXing;
using ZXing.Windows.Compatibility;

namespace Teretana
{
    public partial class Clanarina : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        Teretana T;
        public Clanarina(Teretana t)
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
            T = t;
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice = null;


        private void Clanarina_Load(object sender, EventArgs e)
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
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbDevices.Items.Add(filterInfo.Name);
            }
            cbDevices.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevices.SelectedIndex].MonikerString);
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Clanarina_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                timer1.Stop();
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                captureDevice.Stop();
            }
            T.startCamera();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pbCamera.Image != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pbCamera.Image);
                    if (result != null)
                    {
                        tbID.Text = result.ToString();
                        if (captureDevice.IsRunning)
                        {
                            timer1.Stop();
                            captureDevice.SignalToStop();
                            captureDevice.WaitForStop();
                            captureDevice.Stop();
                        }
                        azurirajPodatke();
                        MessageBox.Show("Uspesno skenirano");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while decoding QR code" + ex);
            }
        }

        private void azurirajPodatke()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select Ime,Prezime from Clanovi where [IDclan]=" + Double.Parse(tbID.Text);
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tbIme.Text = reader.GetString(0);
                    tbPrezime.Text = reader.GetString(1);
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

        private void btnUplati_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Clanarine ([IDclana], [DatumUplate], [IznosUplate], [DatumIsteka]) " +
                    "values(" + Double.Parse(tbID.Text) + ",'" + dateTimePicker1.Value + "'," + Double.Parse(tbIznos.Text) + ",'" + dateTimePicker1.Value.AddMonths(int.Parse(tbBrojMeseci.Text)) + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Uspesno uneto u bazu podataka");
                command.Dispose();
            }
            catch (Exception ey)
            {
                MessageBox.Show("Error pri unosu: " + ey);
            }
            finally
            {
                connection.Close();
                this.Close();
            }
        }
    }
}
