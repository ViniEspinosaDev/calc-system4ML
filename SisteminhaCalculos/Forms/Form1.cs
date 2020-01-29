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
        double precoCusto;

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

        private void btnPreco_Somar_Click(object sender, EventArgs e)
        {
            try
            {
                precoCusto += double.Parse(txtPreco_Custo.Text);
                txtPreco_ShowCusto.Text = "R$" + precoCusto.ToString("F2");
                txtPreco_Custo.Text = "";
            }
            catch (Exception ee)
            {
                MessageBox.Show("Verifique os campos de texto");
            }
        }

        private void btn_Preco_Click(object sender, EventArgs e)
        {
            pnl_Preco.Visible = true;
            pnl_Preco.BringToFront();
            //pnl_Menu.Visible = false;
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            pnl_Calculos.Visible = false;
            pnl_Menu.Visible = true;
            pnl_Preco.Visible = false;
            pnl_Menu.BringToFront();
        }

        private void btn_Venda_Click(object sender, EventArgs e)
        {
            pnl_Preco.Visible = false;
        }

        private void btn_Anuncio_Click(object sender, EventArgs e)
        {
            pnl_Preco.Visible = false;
        }

        private void btn_Receber_Click(object sender, EventArgs e)
        {
            pnl_Preco.Visible = false;
        }

        private void btnPreco_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double adicional = double.Parse(txtPreco_Adicional.Text);
                double custo;
                if (txtPreco_ShowCusto.Text.Equals(""))
                {
                    custo = double.Parse(txtPreco_Custo.Text);
                }
                else
                {
                    custo = double.Parse(txtPreco_ShowCusto.Text);
                }
                double margem = double.Parse(txtPreco_Margem.Text);
                int quantidade = int.Parse(txtPreco_Quantidade.Text);

                double valUnidade = 0;
                //txtPreco_ValUnidade.Text

            }
            catch (Exception ee)
            {
                MessageBox.Show("Verifique os campos de texto");
            }



        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {

        }
    }
}
