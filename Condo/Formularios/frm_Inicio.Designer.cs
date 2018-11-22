namespace Condo
{
    partial class frm_Inicio
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
            this.btn_retirarEncomenda = new System.Windows.Forms.Button();
            this.btn_alocarEncomenda = new System.Windows.Forms.Button();
            this.btn_Setup = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_encerrar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_data = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_statusPort = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_retirarEncomenda
            // 
            this.btn_retirarEncomenda.BackColor = System.Drawing.Color.Blue;
            this.btn_retirarEncomenda.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_retirarEncomenda.ForeColor = System.Drawing.Color.Yellow;
            this.btn_retirarEncomenda.Location = new System.Drawing.Point(26, 273);
            this.btn_retirarEncomenda.Name = "btn_retirarEncomenda";
            this.btn_retirarEncomenda.Size = new System.Drawing.Size(331, 214);
            this.btn_retirarEncomenda.TabIndex = 3;
            this.btn_retirarEncomenda.Text = "Retirar Encomenda";
            this.btn_retirarEncomenda.UseVisualStyleBackColor = false;
            this.btn_retirarEncomenda.Click += new System.EventHandler(this.btn_retirarEncomenda_Click);
            // 
            // btn_alocarEncomenda
            // 
            this.btn_alocarEncomenda.BackColor = System.Drawing.Color.Blue;
            this.btn_alocarEncomenda.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alocarEncomenda.ForeColor = System.Drawing.Color.Yellow;
            this.btn_alocarEncomenda.Location = new System.Drawing.Point(379, 273);
            this.btn_alocarEncomenda.Name = "btn_alocarEncomenda";
            this.btn_alocarEncomenda.Size = new System.Drawing.Size(333, 214);
            this.btn_alocarEncomenda.TabIndex = 6;
            this.btn_alocarEncomenda.Text = "Alocar Encomenda";
            this.btn_alocarEncomenda.UseVisualStyleBackColor = false;
            this.btn_alocarEncomenda.Click += new System.EventHandler(this.btn_alocarEncomenda_Click);
            // 
            // btn_Setup
            // 
            this.btn_Setup.BackColor = System.Drawing.Color.Blue;
            this.btn_Setup.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setup.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Setup.Location = new System.Drawing.Point(735, 273);
            this.btn_Setup.Name = "btn_Setup";
            this.btn_Setup.Size = new System.Drawing.Size(333, 214);
            this.btn_Setup.TabIndex = 8;
            this.btn_Setup.Text = "Setup";
            this.btn_Setup.UseVisualStyleBackColor = false;
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, -2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 32);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(182, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 93);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(249, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 42);
            this.label2.TabIndex = 52;
            this.label2.Text = "INICIO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::Condo.Properties.Resources.constec;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_encerrar
            // 
            this.btn_encerrar.BackColor = System.Drawing.Color.Blue;
            this.btn_encerrar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encerrar.ForeColor = System.Drawing.Color.Yellow;
            this.btn_encerrar.Image = global::Condo.Properties.Resources.Voltar;
            this.btn_encerrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_encerrar.Location = new System.Drawing.Point(935, 1);
            this.btn_encerrar.Name = "btn_encerrar";
            this.btn_encerrar.Size = new System.Drawing.Size(157, 94);
            this.btn_encerrar.TabIndex = 15;
            this.btn_encerrar.Text = "Encerrar";
            this.btn_encerrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_encerrar.UseVisualStyleBackColor = false;
            this.btn_encerrar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.txt_data);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.txt_statusPort);
            this.panel3.Location = new System.Drawing.Point(2, 651);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 40);
            this.panel3.TabIndex = 90;
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data.ForeColor = System.Drawing.Color.Yellow;
            this.txt_data.Location = new System.Drawing.Point(3, 6);
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
            this.label21.Location = new System.Drawing.Point(479, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(165, 24);
            this.label21.TabIndex = 52;
            this.label21.Text = "Condo V1.0.0.10";
            // 
            // txt_statusPort
            // 
            this.txt_statusPort.AutoSize = true;
            this.txt_statusPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_statusPort.ForeColor = System.Drawing.Color.Yellow;
            this.txt_statusPort.Location = new System.Drawing.Point(879, 6);
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
            // frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1094, 694);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_encerrar);
            this.Controls.Add(this.btn_Setup);
            this.Controls.Add(this.btn_alocarEncomenda);
            this.Controls.Add(this.btn_retirarEncomenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicio_FormClosed);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_retirarEncomenda;
        private System.Windows.Forms.Button btn_alocarEncomenda;
        private System.Windows.Forms.Button btn_Setup;
        private System.Windows.Forms.Button btn_encerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label txt_statusPort;
        private System.Windows.Forms.Timer timer1;
    }
}