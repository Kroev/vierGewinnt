using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vierGewinnt
{
    public partial class StatistikForm : Form
    {
        private DataTable dt;
        

        public StatistikForm() : base()
        {
           
            InitializeComponent();

        }
        
        private void StatistikForm_Load(object sender, EventArgs e)
        {
            dataGridStatistik.DefaultCellStyle.Font = new Font("Tahoma", 13);
            dataGridStatistik.AllowUserToAddRows = false;
            dataGridStatistik.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnStaSpieler_Click(object sender, EventArgs e)
        {
            dt = Spielsteuerung.StatistikGetPlayer();
            dataGridStatistik.DataSource = dt;
            dataGridStatistik.AutoGenerateColumns = true;
            dataGridStatistik.Columns["Elo"].ReadOnly = true;
            dataGridStatistik.Columns["Name"].ReadOnly = true;
            dataGridStatistik.Columns["Name"].DisplayIndex = 0;
            dataGridStatistik.Columns["Elo"].DisplayIndex = 1;
            dataGridStatistik.Columns["Elo"].HeaderText = "Elo";
            dataGridStatistik.Columns["Name"].HeaderText = "Name";
            dataGridStatistik.Sort(dataGridStatistik.Columns["Elo"], ListSortDirection.Descending);
        }

        private void btnStaSpiele_Click(object sender, EventArgs e)
        {
            dt = Spielsteuerung.StatistikGetGame();
            dataGridStatistik.DataSource = dt;
            dataGridStatistik.AutoGenerateColumns = true;
            dataGridStatistik.Columns["Ergebnis"].ReadOnly = true;
            dataGridStatistik.Columns["Spieler1"].ReadOnly = true;
            dataGridStatistik.Columns["Spieler2"].ReadOnly = true;
            dataGridStatistik.Columns["Spieler1"].DisplayIndex = 0;
            dataGridStatistik.Columns["Spieler2"].DisplayIndex = 1;
            dataGridStatistik.Columns["Ergebnis"].DisplayIndex = 2;
            dataGridStatistik.Columns["Spieler1"].HeaderText = "Spieler1";
            dataGridStatistik.Columns["Spieler2"].HeaderText = "Spieler2";
            dataGridStatistik.Columns["Ergebnis"].HeaderText = "Ergebnis";
        }
    }
}