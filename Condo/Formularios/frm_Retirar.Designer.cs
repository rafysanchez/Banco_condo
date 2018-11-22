namespace Condo.Formularios
{
    partial class frm_Retirar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Retirar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_RetirarEncomneda = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_apartamento = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bloco = new System.Windows.Forms.ComboBox();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_ListaEncomendas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_cancelarLogin = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.picture_biometria = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txt_info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_compartimento = new System.Windows.Forms.Label();
            this.lb_ebox = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_apto = new System.Windows.Forms.Label();
            this.lb_bloco = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_morador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lb_encomenda = new System.Windows.Forms.Label();
            this.painel_Porta = new System.Windows.Forms.Panel();
            this.txt_portaEbox = new System.Windows.Forms.Label();
            this.btn_Cancelarretirada = new System.Windows.Forms.Button();
            this.btn_confirmarRetirada = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.btn_retirarNovaEncomenda = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_readSerial = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_data = new System.Windows.Forms.Label();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaEncomendas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_biometria)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.painel_Porta.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(188, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 95);
            this.panel2.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(96, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(491, 37);
            this.label7.TabIndex = 53;
            this.label7.Text = "RETIRADA DE ENCOMENDAS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Blue;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(915, 2);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(166, 95);
            this.btn_voltar.TabIndex = 92;
            this.btn_voltar.Text = "Fechar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1077, 532);
            this.tabControl1.TabIndex = 95;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage1.Controls.Add(this.btn_cancelar);
            this.tabPage1.Controls.Add(this.btn_RetirarEncomneda);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgv_ListaEncomendas);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1069, 496);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Verifica encomendas";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Blue;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cancelar.Location = new System.Drawing.Point(652, 413);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(314, 66);
            this.btn_cancelar.TabIndex = 107;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_RetirarEncomneda
            // 
            this.btn_RetirarEncomneda.BackColor = System.Drawing.Color.Blue;
            this.btn_RetirarEncomneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RetirarEncomneda.ForeColor = System.Drawing.Color.Yellow;
            this.btn_RetirarEncomneda.Location = new System.Drawing.Point(652, 341);
            this.btn_RetirarEncomneda.Name = "btn_RetirarEncomneda";
            this.btn_RetirarEncomneda.Size = new System.Drawing.Size(314, 66);
            this.btn_RetirarEncomneda.TabIndex = 106;
            this.btn_RetirarEncomneda.Text = "Retirar encomenda";
            this.btn_RetirarEncomneda.UseVisualStyleBackColor = false;
            this.btn_RetirarEncomneda.Click += new System.EventHandler(this.btn_RetirarEncomneda_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txt_apartamento);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txt_bloco);
            this.panel4.Controls.Add(this.btn_verificar);
            this.panel4.Location = new System.Drawing.Point(0, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(486, 471);
            this.panel4.TabIndex = 105;
            // 
            // txt_apartamento
            // 
            this.txt_apartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_apartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_apartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apartamento.FormattingEnabled = true;
            this.txt_apartamento.Location = new System.Drawing.Point(248, 29);
            this.txt_apartamento.Name = "txt_apartamento";
            this.txt_apartamento.Size = new System.Drawing.Size(227, 47);
            this.txt_apartamento.TabIndex = 93;
            this.txt_apartamento.Click += new System.EventHandler(this.txt_apartamento_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 39);
            this.label2.TabIndex = 95;
            this.label2.Text = "Apartamento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 39);
            this.label1.TabIndex = 94;
            this.label1.Text = "Bloco:";
            // 
            // txt_bloco
            // 
            this.txt_bloco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_bloco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bloco.FormattingEnabled = true;
            this.txt_bloco.Location = new System.Drawing.Point(248, 96);
            this.txt_bloco.Name = "txt_bloco";
            this.txt_bloco.Size = new System.Drawing.Size(227, 47);
            this.txt_bloco.TabIndex = 96;
            this.txt_bloco.Click += new System.EventHandler(this.txt_bloco_Click);
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.Color.Blue;
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_verificar.Location = new System.Drawing.Point(34, 176);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(405, 91);
            this.btn_verificar.TabIndex = 97;
            this.btn_verificar.Text = "Verificar encomenda";
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(565, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(444, 31);
            this.label4.TabIndex = 103;
            this.label4.Text = "Lista de encomendas disponíveis";
            // 
            // dgv_ListaEncomendas
            // 
            this.dgv_ListaEncomendas.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaEncomendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ListaEncomendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaEncomendas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ListaEncomendas.Location = new System.Drawing.Point(501, 81);
            this.dgv_ListaEncomendas.Name = "dgv_ListaEncomendas";
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Yellow;
            this.dgv_ListaEncomendas.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ListaEncomendas.Size = new System.Drawing.Size(562, 234);
            this.dgv_ListaEncomendas.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage2.Controls.Add(this.btn_cancelarLogin);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.txt_user);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_senha);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.btn_Confirmar);
            this.tabPage2.Controls.Add(this.picture_biometria);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1069, 496);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autenticação usuário";
            // 
            // btn_cancelarLogin
            // 
            this.btn_cancelarLogin.BackColor = System.Drawing.Color.Blue;
            this.btn_cancelarLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarLogin.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cancelarLogin.Location = new System.Drawing.Point(528, 421);
            this.btn_cancelarLogin.Name = "btn_cancelarLogin";
            this.btn_cancelarLogin.Size = new System.Drawing.Size(221, 54);
            this.btn_cancelarLogin.TabIndex = 123;
            this.btn_cancelarLogin.Text = "Cancelar";
            this.btn_cancelarLogin.UseVisualStyleBackColor = false;
            this.btn_cancelarLogin.Click += new System.EventHandler(this.btn_cancelarLogin_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(328, 367);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(124, 31);
            this.label23.TabIndex = 122;
            this.label23.Text = "Usuario:";
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Yellow;
            this.txt_user.Location = new System.Drawing.Point(458, 367);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(134, 31);
            this.txt_user.TabIndex = 121;
            this.txt_user.Text = "**********";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(404, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(248, 31);
            this.label9.TabIndex = 120;
            this.label9.Text = "Diigite sua senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(410, 316);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(234, 38);
            this.txt_senha.TabIndex = 119;
            this.txt_senha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_senha_KeyUp_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(366, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(304, 24);
            this.label10.TabIndex = 117;
            this.label10.Text = "Pressione o dedo no sensor ou";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(354, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 31);
            this.label6.TabIndex = 112;
            this.label6.Text = "Identificação do usuário";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.Blue;
            this.btn_Confirmar.Enabled = false;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Confirmar.Location = new System.Drawing.Point(301, 421);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(221, 54);
            this.btn_Confirmar.TabIndex = 113;
            this.btn_Confirmar.Text = "Continuar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // picture_biometria
            // 
            this.picture_biometria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_biometria.Image = global::Condo.Properties.Resources.pressione;
            this.picture_biometria.Location = new System.Drawing.Point(432, 93);
            this.picture_biometria.Name = "picture_biometria";
            this.picture_biometria.Size = new System.Drawing.Size(182, 186);
            this.picture_biometria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_biometria.TabIndex = 114;
            this.picture_biometria.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage3.Controls.Add(this.txt_info);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.painel_Porta);
            this.tabPage3.Controls.Add(this.btn_Cancelarretirada);
            this.tabPage3.Controls.Add(this.btn_confirmarRetirada);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1069, 496);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Confirmação retirada";
            // 
            // txt_info
            // 
            this.txt_info.AutoSize = true;
            this.txt_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_info.ForeColor = System.Drawing.Color.White;
            this.txt_info.Location = new System.Drawing.Point(218, 252);
            this.txt_info.Name = "txt_info";
            this.txt_info.Size = new System.Drawing.Size(700, 39);
            this.txt_info.TabIndex = 130;
            this.txt_info.Text = "Para abrir pressione abrir compartimento.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_compartimento);
            this.panel1.Controls.Add(this.lb_ebox);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.lb_apto);
            this.panel1.Controls.Add(this.lb_bloco);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lb_morador);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.lb_encomenda);
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 189);
            this.panel1.TabIndex = 123;
            // 
            // lb_compartimento
            // 
            this.lb_compartimento.AutoSize = true;
            this.lb_compartimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_compartimento.ForeColor = System.Drawing.Color.Yellow;
            this.lb_compartimento.Location = new System.Drawing.Point(239, 79);
            this.lb_compartimento.Name = "lb_compartimento";
            this.lb_compartimento.Size = new System.Drawing.Size(62, 31);
            this.lb_compartimento.TabIndex = 129;
            this.lb_compartimento.Text = "****";
            // 
            // lb_ebox
            // 
            this.lb_ebox.AutoSize = true;
            this.lb_ebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ebox.ForeColor = System.Drawing.Color.Yellow;
            this.lb_ebox.Location = new System.Drawing.Point(403, 129);
            this.lb_ebox.Name = "lb_ebox";
            this.lb_ebox.Size = new System.Drawing.Size(98, 31);
            this.lb_ebox.TabIndex = 122;
            this.lb_ebox.Text = "xxxxxx";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Yellow;
            this.label20.Location = new System.Drawing.Point(12, 129);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(373, 31);
            this.label20.TabIndex = 120;
            this.label20.Text = "Número do compartimento :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(12, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(221, 31);
            this.label18.TabIndex = 128;
            this.label18.Text = "Compartimento:";
            // 
            // lb_apto
            // 
            this.lb_apto.AutoSize = true;
            this.lb_apto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apto.ForeColor = System.Drawing.Color.Yellow;
            this.lb_apto.Location = new System.Drawing.Point(937, 17);
            this.lb_apto.Name = "lb_apto";
            this.lb_apto.Size = new System.Drawing.Size(62, 31);
            this.lb_apto.TabIndex = 127;
            this.lb_apto.Text = "****";
            // 
            // lb_bloco
            // 
            this.lb_bloco.AutoSize = true;
            this.lb_bloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bloco.ForeColor = System.Drawing.Color.Yellow;
            this.lb_bloco.Location = new System.Drawing.Point(637, 17);
            this.lb_bloco.Name = "lb_bloco";
            this.lb_bloco.Size = new System.Drawing.Size(62, 31);
            this.lb_bloco.TabIndex = 126;
            this.lb_bloco.Text = "****";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(823, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 31);
            this.label13.TabIndex = 125;
            this.label13.Text = "Apto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(503, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 31);
            this.label12.TabIndex = 124;
            this.label12.Text = "Bloco:";
            // 
            // lb_morador
            // 
            this.lb_morador.AutoSize = true;
            this.lb_morador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_morador.ForeColor = System.Drawing.Color.Yellow;
            this.lb_morador.Location = new System.Drawing.Point(637, 70);
            this.lb_morador.Name = "lb_morador";
            this.lb_morador.Size = new System.Drawing.Size(230, 31);
            this.lb_morador.TabIndex = 123;
            this.lb_morador.Text = "******************";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(503, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 31);
            this.label3.TabIndex = 122;
            this.label3.Text = "Morador:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(12, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 31);
            this.label16.TabIndex = 121;
            this.label16.Text = "Encomenda:";
            // 
            // lb_encomenda
            // 
            this.lb_encomenda.AutoSize = true;
            this.lb_encomenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_encomenda.ForeColor = System.Drawing.Color.Yellow;
            this.lb_encomenda.Location = new System.Drawing.Point(239, 17);
            this.lb_encomenda.Name = "lb_encomenda";
            this.lb_encomenda.Size = new System.Drawing.Size(134, 31);
            this.lb_encomenda.TabIndex = 120;
            this.lb_encomenda.Text = "**********";
            // 
            // painel_Porta
            // 
            this.painel_Porta.BackColor = System.Drawing.Color.Blue;
            this.painel_Porta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel_Porta.Controls.Add(this.txt_portaEbox);
            this.painel_Porta.Location = new System.Drawing.Point(310, 309);
            this.painel_Porta.Name = "painel_Porta";
            this.painel_Porta.Size = new System.Drawing.Size(543, 85);
            this.painel_Porta.TabIndex = 111;
            // 
            // txt_portaEbox
            // 
            this.txt_portaEbox.AutoSize = true;
            this.txt_portaEbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_portaEbox.ForeColor = System.Drawing.Color.Yellow;
            this.txt_portaEbox.Location = new System.Drawing.Point(82, 16);
            this.txt_portaEbox.Name = "txt_portaEbox";
            this.txt_portaEbox.Size = new System.Drawing.Size(450, 55);
            this.txt_portaEbox.TabIndex = 105;
            this.txt_portaEbox.Text = "PORTA FECHADO";
            // 
            // btn_Cancelarretirada
            // 
            this.btn_Cancelarretirada.BackColor = System.Drawing.Color.Blue;
            this.btn_Cancelarretirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelarretirada.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Cancelarretirada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelarretirada.Location = new System.Drawing.Point(572, 418);
            this.btn_Cancelarretirada.Name = "btn_Cancelarretirada";
            this.btn_Cancelarretirada.Size = new System.Drawing.Size(307, 54);
            this.btn_Cancelarretirada.TabIndex = 106;
            this.btn_Cancelarretirada.Text = "Cancelar retirada";
            this.btn_Cancelarretirada.UseVisualStyleBackColor = false;
            this.btn_Cancelarretirada.Click += new System.EventHandler(this.btn_Cancelarretirada_Click);
            // 
            // btn_confirmarRetirada
            // 
            this.btn_confirmarRetirada.BackColor = System.Drawing.Color.Blue;
            this.btn_confirmarRetirada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmarRetirada.ForeColor = System.Drawing.Color.Yellow;
            this.btn_confirmarRetirada.Location = new System.Drawing.Point(256, 418);
            this.btn_confirmarRetirada.Name = "btn_confirmarRetirada";
            this.btn_confirmarRetirada.Size = new System.Drawing.Size(307, 54);
            this.btn_confirmarRetirada.TabIndex = 108;
            this.btn_confirmarRetirada.Text = "Abrir compartimento";
            this.btn_confirmarRetirada.UseVisualStyleBackColor = false;
            this.btn_confirmarRetirada.Click += new System.EventHandler(this.btn_confirmarRetirada_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkCyan;
            this.tabPage4.Controls.Add(this.btn_Finalizar);
            this.tabPage4.Controls.Add(this.btn_retirarNovaEncomenda);
            this.tabPage4.Location = new System.Drawing.Point(4, 32);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1069, 496);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Finalizar";
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.BackColor = System.Drawing.Color.Blue;
            this.btn_Finalizar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Finalizar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Finalizar.Location = new System.Drawing.Point(544, 158);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(393, 214);
            this.btn_Finalizar.TabIndex = 8;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = false;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // btn_retirarNovaEncomenda
            // 
            this.btn_retirarNovaEncomenda.BackColor = System.Drawing.Color.Blue;
            this.btn_retirarNovaEncomenda.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirarNovaEncomenda.ForeColor = System.Drawing.Color.Yellow;
            this.btn_retirarNovaEncomenda.Location = new System.Drawing.Point(114, 158);
            this.btn_retirarNovaEncomenda.Name = "btn_retirarNovaEncomenda";
            this.btn_retirarNovaEncomenda.Size = new System.Drawing.Size(393, 214);
            this.btn_retirarNovaEncomenda.TabIndex = 7;
            this.btn_retirarNovaEncomenda.Text = "Retirar nova encomenda";
            this.btn_retirarNovaEncomenda.UseVisualStyleBackColor = false;
            this.btn_retirarNovaEncomenda.Click += new System.EventHandler(this.btn_retirarNovaEncomenda_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txt_readSerial);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.txt_data);
            this.panel3.Controls.Add(this.txt_statusPort);
            this.panel3.Location = new System.Drawing.Point(4, 640);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1080, 40);
            this.panel3.TabIndex = 96;
            // 
            // txt_readSerial
            // 
            this.txt_readSerial.Location = new System.Drawing.Point(286, 7);
            this.txt_readSerial.Name = "txt_readSerial";
            this.txt_readSerial.Size = new System.Drawing.Size(251, 20);
            this.txt_readSerial.TabIndex = 114;
            this.txt_readSerial.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(77, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 114;
            this.comboBox1.Visible = false;
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Yellow;
            this.txt_data.Location = new System.Drawing.Point(3, 11);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(65, 24);
            this.txt_data.TabIndex = 51;
            this.txt_data.Text = "DATA";
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Yellow;
            this.txt_statusPort.Location = new System.Drawing.Point(880, 7);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(193, 24);
            this.txt_statusPort.TabIndex = 49;
            this.txt_statusPort.Text = "Não Conectado ****";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Retirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1084, 684);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltar);
            this.Name = "frm_Retirar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Retirar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaEncomendas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_biometria)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painel_Porta.ResumeLayout(false);
            this.painel_Porta.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_readSerial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox txt_apartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txt_bloco;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_ListaEncomendas;
        private System.Windows.Forms.Button btn_RetirarEncomneda;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cancelarLogin;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label txt_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.PictureBox picture_biometria;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel painel_Porta;
        private System.Windows.Forms.Label txt_portaEbox;
        private System.Windows.Forms.Button btn_Cancelarretirada;
        private System.Windows.Forms.Button btn_confirmarRetirada;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lb_ebox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_compartimento;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_apto;
        private System.Windows.Forms.Label lb_bloco;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_morador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lb_encomenda;
        private System.Windows.Forms.Label txt_info;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Button btn_retirarNovaEncomenda;

    }
}