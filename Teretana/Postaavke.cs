using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teretana
{
    public partial class Postaavke : Form
    {
        public Postaavke()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;

        private void Postaavke_Load(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    cbKamera.Items.Add(filterInfo.Name);
                }
                cbKamera.SelectedIndex = Properties.Settings.Default.indexCamera;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pri popunjavanju combo boxa: " + ex);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.indexCamera = cbKamera.SelectedIndex;

            Properties.Settings.Default.Save();

            this.Close();
        }
    }
}
