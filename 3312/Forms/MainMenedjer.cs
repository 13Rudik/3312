using _3312.Classes;
using _3312.Classes.Entiryes;
using _3312.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3312
{
    public partial class MainMenedjer : Form
    {
        public MainMenedjer()
        {
            InitializeComponent();
            UpDateMenedjer();
        }
        private void UpDateMenedjer()
        {
            dgvMenedjer.Rows.Clear();
            foreach (Menedjer menedjer in Menedjer.Select())
            {
                int r = dgvMenedjer.Rows.Add(menedjer.men_id, menedjer.fio, menedjer.proc, menedjer.oklad);
                dgvMenedjer.Rows[r].Tag = menedjer;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            UpDateMenedjer();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bMenedjerAdd_Click(object sender, EventArgs e)
        {
            new AddMenedjer(new Menedjer()).ShowDialog();
        }

        private void TbChangeMenedjerBut_Click(object sender, EventArgs e)
        {
            if (dgvMenedjer.SelectedRows.Count>0)
            {
                Menedjer menedjer = dgvMenedjer.SelectedRows[0].Tag as Menedjer;
                new AddMenedjer(menedjer).ShowDialog();
            }
            UpDateMenedjer();
        }
    }
}
