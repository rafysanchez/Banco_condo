using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Condo.Formularios;

namespace Condo
{
    public partial class frm_Inicio : Form
    {
        Modelo mod = new Modelo();
        public static string port_Com;
        public frm_Inicio()
        {
            InitializeComponent();
        }
        public string port_Conect
        {
            get { return port_Com; }
        }

        private void btn_Setup_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
          
            frm_login frm = new frm_login();
            serialPort1.Close();
            frm.Show();
            this.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            if (MessageBox.Show("REALMENTE DESEJA SAIR DO SISTEMA ?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            //string text = System.IO.File.ReadAllText(@"D:\Condo\Condo\Resources\chave.txt");
          //  MessageBox.Show(text);
           
            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
               comboBox1.Items.Add(s);
            }
            
            try
            {                
                if (comboBox1.Items.Count > 0)
                {
                  comboBox1.SelectedIndex = 0; // seleciona primeira linha
                  port_Com = comboBox1.Items[0].ToString();//pega primeira COM
                  serialPort1.PortName = port_Com;
                }

                if (serialPort1.IsOpen != true)
                {
                    serialPort1.Open();
                    txt_statusPort.Text = "Conectado  "+ port_Com;
                } 
                else
                {
                    //serialPort1.Open();
                    txt_statusPort.Text = "Conectado  " + port_Com;
                }

            }
            catch
            {
                MessageBox.Show("ERRO DE CONEXÃO." + "\n" +" O HARDWARE ESPECIFICADO NÃO FOI LOCALIZADO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frmInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }

        private void btn_alocarEncomenda_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
          
            frm_inclusao frm = new frm_inclusao();
            frm.Show();
            this.Hide();
        }

        private void btn_retirarEncomenda_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
          
            frm_Retirar frm = new frm_Retirar();
            frm.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
