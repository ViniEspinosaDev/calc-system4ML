namespace SisteminhaCalculos
{
    partial class frm_Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnStrip_Calculos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStrip_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Calculos = new System.Windows.Forms.Panel();
            this.btn_Preco = new System.Windows.Forms.Button();
            this.btn_Venda = new System.Windows.Forms.Button();
            this.btn_Anuncio = new System.Windows.Forms.Button();
            this.btn_Receber = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.pnl_Preco = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_Custo = new System.Windows.Forms.TextBox();
            this.txt_ShowCusto = new System.Windows.Forms.TextBox();
            this.btn_Somar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Calculos.SuspendLayout();
            this.pnl_Preco.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStrip_Calculos,
            this.btnStrip_Sobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnStrip_Calculos
            // 
            this.btnStrip_Calculos.Name = "btnStrip_Calculos";
            this.btnStrip_Calculos.Size = new System.Drawing.Size(78, 24);
            this.btnStrip_Calculos.Text = "Calculos";
            this.btnStrip_Calculos.Click += new System.EventHandler(this.btnStrip_Calculos_Click);
            // 
            // btnStrip_Sobre
            // 
            this.btnStrip_Sobre.Name = "btnStrip_Sobre";
            this.btnStrip_Sobre.Size = new System.Drawing.Size(62, 24);
            this.btnStrip_Sobre.Text = "Sobre";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © Todos os direitos reservados";
            // 
            // lbl_data
            // 
            this.lbl_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(12, 521);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(0, 17);
            this.lbl_data.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Menu.BackgroundImage")));
            this.pnl_Menu.Controls.Add(this.pnl_Calculos);
            this.pnl_Menu.Location = new System.Drawing.Point(0, 31);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(874, 487);
            this.pnl_Menu.TabIndex = 3;
            // 
            // pnl_Calculos
            // 
            this.pnl_Calculos.Controls.Add(this.pnl_Preco);
            this.pnl_Calculos.Controls.Add(this.btn_Voltar);
            this.pnl_Calculos.Controls.Add(this.btn_Receber);
            this.pnl_Calculos.Controls.Add(this.btn_Anuncio);
            this.pnl_Calculos.Controls.Add(this.btn_Venda);
            this.pnl_Calculos.Controls.Add(this.btn_Preco);
            this.pnl_Calculos.Location = new System.Drawing.Point(0, 0);
            this.pnl_Calculos.Name = "pnl_Calculos";
            this.pnl_Calculos.Size = new System.Drawing.Size(874, 487);
            this.pnl_Calculos.TabIndex = 4;
            this.pnl_Calculos.Visible = false;
            // 
            // btn_Preco
            // 
            this.btn_Preco.Location = new System.Drawing.Point(6, 7);
            this.btn_Preco.Name = "btn_Preco";
            this.btn_Preco.Size = new System.Drawing.Size(290, 86);
            this.btn_Preco.TabIndex = 0;
            this.btn_Preco.Text = "Preço";
            this.btn_Preco.UseVisualStyleBackColor = true;
            // 
            // btn_Venda
            // 
            this.btn_Venda.Location = new System.Drawing.Point(6, 99);
            this.btn_Venda.Name = "btn_Venda";
            this.btn_Venda.Size = new System.Drawing.Size(290, 90);
            this.btn_Venda.TabIndex = 1;
            this.btn_Venda.Text = "Margem Venda";
            this.btn_Venda.UseVisualStyleBackColor = true;
            // 
            // btn_Anuncio
            // 
            this.btn_Anuncio.Location = new System.Drawing.Point(6, 195);
            this.btn_Anuncio.Name = "btn_Anuncio";
            this.btn_Anuncio.Size = new System.Drawing.Size(290, 95);
            this.btn_Anuncio.TabIndex = 2;
            this.btn_Anuncio.Text = "Margem Anúncio";
            this.btn_Anuncio.UseVisualStyleBackColor = true;
            // 
            // btn_Receber
            // 
            this.btn_Receber.Location = new System.Drawing.Point(6, 296);
            this.btn_Receber.Name = "btn_Receber";
            this.btn_Receber.Size = new System.Drawing.Size(290, 89);
            this.btn_Receber.TabIndex = 3;
            this.btn_Receber.Text = "A Receber";
            this.btn_Receber.UseVisualStyleBackColor = true;
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(6, 391);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(290, 88);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            // 
            // pnl_Preco
            // 
            this.pnl_Preco.Controls.Add(this.btn_Limpar);
            this.pnl_Preco.Controls.Add(this.label10);
            this.pnl_Preco.Controls.Add(this.button1);
            this.pnl_Preco.Controls.Add(this.textBox6);
            this.pnl_Preco.Controls.Add(this.textBox5);
            this.pnl_Preco.Controls.Add(this.textBox4);
            this.pnl_Preco.Controls.Add(this.btn_Somar);
            this.pnl_Preco.Controls.Add(this.txt_ShowCusto);
            this.pnl_Preco.Controls.Add(this.txt_Custo);
            this.pnl_Preco.Controls.Add(this.textBox3);
            this.pnl_Preco.Controls.Add(this.textBox2);
            this.pnl_Preco.Controls.Add(this.textBox1);
            this.pnl_Preco.Controls.Add(this.label9);
            this.pnl_Preco.Controls.Add(this.label8);
            this.pnl_Preco.Controls.Add(this.label7);
            this.pnl_Preco.Controls.Add(this.label6);
            this.pnl_Preco.Controls.Add(this.label5);
            this.pnl_Preco.Controls.Add(this.label4);
            this.pnl_Preco.Controls.Add(this.label3);
            this.pnl_Preco.Controls.Add(this.label2);
            this.pnl_Preco.Location = new System.Drawing.Point(303, 7);
            this.pnl_Preco.Name = "pnl_Preco";
            this.pnl_Preco.Size = new System.Drawing.Size(560, 472);
            this.pnl_Preco.TabIndex = 5;
            this.pnl_Preco.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "PREÇO DO ANÚNCIO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Custo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Margem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adicional";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Premium";
            this.label7.UseMnemonic = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(249, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Clássico";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(430, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Unidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 417);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 36);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 417);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 36);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(388, 417);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 36);
            this.textBox3.TabIndex = 10;
            // 
            // txt_Custo
            // 
            this.txt_Custo.Location = new System.Drawing.Point(136, 122);
            this.txt_Custo.Multiline = true;
            this.txt_Custo.Name = "txt_Custo";
            this.txt_Custo.Size = new System.Drawing.Size(146, 28);
            this.txt_Custo.TabIndex = 1;
            // 
            // txt_ShowCusto
            // 
            this.txt_ShowCusto.Location = new System.Drawing.Point(288, 122);
            this.txt_ShowCusto.Multiline = true;
            this.txt_ShowCusto.Name = "txt_ShowCusto";
            this.txt_ShowCusto.ReadOnly = true;
            this.txt_ShowCusto.Size = new System.Drawing.Size(149, 28);
            this.txt_ShowCusto.TabIndex = 12;
            this.txt_ShowCusto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btn_Somar
            // 
            this.btn_Somar.Location = new System.Drawing.Point(443, 120);
            this.btn_Somar.Name = "btn_Somar";
            this.btn_Somar.Size = new System.Drawing.Size(76, 32);
            this.btn_Somar.TabIndex = 13;
            this.btn_Somar.Text = "Somar";
            this.btn_Somar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 164);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(301, 28);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 205);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(301, 28);
            this.textBox5.TabIndex = 3;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(136, 243);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(301, 28);
            this.textBox6.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 66);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(431, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Calculando preço premium e clássico p/ anunciar no Mercado Livre\r\n";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(440, 3);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(117, 27);
            this.btn_Limpar.TabIndex = 19;
            this.btn_Limpar.Text = "Limpar Campos";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 547);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(892, 594);
            this.MinimumSize = new System.Drawing.Size(892, 594);
            this.Name = "frm_Menu";
            this.Text = "Calculos Mercado Livre";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Calculos.ResumeLayout(false);
            this.pnl_Preco.ResumeLayout(false);
            this.pnl_Preco.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnStrip_Calculos;
        private System.Windows.Forms.ToolStripMenuItem btnStrip_Sobre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_Calculos;
        private System.Windows.Forms.Panel pnl_Preco;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Receber;
        private System.Windows.Forms.Button btn_Anuncio;
        private System.Windows.Forms.Button btn_Venda;
        private System.Windows.Forms.Button btn_Preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Somar;
        private System.Windows.Forms.TextBox txt_ShowCusto;
        private System.Windows.Forms.TextBox txt_Custo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
    }
}

