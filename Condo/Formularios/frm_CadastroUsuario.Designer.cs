namespace Condo
{
    partial class frm_CadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_msg_port = new System.Windows.Forms.TextBox();
            this.dgv_ListaUsuarios = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_cadBiometria = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txt_iduser = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picture_biometria = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_id_Biometria = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_apto_empresa = new System.Windows.Forms.ComboBox();
            this.txt_bloco_funcao = new System.Windows.Forms.ComboBox();
            this.lb_bloco_funcao = new System.Windows.Forms.Label();
            this.lb_apto_empresa = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_readSerial = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_usuario_Logado = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ckb_entregador = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckb_morador = new System.Windows.Forms.CheckBox();
            this.ckb_admin = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_biometria)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(587, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 92;
            this.label1.Text = "Nome:";
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.Location = new System.Drawing.Point(688, 166);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(244, 38);
            this.txt_pesquisa.TabIndex = 92;
            this.txt_pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pesquisa_KeyUp);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.Color.Blue;
            this.btn_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pesquisar.Location = new System.Drawing.Point(939, 166);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(122, 37);
            this.btn_pesquisar.TabIndex = 95;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // txt_msg_port
            // 
            this.txt_msg_port.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_msg_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_msg_port.ForeColor = System.Drawing.Color.Yellow;
            this.txt_msg_port.Location = new System.Drawing.Point(567, 215);
            this.txt_msg_port.Multiline = true;
            this.txt_msg_port.Name = "txt_msg_port";
            this.txt_msg_port.Size = new System.Drawing.Size(524, 430);
            this.txt_msg_port.TabIndex = 94;
            this.txt_msg_port.Visible = false;
            this.txt_msg_port.TextChanged += new System.EventHandler(this.txt_msg_port_TextChanged);
            // 
            // dgv_ListaUsuarios
            // 
            this.dgv_ListaUsuarios.BackgroundColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ListaUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ListaUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ListaUsuarios.Location = new System.Drawing.Point(567, 215);
            this.dgv_ListaUsuarios.Name = "dgv_ListaUsuarios";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Yellow;
            this.dgv_ListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ListaUsuarios.Size = new System.Drawing.Size(524, 430);
            this.dgv_ListaUsuarios.TabIndex = 93;
            this.dgv_ListaUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListaUsuarios_CellContentClick);
            this.dgv_ListaUsuarios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_ListaUsuarios_CellMouseDoubleClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Blue;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(189, 341);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(168, 54);
            this.btn_cancelar.TabIndex = 43;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_cadBiometria
            // 
            this.btn_cadBiometria.BackColor = System.Drawing.Color.Blue;
            this.btn_cadBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadBiometria.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cadBiometria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadBiometria.Location = new System.Drawing.Point(390, 196);
            this.btn_cadBiometria.Name = "btn_cadBiometria";
            this.btn_cadBiometria.Size = new System.Drawing.Size(158, 58);
            this.btn_cadBiometria.TabIndex = 38;
            this.btn_cadBiometria.Text = "Cadastrar Biometria";
            this.btn_cadBiometria.UseVisualStyleBackColor = false;
            this.btn_cadBiometria.Click += new System.EventHandler(this.btn_cadBiometria_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Blue;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_salvar.Location = new System.Drawing.Point(15, 341);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(168, 54);
            this.btn_salvar.TabIndex = 18;
            this.btn_salvar.Text = " Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txt_iduser
            // 
            this.txt_iduser.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_iduser.Enabled = false;
            this.txt_iduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iduser.Location = new System.Drawing.Point(111, 10);
            this.txt_iduser.Name = "txt_iduser";
            this.txt_iduser.Size = new System.Drawing.Size(50, 38);
            this.txt_iduser.TabIndex = 31;
            // 
            // txt_nome
            // 
            this.txt_nome.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(167, 10);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(217, 38);
            this.txt_nome.TabIndex = 5;
            this.txt_nome.Click += new System.EventHandler(this.txt_nomeMorador_Click);
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(179, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 93);
            this.panel2.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(133, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(452, 37);
            this.label7.TabIndex = 53;
            this.label7.Text = "CADASTRO  DE USUÁRIOS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 31);
            this.label9.TabIndex = 45;
            this.label9.Text = "Nome:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.picture_biometria);
            this.panel4.Controls.Add(this.btn_update);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.btn_cancelar);
            this.panel4.Controls.Add(this.txt_id_Biometria);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.btn_cadBiometria);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.txt_senha);
            this.panel4.Controls.Add(this.txt_apto_empresa);
            this.panel4.Controls.Add(this.btn_salvar);
            this.panel4.Controls.Add(this.txt_bloco_funcao);
            this.panel4.Controls.Add(this.lb_bloco_funcao);
            this.panel4.Controls.Add(this.lb_apto_empresa);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txt_iduser);
            this.panel4.Controls.Add(this.txt_nome);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(6, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 430);
            this.panel4.TabIndex = 49;
            // 
            // picture_biometria
            // 
            this.picture_biometria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picture_biometria.Image = global::Condo.Properties.Resources.semdigital;
            this.picture_biometria.Location = new System.Drawing.Point(390, 8);
            this.picture_biometria.Name = "picture_biometria";
            this.picture_biometria.Size = new System.Drawing.Size(158, 182);
            this.picture_biometria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_biometria.TabIndex = 93;
            this.picture_biometria.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Blue;
            this.btn_update.Enabled = false;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Yellow;
            this.btn_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_update.Location = new System.Drawing.Point(363, 341);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(168, 54);
            this.btn_update.TabIndex = 92;
            this.btn_update.Text = "Atualizar";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Yellow;
            this.label18.Location = new System.Drawing.Point(106, 178);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 16);
            this.label18.TabIndex = 89;
            this.label18.Text = "8 dig.";
            // 
            // txt_id_Biometria
            // 
            this.txt_id_Biometria.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_id_Biometria.Enabled = false;
            this.txt_id_Biometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_Biometria.Location = new System.Drawing.Point(202, 214);
            this.txt_id_Biometria.Name = "txt_id_Biometria";
            this.txt_id_Biometria.Size = new System.Drawing.Size(183, 38);
            this.txt_id_Biometria.TabIndex = 91;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(6, 217);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(146, 31);
            this.label17.TabIndex = 90;
            this.label17.Text = "Biometria:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(6, 166);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 31);
            this.label15.TabIndex = 55;
            this.label15.Text = "Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(201, 163);
            this.txt_senha.MaxLength = 8;
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(183, 38);
            this.txt_senha.TabIndex = 46;
            // 
            // txt_apto_empresa
            // 
            this.txt_apto_empresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_apto_empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_apto_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apto_empresa.FormattingEnabled = true;
            this.txt_apto_empresa.Items.AddRange(new object[] {
            ""});
            this.txt_apto_empresa.Location = new System.Drawing.Point(201, 111);
            this.txt_apto_empresa.Name = "txt_apto_empresa";
            this.txt_apto_empresa.Size = new System.Drawing.Size(183, 39);
            this.txt_apto_empresa.TabIndex = 54;
            this.txt_apto_empresa.SelectedIndexChanged += new System.EventHandler(this.txt_apto_empresa_SelectedIndexChanged);
            // 
            // txt_bloco_funcao
            // 
            this.txt_bloco_funcao.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_bloco_funcao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_bloco_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bloco_funcao.FormattingEnabled = true;
            this.txt_bloco_funcao.Location = new System.Drawing.Point(201, 60);
            this.txt_bloco_funcao.Name = "txt_bloco_funcao";
            this.txt_bloco_funcao.Size = new System.Drawing.Size(183, 39);
            this.txt_bloco_funcao.TabIndex = 46;
            // 
            // lb_bloco_funcao
            // 
            this.lb_bloco_funcao.AutoSize = true;
            this.lb_bloco_funcao.BackColor = System.Drawing.Color.Transparent;
            this.lb_bloco_funcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bloco_funcao.ForeColor = System.Drawing.Color.White;
            this.lb_bloco_funcao.Location = new System.Drawing.Point(6, 63);
            this.lb_bloco_funcao.Name = "lb_bloco_funcao";
            this.lb_bloco_funcao.Size = new System.Drawing.Size(96, 31);
            this.lb_bloco_funcao.TabIndex = 53;
            this.lb_bloco_funcao.Text = "Bloco:";
            // 
            // lb_apto_empresa
            // 
            this.lb_apto_empresa.AutoSize = true;
            this.lb_apto_empresa.BackColor = System.Drawing.Color.Transparent;
            this.lb_apto_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_apto_empresa.ForeColor = System.Drawing.Color.White;
            this.lb_apto_empresa.Location = new System.Drawing.Point(3, 114);
            this.lb_apto_empresa.Name = "lb_apto_empresa";
            this.lb_apto_empresa.Size = new System.Drawing.Size(189, 31);
            this.lb_apto_empresa.TabIndex = 52;
            this.lb_apto_empresa.Text = "Apartamento:";
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
            this.panel1.Location = new System.Drawing.Point(2, 651);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 40);
            this.panel1.TabIndex = 91;
            // 
            // txt_readSerial
            // 
            this.txt_readSerial.Location = new System.Drawing.Point(221, 6);
            this.txt_readSerial.Name = "txt_readSerial";
            this.txt_readSerial.Size = new System.Drawing.Size(100, 20);
            this.txt_readSerial.TabIndex = 93;
            this.txt_readSerial.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 92;
            this.comboBox1.Visible = false;
            // 
            // txt_usuario_Logado
            // 
            this.txt_usuario_Logado.AutoSize = true;
            this.txt_usuario_Logado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_Logado.ForeColor = System.Drawing.Color.Yellow;
            this.txt_usuario_Logado.Location = new System.Drawing.Point(603, 8);
            this.txt_usuario_Logado.Name = "txt_usuario_Logado";
            this.txt_usuario_Logado.Size = new System.Drawing.Size(58, 20);
            this.txt_usuario_Logado.TabIndex = 53;
            this.txt_usuario_Logado.Text = "01 xxx";
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Yellow;
            this.txt_data.Location = new System.Drawing.Point(3, 7);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(56, 20);
            this.txt_data.TabIndex = 51;
            this.txt_data.Text = "DATA";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Yellow;
            this.label21.Location = new System.Drawing.Point(525, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 20);
            this.label21.TabIndex = 52;
            this.label21.Text = "Usuario:";
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Yellow;
            this.txt_statusPort.Location = new System.Drawing.Point(908, 8);
            this.txt_statusPort.Name = "txt_statusPort";
            this.txt_statusPort.Size = new System.Drawing.Size(171, 20);
            this.txt_statusPort.TabIndex = 49;
            this.txt_statusPort.Text = "Não Conectado  ****";
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
            // ckb_entregador
            // 
            this.ckb_entregador.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_entregador.AutoSize = true;
            this.ckb_entregador.BackColor = System.Drawing.Color.Blue;
            this.ckb_entregador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_entregador.ForeColor = System.Drawing.Color.White;
            this.ckb_entregador.Location = new System.Drawing.Point(159, 170);
            this.ckb_entregador.Name = "ckb_entregador";
            this.ckb_entregador.Size = new System.Drawing.Size(168, 41);
            this.ckb_entregador.TabIndex = 94;
            this.ckb_entregador.Text = "Entregador";
            this.ckb_entregador.UseVisualStyleBackColor = false;
            this.ckb_entregador.CheckedChanged += new System.EventHandler(this.ckb_entregador_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(81, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(391, 31);
            this.label10.TabIndex = 92;
            this.label10.Text = "Selecione o perfil  do usuario";
            // 
            // ckb_morador
            // 
            this.ckb_morador.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_morador.AutoSize = true;
            this.ckb_morador.BackColor = System.Drawing.Color.Blue;
            this.ckb_morador.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_morador.ForeColor = System.Drawing.Color.White;
            this.ckb_morador.Location = new System.Drawing.Point(26, 170);
            this.ckb_morador.Name = "ckb_morador";
            this.ckb_morador.Size = new System.Drawing.Size(131, 41);
            this.ckb_morador.TabIndex = 93;
            this.ckb_morador.Text = "Morador";
            this.ckb_morador.UseVisualStyleBackColor = false;
            this.ckb_morador.CheckedChanged += new System.EventHandler(this.ckb_morador_CheckedChanged);
            // 
            // ckb_admin
            // 
            this.ckb_admin.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckb_admin.AutoSize = true;
            this.ckb_admin.BackColor = System.Drawing.Color.Blue;
            this.ckb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_admin.ForeColor = System.Drawing.Color.White;
            this.ckb_admin.Location = new System.Drawing.Point(328, 170);
            this.ckb_admin.Name = "ckb_admin";
            this.ckb_admin.Size = new System.Drawing.Size(204, 41);
            this.ckb_admin.TabIndex = 95;
            this.ckb_admin.Text = "Administrador";
            this.ckb_admin.UseVisualStyleBackColor = false;
            this.ckb_admin.CheckedChanged += new System.EventHandler(this.ckb_admin_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(605, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 31);
            this.label4.TabIndex = 104;
            this.label4.Text = "Lista de moradores cadastrados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Blue;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_voltar.Image = ((System.Drawing.Image)(resources.GetObject("btn_voltar.Image")));
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(929, -1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(162, 94);
            this.btn_voltar.TabIndex = 45;
            this.btn_voltar.Text = "Fechar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frm_CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1094, 694);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_ListaUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pesquisa);
            this.Controls.Add(this.txt_msg_port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.ckb_admin);
            this.Controls.Add(this.ckb_entregador);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ckb_morador);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_CadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCadastro_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_biometria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadBiometria;
        private System.Windows.Forms.TextBox txt_iduser;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.ComboBox txt_apto_empresa;
        private System.Windows.Forms.ComboBox txt_bloco_funcao;
        private System.Windows.Forms.Label lb_bloco_funcao;
        private System.Windows.Forms.Label lb_apto_empresa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_id_Biometria;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txt_usuario_Logado;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.TextBox txt_readSerial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox ckb_entregador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckb_morador;
        private System.Windows.Forms.CheckBox ckb_admin;
        private System.Windows.Forms.TextBox txt_msg_port;
        private System.Windows.Forms.DataGridView dgv_ListaUsuarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.PictureBox picture_biometria;
    }
}