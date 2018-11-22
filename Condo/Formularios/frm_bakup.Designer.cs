namespace Condo.Formularios
{
    partial class frm_bakup
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_salvarBackup = new System.Windows.Forms.Button();
            this.btn_alterarLocal = new System.Windows.Forms.Button();
            this.txt_horaRestore = new System.Windows.Forms.Panel();
            this.txt_dataRestore = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_resp_backup_anterior = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Restaurar = new System.Windows.Forms.Button();
            this.btn_buscarArquivo = new System.Windows.Forms.Button();
            this.txt_localRestore = new System.Windows.Forms.TextBox();
            this.painel_backup = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_alterarLocalInstalacao = new System.Windows.Forms.Button();
            this.txt_freq_backup = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_local_instalacaoMsql = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_local_backup = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_configBackup = new System.Windows.Forms.Button();
            this.btn_Config_restore = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_readSerial = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_usuario_Logado = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.txt_horaRestore.SuspendLayout();
            this.painel_backup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(174, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 93);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(107, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(550, 42);
            this.label2.TabIndex = 52;
            this.label2.Text = "BACKUP E RESTAURAUÇÃO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Condo.Properties.Resources.constec;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.Blue;
            this.btn_voltar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_voltar.Image = global::Condo.Properties.Resources.Voltar;
            this.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_voltar.Location = new System.Drawing.Point(943, 1);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(141, 94);
            this.btn_voltar.TabIndex = 19;
            this.btn_voltar.Text = "Fechar";
            this.btn_voltar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_salvarBackup
            // 
            this.btn_salvarBackup.BackColor = System.Drawing.Color.Blue;
            this.btn_salvarBackup.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvarBackup.ForeColor = System.Drawing.Color.Yellow;
            this.btn_salvarBackup.Location = new System.Drawing.Point(392, 308);
            this.btn_salvarBackup.Name = "btn_salvarBackup";
            this.btn_salvarBackup.Size = new System.Drawing.Size(241, 54);
            this.btn_salvarBackup.TabIndex = 86;
            this.btn_salvarBackup.Text = "Realizar backup";
            this.btn_salvarBackup.UseVisualStyleBackColor = false;
            this.btn_salvarBackup.Click += new System.EventHandler(this.btn_salvarBackup_Click);
            // 
            // btn_alterarLocal
            // 
            this.btn_alterarLocal.BackColor = System.Drawing.Color.Blue;
            this.btn_alterarLocal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarLocal.ForeColor = System.Drawing.Color.Yellow;
            this.btn_alterarLocal.Location = new System.Drawing.Point(557, 255);
            this.btn_alterarLocal.Name = "btn_alterarLocal";
            this.btn_alterarLocal.Size = new System.Drawing.Size(182, 39);
            this.btn_alterarLocal.TabIndex = 88;
            this.btn_alterarLocal.Text = "Alterar local";
            this.btn_alterarLocal.UseVisualStyleBackColor = false;
            this.btn_alterarLocal.Click += new System.EventHandler(this.btn_alterarLocal_Click);
            // 
            // txt_horaRestore
            // 
            this.txt_horaRestore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_horaRestore.Controls.Add(this.txt_hora);
            this.txt_horaRestore.Controls.Add(this.txt_dataRestore);
            this.txt_horaRestore.Controls.Add(this.label10);
            this.txt_horaRestore.Controls.Add(this.txt_resp_backup_anterior);
            this.txt_horaRestore.Controls.Add(this.label7);
            this.txt_horaRestore.Controls.Add(this.label1);
            this.txt_horaRestore.Controls.Add(this.label3);
            this.txt_horaRestore.Controls.Add(this.btn_Restaurar);
            this.txt_horaRestore.Controls.Add(this.btn_buscarArquivo);
            this.txt_horaRestore.Controls.Add(this.txt_localRestore);
            this.txt_horaRestore.Location = new System.Drawing.Point(138, 202);
            this.txt_horaRestore.Name = "txt_horaRestore";
            this.txt_horaRestore.Size = new System.Drawing.Size(826, 392);
            this.txt_horaRestore.TabIndex = 413;
            this.txt_horaRestore.Visible = false;
            // 
            // txt_dataRestore
            // 
            this.txt_dataRestore.BackColor = System.Drawing.Color.DarkCyan;
            this.txt_dataRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataRestore.ForeColor = System.Drawing.Color.Yellow;
            this.txt_dataRestore.Location = new System.Drawing.Point(204, 298);
            this.txt_dataRestore.Mask = "00/00/0000";
            this.txt_dataRestore.Name = "txt_dataRestore";
            this.txt_dataRestore.Size = new System.Drawing.Size(190, 38);
            this.txt_dataRestore.TabIndex = 421;
            this.txt_dataRestore.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(192, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 31);
            this.label10.TabIndex = 418;
            this.label10.Text = "Usuario:";
            // 
            // txt_resp_backup_anterior
            // 
            this.txt_resp_backup_anterior.AutoSize = true;
            this.txt_resp_backup_anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resp_backup_anterior.ForeColor = System.Drawing.Color.Yellow;
            this.txt_resp_backup_anterior.Location = new System.Drawing.Point(354, 344);
            this.txt_resp_backup_anterior.Name = "txt_resp_backup_anterior";
            this.txt_resp_backup_anterior.Size = new System.Drawing.Size(194, 31);
            this.txt_resp_backup_anterior.TabIndex = 417;
            this.txt_resp_backup_anterior.Text = "Administrador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(192, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 31);
            this.label7.TabIndex = 415;
            this.label7.Text = "Ultima restauração do sistema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 31);
            this.label1.TabIndex = 414;
            this.label1.Text = "Local do arquivo para backup:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(244, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 31);
            this.label3.TabIndex = 413;
            this.label3.Text = "Restauração do Sistema";
            // 
            // btn_Restaurar
            // 
            this.btn_Restaurar.BackColor = System.Drawing.Color.Blue;
            this.btn_Restaurar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restaurar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Restaurar.Location = new System.Drawing.Point(409, 161);
            this.btn_Restaurar.Name = "btn_Restaurar";
            this.btn_Restaurar.Size = new System.Drawing.Size(229, 54);
            this.btn_Restaurar.TabIndex = 86;
            this.btn_Restaurar.Text = "Restaurar";
            this.btn_Restaurar.UseVisualStyleBackColor = false;
            this.btn_Restaurar.Click += new System.EventHandler(this.btn_Restaurar_Click);
            // 
            // btn_buscarArquivo
            // 
            this.btn_buscarArquivo.BackColor = System.Drawing.Color.Blue;
            this.btn_buscarArquivo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarArquivo.ForeColor = System.Drawing.Color.Yellow;
            this.btn_buscarArquivo.Location = new System.Drawing.Point(159, 161);
            this.btn_buscarArquivo.Name = "btn_buscarArquivo";
            this.btn_buscarArquivo.Size = new System.Drawing.Size(229, 54);
            this.btn_buscarArquivo.TabIndex = 88;
            this.btn_buscarArquivo.Text = "Buscar arquivo";
            this.btn_buscarArquivo.UseVisualStyleBackColor = false;
            this.btn_buscarArquivo.Click += new System.EventHandler(this.btn_buscarArquivo_Click);
            // 
            // txt_localRestore
            // 
            this.txt_localRestore.Enabled = false;
            this.txt_localRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_localRestore.Location = new System.Drawing.Point(69, 113);
            this.txt_localRestore.Name = "txt_localRestore";
            this.txt_localRestore.Size = new System.Drawing.Size(673, 29);
            this.txt_localRestore.TabIndex = 410;
            this.txt_localRestore.Text = "D:";
            // 
            // painel_backup
            // 
            this.painel_backup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.painel_backup.Controls.Add(this.btn_salvar);
            this.painel_backup.Controls.Add(this.btn_alterarLocalInstalacao);
            this.painel_backup.Controls.Add(this.txt_freq_backup);
            this.painel_backup.Controls.Add(this.label6);
            this.painel_backup.Controls.Add(this.txt_local_instalacaoMsql);
            this.painel_backup.Controls.Add(this.label4);
            this.painel_backup.Controls.Add(this.label14);
            this.painel_backup.Controls.Add(this.label5);
            this.painel_backup.Controls.Add(this.btn_salvarBackup);
            this.painel_backup.Controls.Add(this.btn_alterarLocal);
            this.painel_backup.Controls.Add(this.txt_local_backup);
            this.painel_backup.Location = new System.Drawing.Point(178, 209);
            this.painel_backup.Name = "painel_backup";
            this.painel_backup.Size = new System.Drawing.Size(748, 370);
            this.painel_backup.TabIndex = 412;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Blue;
            this.btn_salvar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_salvar.Location = new System.Drawing.Point(107, 308);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(241, 54);
            this.btn_salvar.TabIndex = 421;
            this.btn_salvar.Text = "Salvar alteração";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_alterarLocalInstalacao
            // 
            this.btn_alterarLocalInstalacao.BackColor = System.Drawing.Color.Blue;
            this.btn_alterarLocalInstalacao.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterarLocalInstalacao.ForeColor = System.Drawing.Color.Yellow;
            this.btn_alterarLocalInstalacao.Location = new System.Drawing.Point(556, 96);
            this.btn_alterarLocalInstalacao.Name = "btn_alterarLocalInstalacao";
            this.btn_alterarLocalInstalacao.Size = new System.Drawing.Size(182, 39);
            this.btn_alterarLocalInstalacao.TabIndex = 420;
            this.btn_alterarLocalInstalacao.Text = "Alterar local";
            this.btn_alterarLocalInstalacao.UseVisualStyleBackColor = false;
            this.btn_alterarLocalInstalacao.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_freq_backup
            // 
            this.txt_freq_backup.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_freq_backup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_freq_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_freq_backup.FormattingEnabled = true;
            this.txt_freq_backup.Items.AddRange(new object[] {
            "Diariamente",
            "Semanalmente",
            "Mensalmente",
            "Manualmente"});
            this.txt_freq_backup.Location = new System.Drawing.Point(262, 161);
            this.txt_freq_backup.Name = "txt_freq_backup";
            this.txt_freq_backup.Size = new System.Drawing.Size(288, 39);
            this.txt_freq_backup.TabIndex = 418;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 31);
            this.label6.TabIndex = 417;
            this.label6.Text = "Realizar backup:";
            // 
            // txt_local_instalacaoMsql
            // 
            this.txt_local_instalacaoMsql.Enabled = false;
            this.txt_local_instalacaoMsql.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_local_instalacaoMsql.Location = new System.Drawing.Point(27, 101);
            this.txt_local_instalacaoMsql.Name = "txt_local_instalacaoMsql";
            this.txt_local_instalacaoMsql.Size = new System.Drawing.Size(523, 31);
            this.txt_local_instalacaoMsql.TabIndex = 416;
            this.txt_local_instalacaoMsql.Text = "D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 31);
            this.label4.TabIndex = 415;
            this.label4.Text = "Local instalação banco de dados:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(21, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(235, 31);
            this.label14.TabIndex = 414;
            this.label14.Text = "Local do backup:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(174, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 31);
            this.label5.TabIndex = 413;
            this.label5.Text = "Configurações de backup";
            // 
            // txt_local_backup
            // 
            this.txt_local_backup.Enabled = false;
            this.txt_local_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_local_backup.Location = new System.Drawing.Point(29, 260);
            this.txt_local_backup.Name = "txt_local_backup";
            this.txt_local_backup.Size = new System.Drawing.Size(522, 31);
            this.txt_local_backup.TabIndex = 410;
            this.txt_local_backup.Text = "D:";
            // 
            // btn_configBackup
            // 
            this.btn_configBackup.BackColor = System.Drawing.Color.Blue;
            this.btn_configBackup.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_configBackup.ForeColor = System.Drawing.Color.Yellow;
            this.btn_configBackup.Location = new System.Drawing.Point(179, 112);
            this.btn_configBackup.Name = "btn_configBackup";
            this.btn_configBackup.Size = new System.Drawing.Size(364, 84);
            this.btn_configBackup.TabIndex = 421;
            this.btn_configBackup.Text = "Configurar backup";
            this.btn_configBackup.UseVisualStyleBackColor = false;
            this.btn_configBackup.Click += new System.EventHandler(this.btn_configBackup_Click);
            // 
            // btn_Config_restore
            // 
            this.btn_Config_restore.BackColor = System.Drawing.Color.Blue;
            this.btn_Config_restore.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Config_restore.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Config_restore.Location = new System.Drawing.Point(564, 112);
            this.btn_Config_restore.Name = "btn_Config_restore";
            this.btn_Config_restore.Size = new System.Drawing.Size(362, 84);
            this.btn_Config_restore.TabIndex = 422;
            this.btn_Config_restore.Text = "Recuperar sistema";
            this.btn_Config_restore.UseVisualStyleBackColor = false;
            this.btn_Config_restore.Click += new System.EventHandler(this.btn_Config_restore_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.panel1.Location = new System.Drawing.Point(-2, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 40);
            this.panel1.TabIndex = 423;
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
            // txt_hora
            // 
            this.txt_hora.AutoSize = true;
            this.txt_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hora.ForeColor = System.Drawing.Color.Yellow;
            this.txt_hora.Location = new System.Drawing.Point(400, 305);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(128, 31);
            this.txt_hora.TabIndex = 422;
            this.txt_hora.Text = "00:00:00";
            // 
            // frm_bakup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Config_restore);
            this.Controls.Add(this.btn_configBackup);
            this.Controls.Add(this.txt_horaRestore);
            this.Controls.Add(this.painel_backup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_voltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_bakup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_bakup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.txt_horaRestore.ResumeLayout(false);
            this.txt_horaRestore.PerformLayout();
            this.painel_backup.ResumeLayout(false);
            this.painel_backup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_salvarBackup;
        private System.Windows.Forms.Button btn_alterarLocal;
        private System.Windows.Forms.Panel painel_backup;
        private System.Windows.Forms.TextBox txt_local_backup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel txt_horaRestore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Restaurar;
        private System.Windows.Forms.Button btn_buscarArquivo;
        private System.Windows.Forms.TextBox txt_localRestore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_local_instalacaoMsql;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_freq_backup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txt_resp_backup_anterior;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_alterarLocalInstalacao;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_configBackup;
        private System.Windows.Forms.Button btn_Config_restore;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_readSerial;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label txt_usuario_Logado;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.MaskedTextBox txt_dataRestore;
        private System.Windows.Forms.Label txt_hora;
    }
}