using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxDataAtual_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPegarData_Click(object sender, EventArgs e)
        {
            textBoxDataInicial.Text = monthCalendar.SelectionStart.ToShortDateString();
            textBoxDataFinal.Text = monthCalendar.SelectionEnd.ToShortDateString();
            textBoxDataAtual.Text = monthCalendar.TodayDate.ToShortDateString();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
