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
            this.pnl_Preco = new System.Windows.Forms.Panel();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnPreco_Calcular = new System.Windows.Forms.Button();
            this.txtPreco_Adicional = new System.Windows.Forms.TextBox();
            this.txtPreco_Margem = new System.Windows.Forms.TextBox();
            this.txtPreco_Quantidade = new System.Windows.Forms.TextBox();
            this.btnPreco_Somar = new System.Windows.Forms.Button();
            this.txtPreco_ShowCusto = new System.Windows.Forms.TextBox();
            this.txtPreco_Custo = new System.Windows.Forms.TextBox();
            this.txtPreco_ValUnidade = new System.Windows.Forms.TextBox();
            this.txtPreco_Classico = new System.Windows.Forms.TextBox();
            this.txtPreco_Premium = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Receber = new System.Windows.Forms.Button();
            this.btn_Anuncio = new System.Windows.Forms.Button();
            this.btn_Venda = new System.Windows.Forms.Button();
            this.btn_Preco = new System.Windows.Forms.Button();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnStrip_Calculos
            // 
            this.btnStrip_Calculos.Name = "btnStrip_Calculos";
            this.btnStrip_Calculos.Size = new System.Drawing.Size(64, 20);
            this.btnStrip_Calculos.Text = "Calculos";
            this.btnStrip_Calculos.Click += new System.EventHandler(this.btnStrip_Calculos_Click);
            // 
            // btnStrip_Sobre
            // 
            this.btnStrip_Sobre.Name = "btnStrip_Sobre";
            this.btnStrip_Sobre.Size = new System.Drawing.Size(49, 20);
            this.btnStrip_Sobre.Text = "Sobre";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(444, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Copyright © Todos os direitos reservados";
            // 
            // lbl_data
            // 
            this.lbl_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(9, 423);
            this.lbl_data.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(0, 13);
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
            this.pnl_Menu.Location = new System.Drawing.Point(0, 25);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(656, 396);
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
            this.pnl_Calculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Calculos.Name = "pnl_Calculos";
            this.pnl_Calculos.Size = new System.Drawing.Size(656, 396);
            this.pnl_Calculos.TabIndex = 4;
            this.pnl_Calculos.Visible = false;
            // 
            // pnl_Preco
            // 
            this.pnl_Preco.Controls.Add(this.btn_Limpar);
            this.pnl_Preco.Controls.Add(this.label10);
            this.pnl_Preco.Controls.Add(this.btnPreco_Calcular);
            this.pnl_Preco.Controls.Add(this.txtPreco_Adicional);
            this.pnl_Preco.Controls.Add(this.txtPreco_Margem);
            this.pnl_Preco.Controls.Add(this.txtPreco_Quantidade);
            this.pnl_Preco.Controls.Add(this.btnPreco_Somar);
            this.pnl_Preco.Controls.Add(this.txtPreco_ShowCusto);
            this.pnl_Preco.Controls.Add(this.txtPreco_Custo);
            this.pnl_Preco.Controls.Add(this.txtPreco_ValUnidade);
            this.pnl_Preco.Controls.Add(this.txtPreco_Classico);
            this.pnl_Preco.Controls.Add(this.txtPreco_Premium);
            this.pnl_Preco.Controls.Add(this.label9);
            this.pnl_Preco.Controls.Add(this.label8);
            this.pnl_Preco.Controls.Add(this.label7);
            this.pnl_Preco.Controls.Add(this.label6);
            this.pnl_Preco.Controls.Add(this.label5);
            this.pnl_Preco.Controls.Add(this.label4);
            this.pnl_Preco.Controls.Add(this.label3);
            this.pnl_Preco.Controls.Add(this.label2);
            this.pnl_Preco.Location = new System.Drawing.Point(227, 6);
            this.pnl_Preco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_Preco.Name = "pnl_Preco";
            this.pnl_Preco.Size = new System.Drawing.Size(420, 384);
            this.pnl_Preco.TabIndex = 5;
            this.pnl_Preco.Visible = false;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(330, 2);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(88, 22);
            this.btn_Limpar.TabIndex = 19;
            this.btn_Limpar.Text = "Limpar Campos";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(326, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Calculando preço premium e clássico p/ anunciar no Mercado Livre\r\n";
            // 
            // btnPreco_Calcular
            // 
            this.btnPreco_Calcular.Location = new System.Drawing.Point(61, 244);
            this.btnPreco_Calcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreco_Calcular.Name = "btnPreco_Calcular";
            this.btnPreco_Calcular.Size = new System.Drawing.Size(290, 54);
            this.btnPreco_Calcular.TabIndex = 5;
            this.btnPreco_Calcular.Text = "Calcular";
            this.btnPreco_Calcular.UseVisualStyleBackColor = true;
            this.btnPreco_Calcular.Click += new System.EventHandler(this.btnPreco_Calcular_Click);
            // 
            // txtPreco_Adicional
            // 
            this.txtPreco_Adicional.Location = new System.Drawing.Point(102, 197);
            this.txtPreco_Adicional.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_Adicional.Multiline = true;
            this.txtPreco_Adicional.Name = "txtPreco_Adicional";
            this.txtPreco_Adicional.Size = new System.Drawing.Size(227, 24);
            this.txtPreco_Adicional.TabIndex = 4;
            // 
            // txtPreco_Margem
            // 
            this.txtPreco_Margem.Location = new System.Drawing.Point(102, 167);
            this.txtPreco_Margem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_Margem.Multiline = true;
            this.txtPreco_Margem.Name = "txtPreco_Margem";
            this.txtPreco_Margem.Size = new System.Drawing.Size(227, 24);
            this.txtPreco_Margem.TabIndex = 3;
            // 
            // txtPreco_Quantidade
            // 
            this.txtPreco_Quantidade.Location = new System.Drawing.Point(102, 133);
            this.txtPreco_Quantidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_Quantidade.Multiline = true;
            this.txtPreco_Quantidade.Name = "txtPreco_Quantidade";
            this.txtPreco_Quantidade.Size = new System.Drawing.Size(227, 24);
            this.txtPreco_Quantidade.TabIndex = 2;
            // 
            // btnPreco_Somar
            // 
            this.btnPreco_Somar.Location = new System.Drawing.Point(332, 98);
            this.btnPreco_Somar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPreco_Somar.Name = "btnPreco_Somar";
            this.btnPreco_Somar.Size = new System.Drawing.Size(57, 26);
            this.btnPreco_Somar.TabIndex = 13;
            this.btnPreco_Somar.Text = "Somar";
            this.btnPreco_Somar.UseVisualStyleBackColor = true;
            this.btnPreco_Somar.Click += new System.EventHandler(this.btnPreco_Somar_Click);
            // 
            // txtPreco_ShowCusto
            // 
            this.txtPreco_ShowCusto.Location = new System.Drawing.Point(216, 99);
            this.txtPreco_ShowCusto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_ShowCusto.Multiline = true;
            this.txtPreco_ShowCusto.Name = "txtPreco_ShowCusto";
            this.txtPreco_ShowCusto.ReadOnly = true;
            this.txtPreco_ShowCusto.Size = new System.Drawing.Size(113, 24);
            this.txtPreco_ShowCusto.TabIndex = 12;
            this.txtPreco_ShowCusto.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPreco_Custo
            // 
            this.txtPreco_Custo.Location = new System.Drawing.Point(102, 99);
            this.txtPreco_Custo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_Custo.Multiline = true;
            this.txtPreco_Custo.Name = "txtPreco_Custo";
            this.txtPreco_Custo.Size = new System.Drawing.Size(110, 24);
            this.txtPreco_Custo.TabIndex = 1;
            // 
            // txtPreco_ValUnidade
            // 
            this.txtPreco_ValUnidade.Location = new System.Drawing.Point(291, 339);
            this.txtPreco_ValUnidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_ValUnidade.Multiline = true;
            this.txtPreco_ValUnidade.Name = "txtPreco_ValUnidade";
            this.txtPreco_ValUnidade.Size = new System.Drawing.Size(120, 30);
            this.txtPreco_ValUnidade.TabIndex = 10;
            // 
            // txtPreco_Classico
            // 
            this.txtPreco_Classico.Location = new System.Drawing.Point(154, 339);
            this.txtPreco_Classico.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_Classico.Multiline = true;
            this.txtPreco_Classico.Name = "txtPreco_Classico";
            this.txtPreco_Classico.Size = new System.Drawing.Size(120, 30);
            this.txtPreco_Classico.TabIndex = 9;
            // 
            // txtPreco_Premium
            // 
            this.txtPreco_Premium.Location = new System.Drawing.Point(10, 339);
            this.txtPreco_Premium.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPreco_Premium.Multiline = true;
            this.txtPreco_Premium.Name = "txtPreco_Premium";
            this.txtPreco_Premium.Size = new System.Drawing.Size(120, 30);
            this.txtPreco_Premium.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 312);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Unidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 312);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Clássico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 312);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Premium";
            this.label7.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Adicional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Margem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Custo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "PREÇO DO ANÚNCIO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(4, 318);
            this.btn_Voltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(218, 72);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Receber
            // 
            this.btn_Receber.Location = new System.Drawing.Point(4, 240);
            this.btn_Receber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Receber.Name = "btn_Receber";
            this.btn_Receber.Size = new System.Drawing.Size(218, 72);
            this.btn_Receber.TabIndex = 3;
            this.btn_Receber.Text = "A Receber";
            this.btn_Receber.UseVisualStyleBackColor = true;
            this.btn_Receber.Click += new System.EventHandler(this.btn_Receber_Click);
            // 
            // btn_Anuncio
            // 
            this.btn_Anuncio.Location = new System.Drawing.Point(4, 158);
            this.btn_Anuncio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Anuncio.Name = "btn_Anuncio";
            this.btn_Anuncio.Size = new System.Drawing.Size(218, 77);
            this.btn_Anuncio.TabIndex = 2;
            this.btn_Anuncio.Text = "Margem Anúncio";
            this.btn_Anuncio.UseVisualStyleBackColor = true;
            this.btn_Anuncio.Click += new System.EventHandler(this.btn_Anuncio_Click);
            // 
            // btn_Venda
            // 
            this.btn_Venda.Location = new System.Drawing.Point(4, 80);
            this.btn_Venda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Venda.Name = "btn_Venda";
            this.btn_Venda.Size = new System.Drawing.Size(218, 73);
            this.btn_Venda.TabIndex = 1;
            this.btn_Venda.Text = "Margem Venda";
            this.btn_Venda.UseVisualStyleBackColor = true;
            this.btn_Venda.Click += new System.EventHandler(this.btn_Venda_Click);
            // 
            // btn_Preco
            // 
            this.btn_Preco.Location = new System.Drawing.Point(4, 6);
            this.btn_Preco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Preco.Name = "btn_Preco";
            this.btn_Preco.Size = new System.Drawing.Size(218, 70);
            this.btn_Preco.TabIndex = 0;
            this.btn_Preco.Text = "Preço";
            this.btn_Preco.UseVisualStyleBackColor = true;
            this.btn_Preco.Click += new System.EventHandler(this.btn_Preco_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 451);
            this.Controls.Add(this.pnl_Menu);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(673, 490);
            this.MinimumSize = new System.Drawing.Size(673, 490);
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
        private System.Windows.Forms.Button btnPreco_Somar;
        private System.Windows.Forms.TextBox txtPreco_ShowCusto;
        private System.Windows.Forms.TextBox txtPreco_Custo;
        private System.Windows.Forms.TextBox txtPreco_ValUnidade;
        private System.Windows.Forms.TextBox txtPreco_Classico;
        private System.Windows.Forms.TextBox txtPreco_Premium;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnPreco_Calcular;
        private System.Windows.Forms.TextBox txtPreco_Adicional;
        private System.Windows.Forms.TextBox txtPreco_Margem;
        private System.Windows.Forms.TextBox txtPreco_Quantidade;
    }
}

