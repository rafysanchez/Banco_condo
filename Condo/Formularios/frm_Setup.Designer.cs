namespace Condo
{
    partial class frm_setup
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
            this.btn_cadastrarUsuario = new System.Windows.Forms.Button();
            this.btn_condominio = new System.Windows.Forms.Button();
            this.btn_consultas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn_manutencao = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_usuario_Logado = new System.Windows.Forms.Label();
            this.txt_data = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cadastrarUsuario
            // 
            this.btn_cadastrarUsuario.BackColor = System.Drawing.Color.Blue;
            this.btn_cadastrarUsuario.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrarUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.btn_cadastrarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrarUsuario.Location = new System.Drawing.Point(99, 131);
            this.btn_cadastrarUsuario.Name = "btn_cadastrarUsuario";
            this.btn_cadastrarUsuario.Size = new System.Drawing.Size(419, 125);
            this.btn_cadastrarUsuario.TabIndex = 5;
            this.btn_cadastrarUsuario.Text = "Cadastro Usuários";
            this.btn_cadastrarUsuario.UseVisualStyleBackColor = false;
            this.btn_cadastrarUsuario.Click += new System.EventHandler(this.btn_cadastrarUsuario_Click);
            // 
            // btn_condominio
            // 
            this.btn_condominio.BackColor = System.Drawing.Color.Blue;
            this.btn_condominio.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_condominio.ForeColor = System.Drawing.Color.Yellow;
            this.btn_condominio.Location = new System.Drawing.Point(572, 294);
            this.btn_condominio.Name = "btn_condominio";
            this.btn_condominio.Size = new System.Drawing.Size(419, 125);
            this.btn_condominio.TabIndex = 7;
            this.btn_condominio.Text = "Condominio";
            this.btn_condominio.UseVisualStyleBackColor = false;
            this.btn_condominio.Click += new System.EventHandler(this.btn_condominio_Click);
            // 
            // btn_consultas
            // 
            this.btn_consultas.BackColor = System.Drawing.Color.Blue;
            this.btn_consultas.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultas.ForeColor = System.Drawing.Color.Yellow;
            this.btn_consultas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_consultas.Location = new System.Drawing.Point(572, 131);
            this.btn_consultas.Name = "btn_consultas";
            this.btn_consultas.Size = new System.Drawing.Size(419, 125);
            this.btn_consultas.TabIndex = 8;
            this.btn_consultas.Text = "Consultas";
            this.btn_consultas.UseVisualStyleBackColor = false;
            this.btn_consultas.Click += new System.EventHandler(this.btn_consultas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(190, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(739, 93);
            this.panel2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 53;
            this.label2.Text = "MENU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Condo.Properties.Resources.constec;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.Blue;
            this.btn_fechar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fechar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_fechar.Image = global::Condo.Properties.Resources.Voltar;
            this.btn_fechar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_fechar.Location = new System.Drawing.Point(931, 1);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(161, 94);
            this.btn_fechar.TabIndex = 19;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_voltar_Click_1);
            // 
            // btn_manutencao
            // 
            this.btn_manutencao.BackColor = System.Drawing.Color.Blue;
            this.btn_manutencao.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manutencao.ForeColor = System.Drawing.Color.Yellow;
            this.btn_manutencao.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_manutencao.Location = new System.Drawing.Point(99, 462);
            this.btn_manutencao.Name = "btn_manutencao";
            this.btn_manutencao.Size = new System.Drawing.Size(419, 125);
            this.btn_manutencao.TabIndex = 23;
            this.btn_manutencao.Text = "Manutenção";
            this.btn_manutencao.UseVisualStyleBackColor = false;
            this.btn_manutencao.Click += new System.EventHandler(this.btn_manutencao_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.txt_usuario_Logado);
            this.panel3.Controls.Add(this.txt_data);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.txt_statusPort);
            this.panel3.Location = new System.Drawing.Point(1, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 40);
            this.panel3.TabIndex = 90;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(143, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 91;
            this.comboBox1.Visible = false;
            // 
            // txt_usuario_Logado
            // 
            this.txt_usuario_Logado.AutoSize = true;
            this.txt_usuario_Logado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario_Logado.ForeColor = System.Drawing.Color.Yellow;
            this.txt_usuario_Logado.Location = new System.Drawing.Point(556, 6);
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
            this.label21.Location = new System.Drawing.Point(463, 6);
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
            this.txt_statusPort.Location = new System.Drawing.Point(880, 4);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(572, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(419, 125);
            this.button1.TabIndex = 91;
            this.button1.Text = "Backup e Restore";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(99, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(419, 125);
            this.button2.TabIndex = 92;
            this.button2.Text = "Compartimentos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1094, 694);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_manutencao);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.btn_consultas);
            this.Controls.Add(this.btn_condominio);
            this.Controls.Add(this.btn_cadastrarUsuario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_setup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSetup_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cadastrarUsuario;
        private System.Windows.Forms.Button btn_condominio;
        private System.Windows.Forms.Button btn_consultas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_fechar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_manutencao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_usuario_Logado;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}