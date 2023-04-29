using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Data.OleDb;
using System.Runtime.Intrinsics.Arm;
using ZXing;
using ZXing.Windows.Compatibility;

namespace Teretana
{
    public partial class Teretana : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        int ID;
        DateTime date = DateTime.MaxValue;
        public Teretana()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb;Persist Security Info=False;";
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDevice(filterInfoCollection[Properties.Settings.Default.indexCamera].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame; ;
            captureDevice.Start();
            timer1.Start();
            azurirajPoseteLoad();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajClana dodajClana = new DodajClana();
            dodajClana.Show();
        }

        private void btnClanarina_Click(object sender, EventArgs e)
        {
            Clanarina clanarina = new Clanarina(this);
            if (captureDevice.IsRunning)
            {
                timer1.Stop();
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                captureDevice.Stop();
            }
            clanarina.Owner = this;
            clanarina.Show();

        }

        private void btnListaClanova_Click(object sender, EventArgs e)
        {
            ListaClanova listaclanova = new ListaClanova();
            listaclanova.Show();
        }


        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pbCamera.Image != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pbCamera.Image);
                    if (result != null && ID != int.Parse(result.ToString()))
                    {
                        ID = int.Parse(result.ToString());
                        //ako je placeno azuriraj
                        try
                        {
                            connection.Open();
                            OleDbCommand command = new OleDbCommand();
                            command.Connection = connection;
                            command.CommandText = "select IIf(IsNull(MAX([DatumIsteka])), #" + DateTime.MinValue + "# , MAX([DatumIsteka])) from Clanarine where [IDclana]=" + (double)ID + " ";
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                date = DateTime.Parse(reader[0].ToString());
                                if (DateTime.Compare(date, DateTime.Now) >= 0)
                                {
                                    azurirajPodatkeDA();
                                }
                                else
                                {
                                    azurirajPodatkeNE();
                                }
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
            catch (Exception ex)
            {
                MessageBox.Show("Error while decoding QR code" + ex);
            }

        }

        private void azurirajPodatkeDA()
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Posete ([IDclana], [Datum], [Istekla]) " +
                    "values(" + (double)ID + ", '" + DateTime.Now + "', 'NE')";
                command.ExecuteNonQuery();

                Console.Beep(2000, 1000);
                command.Dispose();
                azurirajPosete();
            }
            catch (Exception ey)
            {
                MessageBox.Show("Error pri unosu: " + ey);
            }
        }

        private void azurirajPodatkeNE()
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Posete ([IDclana], [Datum], [Istekla]) " +
                    "values(" + (double)ID + ", '" + DateTime.Now + "', 'DA')";
                command.ExecuteNonQuery();

                Console.Beep(2000, 1000);
                command.Dispose();
                azurirajPosete();
            }
            catch (Exception ey)
            {
                MessageBox.Show("Error pri unosu: " + ey);
            }
        }


        public void azurirajPosete()
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select COUNT(*) from Posete where [Datum] >= #" + DateTime.Today + "#";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)
                    {
                        tbBrojPoseta.Text = reader[0].ToString();
                    }
                }
                reader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri prikazu broja poseta: " + ex);
            }
        }

        public void azurirajPoseteLoad()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "select COUNT(*) from Posete where [Datum] >= #" + DateTime.Today + "#";
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[0] != DBNull.Value)
                    {
                        tbBrojPoseta.Text = reader[0].ToString();
                    }
                }
                reader.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri prikazu broja poseta: " + ex);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                timer1.Stop();
                captureDevice.SignalToStop();
                captureDevice.WaitForStop();
                captureDevice.Stop();
            }
        }
        public void startCamera()
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[Properties.Settings.Default.indexCamera].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame; ;
            captureDevice.Start();
            timer1.Start();
        }

        private void btnPosete_Click(object sender, EventArgs e)
        {
            Posete p = new Posete();
            p.Owner = this;
            p.Show();
        }

        private void btnPostavke_Click(object sender, EventArgs e)
        {
            Postaavke p = new Postaavke();
            p.Owner = this;
            p.Show();
        }
    }
}