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
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbDevices.Items.Add(filterInfo.Name);
            }
            cbDevices.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevices.SelectedIndex].MonikerString);
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

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevices.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame; ;
            captureDevice.Start();
            timer1.Start();
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
                            command.CommandText = "select MAX([DatumIsteka]) from Clanarine where [IDclana]=" + (double)ID;
                            OleDbDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                if (reader[0] != DBNull.Value)
                                {
                                    DateTime date = DateTime.Parse(reader[0].ToString());
                                    if (DateTime.Compare(date, DateTime.Now) >= 0)
                                    {
                                        azurirajPodatke();
                                    }
                                    else
                                    {
                                        Console.Beep(2000, 1000);
                                        Console.Beep(2000, 1000);
                                        Console.Beep(2000, 1000);
                                        MessageBox.Show("Istekla clanarina");
                                    }
                                }
                                else
                                {
                                    Console.Beep(2000, 1000);
                                    Console.Beep(2000, 1000);
                                    Console.Beep(2000, 1000);
                                    MessageBox.Show("Nikad nije uplatio clanarinu");
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

        private void azurirajPodatke()
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Posete ([IDclana], [Datum]) " +
                    "values(" + (double)ID + ", '" + DateTime.Now + "')";
                command.ExecuteNonQuery();
                //DODAJ ZVUK AKO JE UNETO AAAAAA
                //
                //PROVERA DATUMA ISTEKA CLANARINE
                //
                //
                //
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
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cbDevices.SelectedIndex].MonikerString);
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
    }
}