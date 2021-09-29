using _3312.Classes.Entiryes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3312.Forms
{
    public partial class AddMenedjer : Form
    {
        Menedjer EditMenedjer;
        public AddMenedjer(Menedjer menedjer)
        {
            EditMenedjer = menedjer;
            InitializeComponent();
            tbMenedjerFio.Text = menedjer.fio;
            tbMenedjerProc.Text = menedjer.proc.ToString();
            tbMenedjerOklad.Text = menedjer.oklad.ToString(); 
        }


        private void bMenedjerAdd_Click(object sender, EventArgs e)
        {
            if (EditMenedjer.men_id == 0)
                Menedjer.Add(tbMenedjerFio.Text, Convert.ToInt32(tbMenedjerProc.Text), Convert.ToDecimal(tbMenedjerOklad.Text));
            else
                EditMenedjer.Change(tbMenedjerFio.Text, Convert.ToInt32(tbMenedjerProc.Text), Convert.ToDecimal(tbMenedjerOklad.Text));
        }
    }
}

