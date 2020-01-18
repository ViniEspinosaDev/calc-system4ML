using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisteminhaCalculos
{
    public partial class frm_Menu : Form
    {
        DateTime data_hora;

        public frm_Menu()
        {
            InitializeComponent();
        }

        private void btnStrip_Calculos_Click(object sender, EventArgs e)
        {
            pnl_Calculos.Visible = true;
            pnl_Calculos.BringToFront();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            pnl_Menu.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lbl_data.Text = data_hora.ToLongDateString() + " || " + data_hora.ToLongTimeString();
        }

        private void btn_CalcPreco_Click(object sender, EventArgs e)
        {
            pnl_Preco.Visible = true;
            pnl_Preco.BringToFront();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            pnl_Menu.Visible = true;
            pnl_Calculos.Visible = false;
            pnl_Preco.Visible = false;
            pnl_Menu.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
