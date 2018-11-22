namespace Condo
{
    partial class frm_manutencao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.ckb_liberar = new System.Windows.Forms.CheckBox();
            this.ckb_bloquearEbox = new System.Windows.Forms.CheckBox();
            this.ckb_abrirEbox = new System.Windows.Forms.CheckBox();
            this.ckb_conectar = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_listaPorta = new System.Windows.Forms.ComboBox();
            this.txt_usuario_Logado = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_bloqueio = new System.Windows.Forms.TabPage();
            this.dgv_ListaBloqueio = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.painel_bloqeio = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_cancelarBloqueio = new System.Windows.Forms.Button();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.txt_nomeEbox = new System.Windows.Forms.ComboBox();
            this.btn_salvarBloqeio = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_idEbox = new System.Windows.Forms.TextBox();
            this.txt_dataOcorrencia = new System.Windows.Forms.MaskedTextBox();
            this.tabPage_desbloqueio = new System.Windows.Forms.TabPage();
            this.dgv_ListaDesbloqueio = new System.Windows.Forms.DataGridView();
            this.label20 = new System.Windows.Forms.Label();
            this.painel_Desbloqueio = new System.Windows.Forms.Panel();
            this.txt_nomeEbox_desbloqueio = new System.Windows.Forms.ComboBox();
            this.txt_dataDesbloqueio = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_idEbox_desbloqueio = new System.Windows.Forms.TextBox();
            this.txt_coment = new System.Windows.Forms.TextBox();
            this.txt_responsavel = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_empresa = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_ccancelarDesbloqueio = new System.Windows.Forms.Button();
            this.btn_salvarDesbloqueio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage_abertura = new System.Windows.Forms.TabPage();
            this.dgv_Lista_LogAbertura = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.panel_Aberturas = new System.Windows.Forms.Panel();
            this.ckb_abrirTodos = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CancelarAbertura = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_MotivoAbertura = new System.Windows.Forms.TextBox();
            this.txt_NomeEbox_abertura = new System.Windows.Forms.ComboBox();
            this.btn_ConfirmarAbertura = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_idEbox_abertura = new System.Windows.Forms.TextBox();
            this.tabPage_conexao = new System.Windows.Forms.TabPage();
            this.dgv_ListaErrosConexao = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.panel_configConexao = new System.Windows.Forms.Panel();
            this.txt_estadoPorta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_desconectar = new System.Windows.Forms.Button();
            this.txt_ListPort = new System.Windows.Forms.ComboBox();
            this.btn_conectar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.tabPage_bloqueio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaBloqueio)).BeginInit();
            this.painel_bloqeio.SuspendLayout();
            this.tabPage_desbloqueio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaDesbloqueio)).BeginInit();
            this.painel_Desbloqueio.SuspendLayout();
            this.tabPage_abertura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_LogAbertura)).BeginInit();
            this.panel_Aberturas.SuspendLayout();
            this.tabPage_conexao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaErrosConexao)).BeginInit();
            this.panel_configConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(189, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 93);
            this.panel2.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(192, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(294, 42);
            this.label15.TabIndex = 53;
            this.label15.Text = "MANUTENÇÃO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Condo.Properties.Resources.constec;
            this.pictureBox1.Location = new System.Drawing.Point(3, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Blue;
            this.btn_fechar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_fechar.Image = global::Condo.Properties.Resources.Voltar;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fechar.Location = new System.Drawing.Point(922, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(161, 94);
            this.btn_fechar.TabIndex = 25;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // ckb_liberar
            // 
            this.ckb_liberar.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_liberar.AutoSize = true;
            this.ckb_liberar.BackColor = System.Drawing.Color.Blue;
            this.ckb_liberar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_liberar.ForeColor = System.Drawing.Color.White;
            this.ckb_liberar.Location = new System.Drawing.Point(316, 110);
            this.ckb_liberar.Name = "ckb_liberar";
            this.ckb_liberar.Size = new System.Drawing.Size(198, 41);
            this.ckb_liberar.TabIndex = 63;
            this.ckb_liberar.Text = "Liberar E-box";
            this.ckb_liberar.UseVisualStyleBackColor = false;
            this.ckb_liberar.CheckedChanged += new System.EventHandler(this.ckb_liberar_CheckedChanged);
            // 
            // ckb_bloquearEbox
            // 
            this.ckb_bloquearEbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_bloquearEbox.AutoSize = true;
            this.ckb_bloquearEbox.BackColor = System.Drawing.Color.Blue;
            this.ckb_bloquearEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_bloquearEbox.ForeColor = System.Drawing.Color.White;
            this.ckb_bloquearEbox.Location = new System.Drawing.Point(73, 110);
            this.ckb_bloquearEbox.Name = "ckb_bloquearEbox";
            this.ckb_bloquearEbox.Size = new System.Drawing.Size(223, 41);
            this.ckb_bloquearEbox.TabIndex = 64;
            this.ckb_bloquearEbox.Text = "Bloquear E-box";
            this.ckb_bloquearEbox.UseVisualStyleBackColor = false;
            this.ckb_bloquearEbox.CheckedChanged += new System.EventHandler(this.ckb_bloquearEbox_CheckedChanged);
            // 
            // ckb_abrirEbox
            // 
            this.ckb_abrirEbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_abrirEbox.AutoSize = true;
            this.ckb_abrirEbox.BackColor = System.Drawing.Color.Blue;
            this.ckb_abrirEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_abrirEbox.ForeColor = System.Drawing.Color.White;
            this.ckb_abrirEbox.Location = new System.Drawing.Point(529, 110);
            this.ckb_abrirEbox.Name = "ckb_abrirEbox";
            this.ckb_abrirEbox.Size = new System.Drawing.Size(219, 41);
            this.ckb_abrirEbox.TabIndex = 65;
            this.ckb_abrirEbox.Text = "Abertura E-box";
            this.ckb_abrirEbox.UseVisualStyleBackColor = false;
            this.ckb_abrirEbox.CheckedChanged += new System.EventHandler(this.ckb_abrirEbox_CheckedChanged);
            // 
            // ckb_conectar
            // 
            this.ckb_conectar.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_conectar.AutoSize = true;
            this.ckb_conectar.BackColor = System.Drawing.Color.Blue;
            this.ckb_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_conectar.ForeColor = System.Drawing.Color.White;
            this.ckb_conectar.Location = new System.Drawing.Point(763, 110);
            this.ckb_conectar.Name = "ckb_conectar";
            this.ckb_conectar.Size = new System.Drawing.Size(252, 41);
            this.ckb_conectar.TabIndex = 68;
            this.ckb_conectar.Text = "Conexão Sistema";
            this.ckb_conectar.UseVisualStyleBackColor = false;
            this.ckb_conectar.CheckedChanged += new System.EventHandler(this.ckb_conectar_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_listaPorta);
            this.panel1.Controls.Add(this.txt_usuario_Logado);
            this.panel1.Controls.Add(this.txt_data);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_statusPort);
            this.panel1.Location = new System.Drawing.Point(2, 641);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 40);
            this.panel1.TabIndex = 104;
            // 
            // txt_listaPorta
            // 
            this.txt_listaPorta.FormattingEnabled = true;
            this.txt_listaPorta.Location = new System.Drawing.Point(219, 3);
            this.txt_listaPorta.Name = "txt_listaPorta";
            this.txt_listaPorta.Size = new System.Drawing.Size(121, 21);
            this.txt_listaPorta.TabIndex = 54;
            this.txt_listaPorta.Visible = false;
            // 
            // txt_usuario_Logado
            // 
            this.txt_usuario_Logado.AutoSize = true;
            this.txt_usuario_Logado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_Logado.ForeColor = System.Drawing.Color.Yellow;
            this.txt_usuario_Logado.Location = new System.Drawing.Point(546, 6);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(453, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Usuario:";
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Yellow;
            this.txt_statusPort.Location = new System.Drawing.Point(867, 6);
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
            // TabControl1
            // 
            this.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl1.Controls.Add(this.tabPage_bloqueio);
            this.TabControl1.Controls.Add(this.tabPage_desbloqueio);
            this.TabControl1.Controls.Add(this.tabPage_abertura);
            this.TabControl1.Controls.Add(this.tabPage_conexao);
            this.TabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl1.Location = new System.Drawing.Point(5, 157);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1075, 468);
            this.TabControl1.TabIndex = 105;
            // 
            // tabPage_bloqueio
            // 
            this.tabPage_bloqueio.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage_bloqueio.Controls.Add(this.dgv_ListaBloqueio);
            this.tabPage_bloqueio.Controls.Add(this.label17);
            this.tabPage_bloqueio.Controls.Add(this.painel_bloqeio);
            this.tabPage_bloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_bloqueio.Location = new System.Drawing.Point(4, 32);
            this.tabPage_bloqueio.Name = "tabPage_bloqueio";
            this.tabPage_bloqueio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_bloqueio.Size = new System.Drawing.Size(1067, 432);
            this.tabPage_bloqueio.TabIndex = 0;
            this.tabPage_bloqueio.Text = "Bloqueio Compartimento";
            // 
            // dgv_ListaBloqueio
            // 
            this.dgv_ListaBloqueio.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaBloqueio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListaBloqueio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaBloqueio.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListaBloqueio.Location = new System.Drawing.Point(500, 53);
            this.dgv_ListaBloqueio.Name = "dgv_ListaBloqueio";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            this.dgv_ListaBloqueio.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ListaBloqueio.Size = new System.Drawing.Size(561, 373);
            this.dgv_ListaBloqueio.TabIndex = 70;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(622, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(333, 31);
            this.label17.TabIndex = 57;
            this.label17.Text = "Lista de Ebox bloqueado";
            // 
            // painel_bloqeio
            // 
            this.painel_bloqeio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel_bloqeio.Controls.Add(this.label25);
            this.painel_bloqeio.Controls.Add(this.label24);
            this.painel_bloqeio.Controls.Add(this.btn_cancelarBloqueio);
            this.painel_bloqeio.Controls.Add(this.txt_motivo);
            this.painel_bloqeio.Controls.Add(this.txt_nomeEbox);
            this.painel_bloqeio.Controls.Add(this.btn_salvarBloqeio);
            this.painel_bloqeio.Controls.Add(this.label22);
            this.painel_bloqeio.Controls.Add(this.label23);
            this.painel_bloqeio.Controls.Add(this.txt_idEbox);
            this.painel_bloqeio.Controls.Add(this.txt_dataOcorrencia);
            this.painel_bloqeio.Location = new System.Drawing.Point(6, 6);
            this.painel_bloqeio.Name = "painel_bloqeio";
            this.painel_bloqeio.Size = new System.Drawing.Size(486, 420);
            this.painel_bloqeio.TabIndex = 69;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(8, 219);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(166, 31);
            this.label25.TabIndex = 56;
            this.label25.Text = "Data Ocorr.";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(6, 145);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(109, 31);
            this.label24.TabIndex = 55;
            this.label24.Text = "Motivo:";
            // 
            // btn_cancelarBloqueio
            // 
            this.btn_cancelarBloqueio.BackColor = System.Drawing.Color.Blue;
            this.btn_cancelarBloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarBloqueio.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cancelarBloqueio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelarBloqueio.Location = new System.Drawing.Point(249, 345);
            this.btn_cancelarBloqueio.Name = "btn_cancelarBloqueio";
            this.btn_cancelarBloqueio.Size = new System.Drawing.Size(209, 54);
            this.btn_cancelarBloqueio.TabIndex = 43;
            this.btn_cancelarBloqueio.Text = "Cancelar";
            this.btn_cancelarBloqueio.UseVisualStyleBackColor = false;
            this.btn_cancelarBloqueio.Click += new System.EventHandler(this.btn_cancelarBloqueio_Click);
            // 
            // txt_motivo
            // 
            this.txt_motivo.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_motivo.Location = new System.Drawing.Point(180, 125);
            this.txt_motivo.MaxLength = 10000;
            this.txt_motivo.Multiline = true;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(292, 79);
            this.txt_motivo.TabIndex = 46;
            // 
            // txt_nomeEbox
            // 
            this.txt_nomeEbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_nomeEbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_nomeEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeEbox.FormattingEnabled = true;
            this.txt_nomeEbox.Items.AddRange(new object[] {
            ""});
            this.txt_nomeEbox.Location = new System.Drawing.Point(180, 71);
            this.txt_nomeEbox.Name = "txt_nomeEbox";
            this.txt_nomeEbox.Size = new System.Drawing.Size(292, 39);
            this.txt_nomeEbox.TabIndex = 54;
            this.txt_nomeEbox.SelectedIndexChanged += new System.EventHandler(this.txt_nomeEbox_SelectedIndexChanged);
            this.txt_nomeEbox.Click += new System.EventHandler(this.txt_nomeEbox_Click);
            // 
            // btn_salvarBloqeio
            // 
            this.btn_salvarBloqeio.BackColor = System.Drawing.Color.Blue;
            this.btn_salvarBloqeio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarBloqeio.ForeColor = System.Drawing.Color.Yellow;
            this.btn_salvarBloqeio.Location = new System.Drawing.Point(14, 345);
            this.btn_salvarBloqeio.Name = "btn_salvarBloqeio";
            this.btn_salvarBloqeio.Size = new System.Drawing.Size(229, 54);
            this.btn_salvarBloqeio.TabIndex = 18;
            this.btn_salvarBloqeio.Text = "Salvar";
            this.btn_salvarBloqeio.UseVisualStyleBackColor = false;
            this.btn_salvarBloqeio.Click += new System.EventHandler(this.btn_salvarBloqeio_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Yellow;
            this.label22.Location = new System.Drawing.Point(32, 12);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(426, 37);
            this.label22.TabIndex = 49;
            this.label22.Text = "Registro de bloqueio E-box";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(8, 74);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 31);
            this.label23.TabIndex = 45;
            this.label23.Text = "E-box:";
            // 
            // txt_idEbox
            // 
            this.txt_idEbox.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_idEbox.Enabled = false;
            this.txt_idEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEbox.Location = new System.Drawing.Point(124, 71);
            this.txt_idEbox.Name = "txt_idEbox";
            this.txt_idEbox.Size = new System.Drawing.Size(50, 38);
            this.txt_idEbox.TabIndex = 31;
            // 
            // txt_dataOcorrencia
            // 
            this.txt_dataOcorrencia.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_dataOcorrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataOcorrencia.Location = new System.Drawing.Point(180, 219);
            this.txt_dataOcorrencia.Mask = "00/00/0000";
            this.txt_dataOcorrencia.Name = "txt_dataOcorrencia";
            this.txt_dataOcorrencia.Size = new System.Drawing.Size(147, 38);
            this.txt_dataOcorrencia.TabIndex = 49;
            this.txt_dataOcorrencia.ValidatingType = typeof(System.DateTime);
            // 
            // tabPage_desbloqueio
            // 
            this.tabPage_desbloqueio.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage_desbloqueio.Controls.Add(this.dgv_ListaDesbloqueio);
            this.tabPage_desbloqueio.Controls.Add(this.label20);
            this.tabPage_desbloqueio.Controls.Add(this.painel_Desbloqueio);
            this.tabPage_desbloqueio.Location = new System.Drawing.Point(4, 32);
            this.tabPage_desbloqueio.Name = "tabPage_desbloqueio";
            this.tabPage_desbloqueio.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_desbloqueio.Size = new System.Drawing.Size(1067, 432);
            this.tabPage_desbloqueio.TabIndex = 3;
            this.tabPage_desbloqueio.Text = "Desbloqueio Compartimento";
            // 
            // dgv_ListaDesbloqueio
            // 
            this.dgv_ListaDesbloqueio.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaDesbloqueio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ListaDesbloqueio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaDesbloqueio.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ListaDesbloqueio.Location = new System.Drawing.Point(495, 61);
            this.dgv_ListaDesbloqueio.Name = "dgv_ListaDesbloqueio";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            this.dgv_ListaDesbloqueio.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ListaDesbloqueio.Size = new System.Drawing.Size(566, 365);
            this.dgv_ListaDesbloqueio.TabIndex = 74;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(614, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(363, 31);
            this.label20.TabIndex = 73;
            this.label20.Text = "Lista ultimas Ebox liberada";
            // 
            // painel_Desbloqueio
            // 
            this.painel_Desbloqueio.BackColor = System.Drawing.Color.Transparent;
            this.painel_Desbloqueio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel_Desbloqueio.Controls.Add(this.txt_nomeEbox_desbloqueio);
            this.painel_Desbloqueio.Controls.Add(this.txt_dataDesbloqueio);
            this.painel_Desbloqueio.Controls.Add(this.label6);
            this.painel_Desbloqueio.Controls.Add(this.label5);
            this.painel_Desbloqueio.Controls.Add(this.label4);
            this.painel_Desbloqueio.Controls.Add(this.txt_idEbox_desbloqueio);
            this.painel_Desbloqueio.Controls.Add(this.txt_coment);
            this.painel_Desbloqueio.Controls.Add(this.txt_responsavel);
            this.painel_Desbloqueio.Controls.Add(this.label26);
            this.painel_Desbloqueio.Controls.Add(this.txt_empresa);
            this.painel_Desbloqueio.Controls.Add(this.label18);
            this.painel_Desbloqueio.Controls.Add(this.label13);
            this.painel_Desbloqueio.Controls.Add(this.label11);
            this.painel_Desbloqueio.Controls.Add(this.label21);
            this.painel_Desbloqueio.Controls.Add(this.btn_ccancelarDesbloqueio);
            this.painel_Desbloqueio.Controls.Add(this.btn_salvarDesbloqueio);
            this.painel_Desbloqueio.Controls.Add(this.label7);
            this.painel_Desbloqueio.Location = new System.Drawing.Point(6, 6);
            this.painel_Desbloqueio.Name = "painel_Desbloqueio";
            this.painel_Desbloqueio.Size = new System.Drawing.Size(483, 420);
            this.painel_Desbloqueio.TabIndex = 69;
            // 
            // txt_nomeEbox_desbloqueio
            // 
            this.txt_nomeEbox_desbloqueio.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nomeEbox_desbloqueio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_nomeEbox_desbloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeEbox_desbloqueio.FormattingEnabled = true;
            this.txt_nomeEbox_desbloqueio.Items.AddRange(new object[] {
            ""});
            this.txt_nomeEbox_desbloqueio.Location = new System.Drawing.Point(258, 146);
            this.txt_nomeEbox_desbloqueio.Name = "txt_nomeEbox_desbloqueio";
            this.txt_nomeEbox_desbloqueio.Size = new System.Drawing.Size(207, 39);
            this.txt_nomeEbox_desbloqueio.TabIndex = 63;
            this.txt_nomeEbox_desbloqueio.SelectedIndexChanged += new System.EventHandler(this.txt_nomeEbox_desbloqueio_SelectedIndexChanged);
            this.txt_nomeEbox_desbloqueio.Click += new System.EventHandler(this.txt_nomeEbox_desbloqueio_Click);
            // 
            // txt_dataDesbloqueio
            // 
            this.txt_dataDesbloqueio.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_dataDesbloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataDesbloqueio.Location = new System.Drawing.Point(201, 253);
            this.txt_dataDesbloqueio.Mask = "00/00/0000";
            this.txt_dataDesbloqueio.Name = "txt_dataDesbloqueio";
            this.txt_dataDesbloqueio.Size = new System.Drawing.Size(124, 38);
            this.txt_dataDesbloqueio.TabIndex = 57;
            this.txt_dataDesbloqueio.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 31);
            this.label6.TabIndex = 62;
            this.label6.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-2, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 61;
            this.label5.Text = "Comentário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 31);
            this.label4.TabIndex = 57;
            this.label4.Text = "E-box:";
            // 
            // txt_idEbox_desbloqueio
            // 
            this.txt_idEbox_desbloqueio.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_idEbox_desbloqueio.Enabled = false;
            this.txt_idEbox_desbloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEbox_desbloqueio.Location = new System.Drawing.Point(201, 148);
            this.txt_idEbox_desbloqueio.Name = "txt_idEbox_desbloqueio";
            this.txt_idEbox_desbloqueio.Size = new System.Drawing.Size(50, 38);
            this.txt_idEbox_desbloqueio.TabIndex = 57;
            // 
            // txt_coment
            // 
            this.txt_coment.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_coment.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_coment.Location = new System.Drawing.Point(201, 193);
            this.txt_coment.Multiline = true;
            this.txt_coment.Name = "txt_coment";
            this.txt_coment.Size = new System.Drawing.Size(264, 54);
            this.txt_coment.TabIndex = 59;
            // 
            // txt_responsavel
            // 
            this.txt_responsavel.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_responsavel.Location = new System.Drawing.Point(202, 101);
            this.txt_responsavel.Name = "txt_responsavel";
            this.txt_responsavel.Size = new System.Drawing.Size(263, 38);
            this.txt_responsavel.TabIndex = 57;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(4, 104);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(192, 31);
            this.label26.TabIndex = 57;
            this.label26.Text = "Responsável:";
            // 
            // txt_empresa
            // 
            this.txt_empresa.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empresa.FormattingEnabled = true;
            this.txt_empresa.Items.AddRange(new object[] {
            ""});
            this.txt_empresa.Location = new System.Drawing.Point(202, 53);
            this.txt_empresa.Name = "txt_empresa";
            this.txt_empresa.Size = new System.Drawing.Size(263, 39);
            this.txt_empresa.TabIndex = 57;
            this.txt_empresa.SelectedIndexChanged += new System.EventHandler(this.txt_empresa_SelectedIndexChanged);
            this.txt_empresa.Click += new System.EventHandler(this.txt_empresa_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(28, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(412, 31);
            this.label18.TabIndex = 57;
            this.label18.Text = "Registro de desbloqueio E-box";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(4, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 31);
            this.label13.TabIndex = 57;
            this.label13.Text = "Empresa:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(358, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 51;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(113, -66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 31);
            this.label21.TabIndex = 52;
            this.label21.Text = "Apto:";
            // 
            // btn_ccancelarDesbloqueio
            // 
            this.btn_ccancelarDesbloqueio.BackColor = System.Drawing.Color.Blue;
            this.btn_ccancelarDesbloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ccancelarDesbloqueio.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ccancelarDesbloqueio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ccancelarDesbloqueio.Location = new System.Drawing.Point(268, 346);
            this.btn_ccancelarDesbloqueio.Name = "btn_ccancelarDesbloqueio";
            this.btn_ccancelarDesbloqueio.Size = new System.Drawing.Size(172, 54);
            this.btn_ccancelarDesbloqueio.TabIndex = 43;
            this.btn_ccancelarDesbloqueio.Text = "Cancelar";
            this.btn_ccancelarDesbloqueio.UseVisualStyleBackColor = false;
            this.btn_ccancelarDesbloqueio.Click += new System.EventHandler(this.btn_ccancelarDesbloqueio_Click);
            // 
            // btn_salvarDesbloqueio
            // 
            this.btn_salvarDesbloqueio.BackColor = System.Drawing.Color.Blue;
            this.btn_salvarDesbloqueio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarDesbloqueio.ForeColor = System.Drawing.Color.Yellow;
            this.btn_salvarDesbloqueio.Location = new System.Drawing.Point(79, 346);
            this.btn_salvarDesbloqueio.Name = "btn_salvarDesbloqueio";
            this.btn_salvarDesbloqueio.Size = new System.Drawing.Size(172, 54);
            this.btn_salvarDesbloqueio.TabIndex = 18;
            this.btn_salvarDesbloqueio.Text = " Salvar";
            this.btn_salvarDesbloqueio.UseVisualStyleBackColor = false;
            this.btn_salvarDesbloqueio.Click += new System.EventHandler(this.btn_salvarDesbloqueio_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(355, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 0;
            // 
            // tabPage_abertura
            // 
            this.tabPage_abertura.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage_abertura.Controls.Add(this.dgv_Lista_LogAbertura);
            this.tabPage_abertura.Controls.Add(this.label19);
            this.tabPage_abertura.Controls.Add(this.panel_Aberturas);
            this.tabPage_abertura.Location = new System.Drawing.Point(4, 32);
            this.tabPage_abertura.Name = "tabPage_abertura";
            this.tabPage_abertura.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_abertura.Size = new System.Drawing.Size(1067, 432);
            this.tabPage_abertura.TabIndex = 1;
            this.tabPage_abertura.Text = "Abertura de Compartimento";
            // 
            // dgv_Lista_LogAbertura
            // 
            this.dgv_Lista_LogAbertura.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista_LogAbertura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Lista_LogAbertura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Lista_LogAbertura.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Lista_LogAbertura.Location = new System.Drawing.Point(498, 58);
            this.dgv_Lista_LogAbertura.Name = "dgv_Lista_LogAbertura";
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Yellow;
            this.dgv_Lista_LogAbertura.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Lista_LogAbertura.Size = new System.Drawing.Size(566, 368);
            this.dgv_Lista_LogAbertura.TabIndex = 75;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(630, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(305, 31);
            this.label19.TabIndex = 71;
            this.label19.Text = "Historico de Aberturas";
            // 
            // panel_Aberturas
            // 
            this.panel_Aberturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Aberturas.Controls.Add(this.ckb_abrirTodos);
            this.panel_Aberturas.Controls.Add(this.label10);
            this.panel_Aberturas.Controls.Add(this.CancelarAbertura);
            this.panel_Aberturas.Controls.Add(this.label12);
            this.panel_Aberturas.Controls.Add(this.txt_MotivoAbertura);
            this.panel_Aberturas.Controls.Add(this.txt_NomeEbox_abertura);
            this.panel_Aberturas.Controls.Add(this.btn_ConfirmarAbertura);
            this.panel_Aberturas.Controls.Add(this.label14);
            this.panel_Aberturas.Controls.Add(this.txt_idEbox_abertura);
            this.panel_Aberturas.Location = new System.Drawing.Point(3, 24);
            this.panel_Aberturas.Name = "panel_Aberturas";
            this.panel_Aberturas.Size = new System.Drawing.Size(486, 402);
            this.panel_Aberturas.TabIndex = 68;
            // 
            // ckb_abrirTodos
            // 
            this.ckb_abrirTodos.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_abrirTodos.AutoSize = true;
            this.ckb_abrirTodos.BackColor = System.Drawing.Color.Blue;
            this.ckb_abrirTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_abrirTodos.ForeColor = System.Drawing.Color.White;
            this.ckb_abrirTodos.Location = new System.Drawing.Point(164, 94);
            this.ckb_abrirTodos.Name = "ckb_abrirTodos";
            this.ckb_abrirTodos.Size = new System.Drawing.Size(166, 41);
            this.ckb_abrirTodos.TabIndex = 69;
            this.ckb_abrirTodos.Text = "Abrir todos";
            this.ckb_abrirTodos.UseVisualStyleBackColor = false;
            this.ckb_abrirTodos.CheckedChanged += new System.EventHandler(this.ckb_abrirTodos_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 31);
            this.label10.TabIndex = 55;
            this.label10.Text = "Motivo:";
            // 
            // CancelarAbertura
            // 
            this.CancelarAbertura.BackColor = System.Drawing.Color.Blue;
            this.CancelarAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarAbertura.ForeColor = System.Drawing.Color.Yellow;
            this.CancelarAbertura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarAbertura.Location = new System.Drawing.Point(253, 314);
            this.CancelarAbertura.Name = "CancelarAbertura";
            this.CancelarAbertura.Size = new System.Drawing.Size(209, 54);
            this.CancelarAbertura.TabIndex = 43;
            this.CancelarAbertura.Text = "Cancelar";
            this.CancelarAbertura.UseVisualStyleBackColor = false;
            this.CancelarAbertura.Click += new System.EventHandler(this.CancelarAbertura_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Yellow;
            this.label12.Location = new System.Drawing.Point(12, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(455, 31);
            this.label12.TabIndex = 49;
            this.label12.Text = "Abertura de Compartimento E-box";
            // 
            // txt_MotivoAbertura
            // 
            this.txt_MotivoAbertura.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_MotivoAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MotivoAbertura.Location = new System.Drawing.Point(119, 210);
            this.txt_MotivoAbertura.MaxLength = 8;
            this.txt_MotivoAbertura.Multiline = true;
            this.txt_MotivoAbertura.Name = "txt_MotivoAbertura";
            this.txt_MotivoAbertura.Size = new System.Drawing.Size(348, 61);
            this.txt_MotivoAbertura.TabIndex = 46;
            // 
            // txt_NomeEbox_abertura
            // 
            this.txt_NomeEbox_abertura.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_NomeEbox_abertura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_NomeEbox_abertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeEbox_abertura.FormattingEnabled = true;
            this.txt_NomeEbox_abertura.Items.AddRange(new object[] {
            ""});
            this.txt_NomeEbox_abertura.Location = new System.Drawing.Point(175, 155);
            this.txt_NomeEbox_abertura.Name = "txt_NomeEbox_abertura";
            this.txt_NomeEbox_abertura.Size = new System.Drawing.Size(292, 39);
            this.txt_NomeEbox_abertura.TabIndex = 54;
            this.txt_NomeEbox_abertura.SelectedIndexChanged += new System.EventHandler(this.txt_NomeEbox_abertura_SelectedIndexChanged);
            this.txt_NomeEbox_abertura.Click += new System.EventHandler(this.txt_NomeEbox_abertura_Click);
            // 
            // btn_ConfirmarAbertura
            // 
            this.btn_ConfirmarAbertura.BackColor = System.Drawing.Color.Blue;
            this.btn_ConfirmarAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarAbertura.ForeColor = System.Drawing.Color.Yellow;
            this.btn_ConfirmarAbertura.Location = new System.Drawing.Point(18, 314);
            this.btn_ConfirmarAbertura.Name = "btn_ConfirmarAbertura";
            this.btn_ConfirmarAbertura.Size = new System.Drawing.Size(229, 54);
            this.btn_ConfirmarAbertura.TabIndex = 18;
            this.btn_ConfirmarAbertura.Text = "Confirmar";
            this.btn_ConfirmarAbertura.UseVisualStyleBackColor = false;
            this.btn_ConfirmarAbertura.Click += new System.EventHandler(this.btn_ConfirmarAbertura_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 31);
            this.label14.TabIndex = 45;
            this.label14.Text = "E-box:";
            // 
            // txt_idEbox_abertura
            // 
            this.txt_idEbox_abertura.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_idEbox_abertura.Enabled = false;
            this.txt_idEbox_abertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idEbox_abertura.Location = new System.Drawing.Point(118, 155);
            this.txt_idEbox_abertura.Name = "txt_idEbox_abertura";
            this.txt_idEbox_abertura.Size = new System.Drawing.Size(51, 38);
            this.txt_idEbox_abertura.TabIndex = 31;
            // 
            // tabPage_conexao
            // 
            this.tabPage_conexao.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage_conexao.Controls.Add(this.dgv_ListaErrosConexao);
            this.tabPage_conexao.Controls.Add(this.label27);
            this.tabPage_conexao.Controls.Add(this.panel_configConexao);
            this.tabPage_conexao.Location = new System.Drawing.Point(4, 32);
            this.tabPage_conexao.Name = "tabPage_conexao";
            this.tabPage_conexao.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_conexao.Size = new System.Drawing.Size(1067, 432);
            this.tabPage_conexao.TabIndex = 2;
            this.tabPage_conexao.Text = "Conexao do Sistema";
            // 
            // dgv_ListaErrosConexao
            // 
            this.dgv_ListaErrosConexao.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaErrosConexao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_ListaErrosConexao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaErrosConexao.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_ListaErrosConexao.Location = new System.Drawing.Point(469, 69);
            this.dgv_ListaErrosConexao.Name = "dgv_ListaErrosConexao";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Yellow;
            this.dgv_ListaErrosConexao.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_ListaErrosConexao.Size = new System.Drawing.Size(588, 346);
            this.dgv_ListaErrosConexao.TabIndex = 77;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(601, 22);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(344, 31);
            this.label27.TabIndex = 76;
            this.label27.Text = "Lista de Ebox disponiveis";
            // 
            // panel_configConexao
            // 
            this.panel_configConexao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_configConexao.Controls.Add(this.txt_estadoPorta);
            this.panel_configConexao.Controls.Add(this.label2);
            this.panel_configConexao.Controls.Add(this.btn_desconectar);
            this.panel_configConexao.Controls.Add(this.txt_ListPort);
            this.panel_configConexao.Controls.Add(this.btn_conectar);
            this.panel_configConexao.Controls.Add(this.label3);
            this.panel_configConexao.Controls.Add(this.label8);
            this.panel_configConexao.Location = new System.Drawing.Point(8, 6);
            this.panel_configConexao.Name = "panel_configConexao";
            this.panel_configConexao.Size = new System.Drawing.Size(452, 409);
            this.panel_configConexao.TabIndex = 71;
            // 
            // txt_estadoPorta
            // 
            this.txt_estadoPorta.AutoSize = true;
            this.txt_estadoPorta.BackColor = System.Drawing.Color.Transparent;
            this.txt_estadoPorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estadoPorta.ForeColor = System.Drawing.Color.Yellow;
            this.txt_estadoPorta.Location = new System.Drawing.Point(164, 172);
            this.txt_estadoPorta.Name = "txt_estadoPorta";
            this.txt_estadoPorta.Size = new System.Drawing.Size(210, 31);
            this.txt_estadoPorta.TabIndex = 57;
            this.txt_estadoPorta.Text = "Não conectado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 55;
            this.label2.Text = "Status:";
            // 
            // btn_desconectar
            // 
            this.btn_desconectar.BackColor = System.Drawing.Color.Blue;
            this.btn_desconectar.Enabled = false;
            this.btn_desconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desconectar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_desconectar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_desconectar.Location = new System.Drawing.Point(224, 305);
            this.btn_desconectar.Name = "btn_desconectar";
            this.btn_desconectar.Size = new System.Drawing.Size(200, 54);
            this.btn_desconectar.TabIndex = 43;
            this.btn_desconectar.Text = "Desconectar";
            this.btn_desconectar.UseVisualStyleBackColor = false;
            this.btn_desconectar.Click += new System.EventHandler(this.btn_desconectar_Click);
            // 
            // txt_ListPort
            // 
            this.txt_ListPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_ListPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_ListPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ListPort.FormattingEnabled = true;
            this.txt_ListPort.Items.AddRange(new object[] {
            ""});
            this.txt_ListPort.Location = new System.Drawing.Point(171, 104);
            this.txt_ListPort.Name = "txt_ListPort";
            this.txt_ListPort.Size = new System.Drawing.Size(182, 39);
            this.txt_ListPort.TabIndex = 54;
            // 
            // btn_conectar
            // 
            this.btn_conectar.BackColor = System.Drawing.Color.Blue;
            this.btn_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_conectar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_conectar.Location = new System.Drawing.Point(18, 305);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(200, 54);
            this.btn_conectar.TabIndex = 18;
            this.btn_conectar.Text = "Conectar";
            this.btn_conectar.UseVisualStyleBackColor = false;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 31);
            this.label3.TabIndex = 49;
            this.label3.Text = "Configurar Comunicação Serial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 31);
            this.label8.TabIndex = 45;
            this.label8.Text = "Porta:";
            // 
            // frm_manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1084, 684);
            this.ControlBox = false;
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.ckb_abrirEbox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ckb_conectar);
            this.Controls.Add(this.ckb_bloquearEbox);
            this.Controls.Add(this.ckb_liberar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_fechar);
            this.Name = "frm_manutencao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_manutencao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.tabPage_bloqueio.ResumeLayout(false);
            this.tabPage_bloqueio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaBloqueio)).EndInit();
            this.painel_bloqeio.ResumeLayout(false);
            this.painel_bloqeio.PerformLayout();
            this.tabPage_desbloqueio.ResumeLayout(false);
            this.tabPage_desbloqueio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaDesbloqueio)).EndInit();
            this.painel_Desbloqueio.ResumeLayout(false);
            this.painel_Desbloqueio.PerformLayout();
            this.tabPage_abertura.ResumeLayout(false);
            this.tabPage_abertura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista_LogAbertura)).EndInit();
            this.panel_Aberturas.ResumeLayout(false);
            this.panel_Aberturas.PerformLayout();
            this.tabPage_conexao.ResumeLayout(false);
            this.tabPage_conexao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaErrosConexao)).EndInit();
            this.panel_configConexao.ResumeLayout(false);
            this.panel_configConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ckb_liberar;
        private System.Windows.Forms.CheckBox ckb_bloquearEbox;
        private System.Windows.Forms.CheckBox ckb_abrirEbox;
        private System.Windows.Forms.CheckBox ckb_conectar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_usuario_Logado;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_statusPort;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox txt_listaPorta;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage_bloqueio;
        private System.Windows.Forms.Panel painel_bloqeio;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btn_cancelarBloqueio;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.ComboBox txt_nomeEbox;
        private System.Windows.Forms.Button btn_salvarBloqeio;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_idEbox;
        private System.Windows.Forms.MaskedTextBox txt_dataOcorrencia;
        private System.Windows.Forms.TabPage tabPage_abertura;
        private System.Windows.Forms.Panel panel_Aberturas;
        private System.Windows.Forms.CheckBox ckb_abrirTodos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CancelarAbertura;
        private System.Windows.Forms.TextBox txt_MotivoAbertura;
        private System.Windows.Forms.ComboBox txt_NomeEbox_abertura;
        private System.Windows.Forms.Button btn_ConfirmarAbertura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_idEbox_abertura;
        private System.Windows.Forms.TabPage tabPage_conexao;
        private System.Windows.Forms.Panel panel_configConexao;
        private System.Windows.Forms.Label txt_estadoPorta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_desconectar;
        private System.Windows.Forms.ComboBox txt_ListPort;
        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage_desbloqueio;
        private System.Windows.Forms.Panel painel_Desbloqueio;
        private System.Windows.Forms.MaskedTextBox txt_dataDesbloqueio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_idEbox_desbloqueio;
        private System.Windows.Forms.TextBox txt_coment;
        private System.Windows.Forms.TextBox txt_responsavel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox txt_empresa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_ccancelarDesbloqueio;
        private System.Windows.Forms.Button btn_salvarDesbloqueio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgv_ListaBloqueio;
        private System.Windows.Forms.DataGridView dgv_ListaDesbloqueio;
        private System.Windows.Forms.DataGridView dgv_Lista_LogAbertura;
        private System.Windows.Forms.DataGridView dgv_ListaErrosConexao;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox txt_nomeEbox_desbloqueio;
    }
}