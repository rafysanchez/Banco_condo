namespace Condo
{
    partial class frm_Consultas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Consultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.dgv_ListarDados = new System.Windows.Forms.DataGridView();
            this.btn_cadastrarUsuario = new System.Windows.Forms.Button();
            this.btn_ConsultarEncomendas = new System.Windows.Forms.Button();
            this.btn_ConsultaEbox = new System.Windows.Forms.Button();
            this.btn_Relatorios = new System.Windows.Forms.Button();
            this.txt_tamanho = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_AtualizaLista = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarDados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(188, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 91);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 42);
            this.label2.TabIndex = 52;
            this.label2.Text = "CONSULTAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Blue;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(921, -1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(161, 94);
            this.btn_voltar.TabIndex = 19;
            this.btn_voltar.Text = "Fechar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // dgv_ListarDados
            // 
            this.dgv_ListarDados.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListarDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListarDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListarDados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListarDados.GridColor = System.Drawing.Color.White;
            this.dgv_ListarDados.Location = new System.Drawing.Point(370, 178);
            this.dgv_ListarDados.Name = "dgv_ListarDados";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListarDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ListarDados.Size = new System.Drawing.Size(702, 503);
            this.dgv_ListarDados.TabIndex = 22;
            // 
            // btn_cadastrarUsuario
            // 
            this.btn_cadastrarUsuario.BackColor = System.Drawing.Color.Blue;
            this.btn_cadastrarUsuario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrarUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrarUsuario.Location = new System.Drawing.Point(12, 178);
            this.btn_cadastrarUsuario.Name = "btn_cadastrarUsuario";
            this.btn_cadastrarUsuario.Size = new System.Drawing.Size(333, 99);
            this.btn_cadastrarUsuario.TabIndex = 23;
            this.btn_cadastrarUsuario.Text = "Consulta Usuários";
            this.btn_cadastrarUsuario.UseVisualStyleBackColor = false;
            this.btn_cadastrarUsuario.Click += new System.EventHandler(this.btn_cadastrarUsuario_Click);
            // 
            // btn_ConsultarEncomendas
            // 
            this.btn_ConsultarEncomendas.BackColor = System.Drawing.Color.Blue;
            this.btn_ConsultarEncomendas.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultarEncomendas.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ConsultarEncomendas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ConsultarEncomendas.Location = new System.Drawing.Point(12, 388);
            this.btn_ConsultarEncomendas.Name = "btn_ConsultarEncomendas";
            this.btn_ConsultarEncomendas.Size = new System.Drawing.Size(333, 99);
            this.btn_ConsultarEncomendas.TabIndex = 24;
            this.btn_ConsultarEncomendas.Text = "Consulta Encomendas";
            this.btn_ConsultarEncomendas.UseVisualStyleBackColor = false;
            this.btn_ConsultarEncomendas.Click += new System.EventHandler(this.btn_ConsultarEncomendas_Click);
            // 
            // btn_ConsultaEbox
            // 
            this.btn_ConsultaEbox.BackColor = System.Drawing.Color.Blue;
            this.btn_ConsultaEbox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConsultaEbox.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ConsultaEbox.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ConsultaEbox.Location = new System.Drawing.Point(12, 283);
            this.btn_ConsultaEbox.Name = "btn_ConsultaEbox";
            this.btn_ConsultaEbox.Size = new System.Drawing.Size(333, 99);
            this.btn_ConsultaEbox.TabIndex = 25;
            this.btn_ConsultaEbox.Text = "Consulta E-box";
            this.btn_ConsultaEbox.UseVisualStyleBackColor = false;
            this.btn_ConsultaEbox.Click += new System.EventHandler(this.btn_ConsultaEbox_Click);
            // 
            // btn_Relatorios
            // 
            this.btn_Relatorios.BackColor = System.Drawing.Color.Blue;
            this.btn_Relatorios.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorios.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Relatorios.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Relatorios.Location = new System.Drawing.Point(12, 493);
            this.btn_Relatorios.Name = "btn_Relatorios";
            this.btn_Relatorios.Size = new System.Drawing.Size(333, 99);
            this.btn_Relatorios.TabIndex = 26;
            this.btn_Relatorios.Text = "Consulta Relatórios";
            this.btn_Relatorios.UseVisualStyleBackColor = false;
            this.btn_Relatorios.Click += new System.EventHandler(this.btn_Relatorios_Click);
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tamanho.FormattingEnabled = true;
            this.txt_tamanho.Items.AddRange(new object[] {
            "Pequeno",
            "Médio",
            "Grande"});
            this.txt_tamanho.Location = new System.Drawing.Point(544, 129);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(291, 39);
            this.txt_tamanho.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(364, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 33);
            this.label14.TabIndex = 84;
            this.label14.Text = "Filtrar Por:";
            // 
            // btn_AtualizaLista
            // 
            this.btn_AtualizaLista.BackColor = System.Drawing.Color.Blue;
            this.btn_AtualizaLista.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AtualizaLista.ForeColor = System.Drawing.Color.Yellow;
            this.btn_AtualizaLista.Location = new System.Drawing.Point(851, 118);
            this.btn_AtualizaLista.Name = "btn_AtualizaLista";
            this.btn_AtualizaLista.Size = new System.Drawing.Size(221, 54);
            this.btn_AtualizaLista.TabIndex = 85;
            this.btn_AtualizaLista.Text = "Atualizar lista";
            this.btn_AtualizaLista.UseVisualStyleBackColor = false;
            this.btn_AtualizaLista.Click += new System.EventHandler(this.btn_AtualizaLista_Click);
            // 
            // frm_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1084, 684);
            this.ControlBox = false;
            this.Controls.Add(this.btn_AtualizaLista);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_tamanho);
            this.Controls.Add(this.btn_Relatorios);
            this.Controls.Add(this.btn_ConsultaEbox);
            this.Controls.Add(this.btn_ConsultarEncomendas);
            this.Controls.Add(this.btn_cadastrarUsuario);
            this.Controls.Add(this.dgv_ListarDados);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltar);
            this.Name = "frm_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Consultas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListarDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.DataGridView dgv_ListarDados;
        private System.Windows.Forms.Button btn_cadastrarUsuario;
        private System.Windows.Forms.Button btn_ConsultarEncomendas;
        private System.Windows.Forms.Button btn_ConsultaEbox;
        private System.Windows.Forms.Button btn_Relatorios;
        private System.Windows.Forms.ComboBox txt_tamanho;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_AtualizaLista;
    }
}