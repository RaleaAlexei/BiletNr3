using Prob1.Classes;
using System.Data.SQLite;
using System.Data;
using Agentie.Classes;
using System.Windows.Forms;

namespace Agentie
{
    public partial class Form1 : Form
    {
        private Database dataBase = new Database();
        SQLiteDataAdapter dataUpdater;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bool isOpen = dataBase.Open();
            if (!isOpen)
            {
                MessageBox.Show("Baza de date nu s-a putut conecta!", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataTable dt = new DataTable();
            dataUpdater = new SQLiteDataAdapter("SELECT * FROM Angajat", dataBase.sqlite_conn);
            dataUpdater.Fill(dt);
            dgwAngajati.DataSource = dt.DefaultView;
        }

        private void btInsereaza_Click(object sender, EventArgs e)
        {
            var agent = new Agent(this);
            agent.Citire();
            var success = dataBase.scrieAngajat(agent);
            if (success)
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Angajat", dataBase.sqlite_conn);
                da.Fill(dt);
                dgwAngajati.DataSource = dt.DefaultView;
            }
        }
        private void btSterge_Click(object sender, EventArgs e)
        {
            var agent = new Agent(this);
            agent.Citire();
            var success = dataBase.stergeAngajat(agent);
            if (success)
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Angajat", dataBase.sqlite_conn);
                da.Fill(dt);
                dgwAngajati.DataSource = dt.DefaultView;
            }
        }
        private void btModifica_Click(object sender, EventArgs e)
        {
            var agent = new Agent(this);
            agent.Citire();
            var success = dataBase.modificaAngajat(agent);
            if (success)
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("SELECT * FROM Angajat", dataBase.sqlite_conn);
                da.Fill(dt);
                dgwAngajati.DataSource = dt.DefaultView;
            }
        }
        private void digitOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteCommand da = dataBase.sqlite_conn.CreateCommand();
            da.CommandText = "SELECT ID, Salariul FROM Angajat";
            SQLiteDataReader reader = da.ExecuteReader();
            double minSalariu = int.MinValue;
            int ID = -1;
            while (reader.Read())
            {
                double Salariu = reader.GetDouble(1);
                if (Salariu > minSalariu)
                {
                    minSalariu = Salariu;
                    ID = reader.GetInt32(0);
                }
            }
            DataTable dt = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter($"SELECT * FROM Angajat WHERE ID = {ID}", dataBase.sqlite_conn);
            adapter.Fill(dt);
            dgwAngajati.DataSource = dt.DefaultView;
        }

        private void dgwAngajati_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgwAngajati.Rows[selectedRowIndex];
            tbId.Text = selectedRow.Cells["ID"].Value.ToString();
            tbNume.Text = selectedRow.Cells["Nume"].Value.ToString();
            tbPrenume.Text = selectedRow.Cells["Prenume"].Value.ToString();
            tbSalariu.Text = selectedRow.Cells["Salariul"].Value.ToString();

        }
    }
}