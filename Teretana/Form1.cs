namespace Teretana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajClana dodajClana = new DodajClana();
            dodajClana.Show();
        }

        private void btnClanarina_Click(object sender, EventArgs e)
        {
            Clanarina clanarina = new Clanarina();
            clanarina.Show();
        }

        private void btnListaClanova_Click(object sender, EventArgs e)
        {
            ListaClanova listaclanova = new ListaClanova();
            listaclanova.Show();
        }
    }
}