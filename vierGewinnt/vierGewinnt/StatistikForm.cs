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
            dataGridStatistik.Dock = DockStyle.Fill;
            //dt = Spielsteuerung.Statistikholen(); 
            dataGridStatistik.DataSource = dt;
            dataGridStatistik.AutoGenerateColumns = true;
            dataGridStatistik.Columns["Elo"].ReadOnly = true;
            dataGridStatistik.Columns["Name"].ReadOnly = true;
        }
        
    }
}