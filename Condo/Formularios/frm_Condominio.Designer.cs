namespace Condo
{
    partial class frm_Condominio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Condominio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.painel_ebox = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_statusEbox = new System.Windows.Forms.ComboBox();
            this.txt_nomeEbox = new System.Windows.Forms.TextBox();
            this.txt_tamanho = new System.Windows.Forms.ComboBox();
            this.btn_SalvarEbox = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_idEbox = new System.Windows.Forms.TextBox();
            this.painel_unidades = new System.Windows.Forms.Panel();
            this.txt_bloco = new System.Windows.Forms.ComboBox();
            this.txt_apto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_salvarUnidaes = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel_Info_condominio = new System.Windows.Forms.Panel();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.btn_salvarCondo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_condominio = new System.Windows.Forms.TextBox();
            this.txt_rua = new System.Windows.Forms.TextBox();
            this.ckb_incluir_ebox = new System.Windows.Forms.CheckBox();
            this.ckb_Incluir_unidades = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_readSerial = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_usuario_Logado = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_Lista_Dados = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.painel_ebox.SuspendLayout();
            this.painel_unidades.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_Info_condominio.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_Dados)).BeginInit();
            this.SuspendLayout();
            // 
            // painel_ebox
            // 
            this.painel_ebox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel_ebox.Controls.Add(this.label12);
            this.painel_ebox.Controls.Add(this.txt_statusEbox);
            this.painel_ebox.Controls.Add(this.txt_nomeEbox);
            this.painel_ebox.Controls.Add(this.txt_tamanho);
            this.painel_ebox.Controls.Add(this.btn_SalvarEbox);
            this.painel_ebox.Controls.Add(this.label10);
            this.painel_ebox.Controls.Add(this.label11);
            this.painel_ebox.Controls.Add(this.txt_idEbox);
            this.painel_ebox.Location = new System.Drawing.Point(5, 173);
            this.painel_ebox.Name = "painel_ebox";
            this.painel_ebox.Size = new System.Drawing.Size(552, 369);
            this.painel_ebox.TabIndex = 101;
            this.painel_ebox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(7, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 31);
            this.label12.TabIndex = 95;
            this.label12.Text = "Status E-box:";
            // 
            // txt_statusEbox
            // 
            this.txt_statusEbox.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_statusEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusEbox.FormattingEnabled = true;
            this.txt_statusEbox.Items.AddRange(new object[] {
            "Livre",
            "Ocupado",
            "Bloqueado",
            "Inativo"});
            this.txt_statusEbox.Location = new System.Drawing.Point(203, 130);
            this.txt_statusEbox.Name = "txt_statusEbox";
            this.txt_statusEbox.Size = new System.Drawing.Size(323, 39);
            this.txt_statusEbox.TabIndex = 94;
            // 
            // txt_nomeEbox
            // 
            this.txt_nomeEbox.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nomeEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeEbox.Location = new System.Drawing.Point(254, 12);
            this.txt_nomeEbox.Name = "txt_nomeEbox";
            this.txt_nomeEbox.Size = new System.Drawing.Size(272, 38);
            this.txt_nomeEbox.TabIndex = 93;
            this.txt_nomeEbox.Click += new System.EventHandler(this.txt_nomeEbox_Click);
            // 
            // txt_tamanho
            // 
            this.txt_tamanho.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_tamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tamanho.FormattingEnabled = true;
            this.txt_tamanho.Items.AddRange(new object[] {
            "",
            "Pequeno",
            "Medio",
            "Grande"});
            this.txt_tamanho.Location = new System.Drawing.Point(203, 71);
            this.txt_tamanho.Name = "txt_tamanho";
            this.txt_tamanho.Size = new System.Drawing.Size(323, 39);
            this.txt_tamanho.TabIndex = 55;
            // 
            // btn_SalvarEbox
            // 
            this.btn_SalvarEbox.BackColor = System.Drawing.Color.Blue;
            this.btn_SalvarEbox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarEbox.ForeColor = System.Drawing.Color.Yellow;
            this.btn_SalvarEbox.Location = new System.Drawing.Point(52, 260);
            this.btn_SalvarEbox.Name = "btn_SalvarEbox";
            this.btn_SalvarEbox.Size = new System.Drawing.Size(437, 70);
            this.btn_SalvarEbox.TabIndex = 18;
            this.btn_SalvarEbox.Text = "Salvar";
            this.btn_SalvarEbox.UseVisualStyleBackColor = false;
            this.btn_SalvarEbox.Click += new System.EventHandler(this.btn_SalvarEbox_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 31);
            this.label10.TabIndex = 92;
            this.label10.Text = "Tamanho:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 31);
            this.label11.TabIndex = 45;
            this.label11.Text = "E-box";
            // 
            // txt_idEbox
            // 
            this.txt_idEbox.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_idEbox.Enabled = false;
            this.txt_idEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEbox.Location = new System.Drawing.Point(203, 12);
            this.txt_idEbox.Name = "txt_idEbox";
            this.txt_idEbox.Size = new System.Drawing.Size(45, 38);
            this.txt_idEbox.TabIndex = 31;
            // 
            // painel_unidades
            // 
            this.painel_unidades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel_unidades.Controls.Add(this.txt_bloco);
            this.painel_unidades.Controls.Add(this.txt_apto);
            this.painel_unidades.Controls.Add(this.label5);
            this.painel_unidades.Controls.Add(this.label4);
            this.painel_unidades.Controls.Add(this.btn_salvarUnidaes);
            this.painel_unidades.Controls.Add(this.label13);
            this.painel_unidades.Controls.Add(this.label14);
            this.painel_unidades.Location = new System.Drawing.Point(5, 173);
            this.painel_unidades.Name = "painel_unidades";
            this.painel_unidades.Size = new System.Drawing.Size(547, 329);
            this.painel_unidades.TabIndex = 100;
            this.painel_unidades.Visible = false;
            // 
            // txt_bloco
            // 
            this.txt_bloco.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_bloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bloco.FormattingEnabled = true;
            this.txt_bloco.Items.AddRange(new object[] {
            "Bl 01",
            "Bl 02",
            "Bl 03",
            "Bl 04",
            "Bl 05",
            "Bl 06",
            "Bl 07",
            "Bl 08",
            "Bl 09",
            "Bl 10",
            "Bl 11",
            "Bl 12",
            "Bl 13",
            "Bl 14",
            "Bl 15",
            "Bl 16",
            "Bl 17",
            "Bl 18",
            "Bl 19",
            "Bl 20",
            "Bl 21",
            "Bl 22",
            "Bl 23",
            "Bl 24",
            "Bl 25",
            "Bl 26",
            "Bl 27",
            "Bl 28",
            "Bl 29",
            "Bl 30"});
            this.txt_bloco.Location = new System.Drawing.Point(247, 72);
            this.txt_bloco.Name = "txt_bloco";
            this.txt_bloco.Size = new System.Drawing.Size(176, 39);
            this.txt_bloco.TabIndex = 107;
            // 
            // txt_apto
            // 
            this.txt_apto.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_apto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apto.FormattingEnabled = true;
            this.txt_apto.Items.AddRange(new object[] {
            "Ap 01",
            "Ap 02",
            "Ap 03",
            "Ap 04",
            "Ap 05",
            "Ap 06",
            "Ap 07",
            "Ap 08",
            "Ap 09",
            "Ap 10",
            "Ap 11",
            "Ap 12",
            "Ap 13",
            "Ap 14",
            "Ap 15",
            "Ap 16",
            "Ap 17",
            "Ap 18",
            "Ap 19",
            "Ap 20",
            "Ap 21",
            "Ap 22",
            "Ap 23",
            "Ap 24",
            "Ap 25",
            "Ap 26",
            "Ap 27",
            "Ap 28",
            "Ap 29",
            "Ap 30"});
            this.txt_apto.Location = new System.Drawing.Point(247, 20);
            this.txt_apto.Name = "txt_apto";
            this.txt_apto.Size = new System.Drawing.Size(176, 39);
            this.txt_apto.TabIndex = 106;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(429, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 105;
            this.label5.Text = "EX. bl 04";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(429, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 104;
            this.label4.Text = "EX. ap 21";
            // 
            // btn_salvarUnidaes
            // 
            this.btn_salvarUnidaes.BackColor = System.Drawing.Color.Blue;
            this.btn_salvarUnidaes.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarUnidaes.ForeColor = System.Drawing.Color.Yellow;
            this.btn_salvarUnidaes.Location = new System.Drawing.Point(52, 258);
            this.btn_salvarUnidaes.Name = "btn_salvarUnidaes";
            this.btn_salvarUnidaes.Size = new System.Drawing.Size(437, 70);
            this.btn_salvarUnidaes.TabIndex = 18;
            this.btn_salvarUnidaes.Text = "Salvar";
            this.btn_salvarUnidaes.UseVisualStyleBackColor = false;
            this.btn_salvarUnidaes.Click += new System.EventHandler(this.btn_salvarUnidaes_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(46, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 31);
            this.label13.TabIndex = 92;
            this.label13.Text = "Bloco:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(46, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 31);
            this.label14.TabIndex = 45;
            this.label14.Text = "Apartamento:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(189, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(748, 93);
            this.panel2.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(96, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(566, 37);
            this.label7.TabIndex = 53;
            this.label7.Text = "INFORMAÇÕES DO  CONDOMINIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Condo.Properties.Resources.constec;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Blue;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(938, 1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(155, 94);
            this.btn_voltar.TabIndex = 55;
            this.btn_voltar.Text = "Fechar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // panel_Info_condominio
            // 
            this.panel_Info_condominio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Info_condominio.Controls.Add(this.txt_estado);
            this.panel_Info_condominio.Controls.Add(this.btn_salvarCondo);
            this.panel_Info_condominio.Controls.Add(this.label8);
            this.panel_Info_condominio.Controls.Add(this.label3);
            this.panel_Info_condominio.Controls.Add(this.label2);
            this.panel_Info_condominio.Controls.Add(this.txt_cidade);
            this.panel_Info_condominio.Controls.Add(this.txt_numero);
            this.panel_Info_condominio.Controls.Add(this.label1);
            this.panel_Info_condominio.Controls.Add(this.label9);
            this.panel_Info_condominio.Controls.Add(this.txt_condominio);
            this.panel_Info_condominio.Controls.Add(this.txt_rua);
            this.panel_Info_condominio.Location = new System.Drawing.Point(5, 172);
            this.panel_Info_condominio.Name = "panel_Info_condominio";
            this.panel_Info_condominio.Size = new System.Drawing.Size(552, 355);
            this.panel_Info_condominio.TabIndex = 59;
            // 
            // txt_estado
            // 
            this.txt_estado.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estado.Location = new System.Drawing.Point(193, 172);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(329, 38);
            this.txt_estado.TabIndex = 98;
            // 
            // btn_salvarCondo
            // 
            this.btn_salvarCondo.BackColor = System.Drawing.Color.Blue;
            this.btn_salvarCondo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarCondo.ForeColor = System.Drawing.Color.Yellow;
            this.btn_salvarCondo.Location = new System.Drawing.Point(52, 261);
            this.btn_salvarCondo.Name = "btn_salvarCondo";
            this.btn_salvarCondo.Size = new System.Drawing.Size(437, 70);
            this.btn_salvarCondo.TabIndex = 18;
            this.btn_salvarCondo.Text = "Salvar";
            this.btn_salvarCondo.UseVisualStyleBackColor = false;
            this.btn_salvarCondo.Click += new System.EventHandler(this.btn_salvarCondo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 31);
            this.label8.TabIndex = 97;
            this.label8.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 96;
            this.label3.Text = "Cidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(393, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 95;
            this.label2.Text = "Nº:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidade.Location = new System.Drawing.Point(193, 116);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(329, 38);
            this.txt_cidade.TabIndex = 94;
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(454, 65);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(68, 38);
            this.txt_numero.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 92;
            this.label1.Text = "Rua:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(5, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 31);
            this.label9.TabIndex = 45;
            this.label9.Text = "Condominio:";
            // 
            // txt_condominio
            // 
            this.txt_condominio.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_condominio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_condominio.Location = new System.Drawing.Point(195, 13);
            this.txt_condominio.Name = "txt_condominio";
            this.txt_condominio.Size = new System.Drawing.Size(327, 38);
            this.txt_condominio.TabIndex = 31;
            // 
            // txt_rua
            // 
            this.txt_rua.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rua.Location = new System.Drawing.Point(193, 65);
            this.txt_rua.Name = "txt_rua";
            this.txt_rua.Size = new System.Drawing.Size(194, 38);
            this.txt_rua.TabIndex = 5;
            // 
            // ckb_incluir_ebox
            // 
            this.ckb_incluir_ebox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_incluir_ebox.AutoSize = true;
            this.ckb_incluir_ebox.BackColor = System.Drawing.Color.Blue;
            this.ckb_incluir_ebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_incluir_ebox.ForeColor = System.Drawing.Color.White;
            this.ckb_incluir_ebox.Location = new System.Drawing.Point(280, 112);
            this.ckb_incluir_ebox.Name = "ckb_incluir_ebox";
            this.ckb_incluir_ebox.Size = new System.Drawing.Size(187, 41);
            this.ckb_incluir_ebox.TabIndex = 62;
            this.ckb_incluir_ebox.Text = "Incluir E-box";
            this.ckb_incluir_ebox.UseVisualStyleBackColor = false;
            this.ckb_incluir_ebox.Click += new System.EventHandler(this.ckb_incluir_ebox_Click);
            // 
            // ckb_Incluir_unidades
            // 
            this.ckb_Incluir_unidades.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_Incluir_unidades.AutoSize = true;
            this.ckb_Incluir_unidades.BackColor = System.Drawing.Color.Blue;
            this.ckb_Incluir_unidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_Incluir_unidades.ForeColor = System.Drawing.Color.White;
            this.ckb_Incluir_unidades.Location = new System.Drawing.Point(28, 112);
            this.ckb_Incluir_unidades.Name = "ckb_Incluir_unidades";
            this.ckb_Incluir_unidades.Size = new System.Drawing.Size(235, 41);
            this.ckb_Incluir_unidades.TabIndex = 61;
            this.ckb_Incluir_unidades.Text = "Incluir Unidades";
            this.ckb_Incluir_unidades.UseVisualStyleBackColor = false;
            this.ckb_Incluir_unidades.Click += new System.EventHandler(this.ckb_Incluir_unidades_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_readSerial);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txt_usuario_Logado);
            this.panel1.Controls.Add(this.txt_data);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.txt_statusPort);
            this.panel1.Location = new System.Drawing.Point(1, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 40);
            this.panel1.TabIndex = 103;
            // 
            // txt_readSerial
            // 
            this.txt_readSerial.Location = new System.Drawing.Point(225, 7);
            this.txt_readSerial.Name = "txt_readSerial";
            this.txt_readSerial.Size = new System.Drawing.Size(100, 20);
            this.txt_readSerial.TabIndex = 105;
            this.txt_readSerial.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 106;
            this.comboBox1.Visible = false;
            // 
            // txt_usuario_Logado
            // 
            this.txt_usuario_Logado.AutoSize = true;
            this.txt_usuario_Logado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_Logado.ForeColor = System.Drawing.Color.Yellow;
            this.txt_usuario_Logado.Location = new System.Drawing.Point(532, 4);
            this.txt_usuario_Logado.Name = "txt_usuario_Logado";
            this.txt_usuario_Logado.Size = new System.Drawing.Size(71, 24);
            this.txt_usuario_Logado.TabIndex = 53;
            this.txt_usuario_Logado.Text = "01 xxx";
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Yellow;
            this.txt_data.Location = new System.Drawing.Point(3, 7);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(65, 24);
            this.txt_data.TabIndex = 51;
            this.txt_data.Text = "DATA";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Yellow;
            this.label21.Location = new System.Drawing.Point(439, 4);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(87, 24);
            this.label21.TabIndex = 52;
            this.label21.Text = "Usuario:";
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Yellow;
            this.txt_statusPort.Location = new System.Drawing.Point(879, 7);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(199, 24);
            this.txt_statusPort.TabIndex = 49;
            this.txt_statusPort.Text = "Não Conectado  ****";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_Lista_Dados
            // 
            this.dgv_Lista_Dados.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista_Dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Lista_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Lista_Dados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Lista_Dados.Location = new System.Drawing.Point(563, 171);
            this.dgv_Lista_Dados.Name = "dgv_Lista_Dados";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            this.dgv_Lista_Dados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Lista_Dados.Size = new System.Drawing.Size(530, 461);
            this.dgv_Lista_Dados.TabIndex = 106;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(649, 122);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(344, 31);
            this.label19.TabIndex = 105;
            this.label19.Text = "Lista de Ebox disponiveis";
            // 
            // frm_Condominio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1094, 694);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Lista_Dados);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painel_ebox);
            this.Controls.Add(this.painel_unidades);
            this.Controls.Add(this.ckb_incluir_ebox);
            this.Controls.Add(this.ckb_Incluir_unidades);
            this.Controls.Add(this.panel_Info_condominio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Condominio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Condominio_Load);
            this.painel_ebox.ResumeLayout(false);
            this.painel_ebox.PerformLayout();
            this.painel_unidades.ResumeLayout(false);
            this.painel_unidades.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_Info_condominio.ResumeLayout(false);
            this.panel_Info_condominio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_Dados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel_Info_condominio;
        private System.Windows.Forms.Button btn_salvarCondo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_condominio;
        private System.Windows.Forms.TextBox txt_rua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_incluir_ebox;
        private System.Windows.Forms.CheckBox ckb_Incluir_unidades;
        private System.Windows.Forms.Panel painel_unidades;
        private System.Windows.Forms.Button btn_salvarUnidaes;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Panel painel_ebox;
        private System.Windows.Forms.Button btn_SalvarEbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_idEbox;
        private System.Windows.Forms.TextBox txt_nomeEbox;
        private System.Windows.Forms.ComboBox txt_tamanho;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox txt_statusEbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txt_bloco;
        private System.Windows.Forms.ComboBox txt_apto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_usuario_Logado;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.TextBox txt_readSerial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_Lista_Dados;
        private System.Windows.Forms.Label label19;

    }
}