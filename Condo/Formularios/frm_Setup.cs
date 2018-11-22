using Condo.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condo
{
    public partial class frm_setup : Form
    {
        Modelo mod = new Modelo();
        public static string port_Com;
        public frm_setup()
        {
            InitializeComponent();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
        }

        private void btn_cadastrarUsuario_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            frm_CadastroUsuario frm = new frm_CadastroUsuario();
            frm.Show();
            this.Hide();
        }

        private void frmSetup_Load(object sender, EventArgs e)
        {          

            frm_login frm = new frm_login();
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
            txt_usuario_Logado.Text = "00" + frm.usuario_logado + "  " + frm.nome_usuario;

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

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
                    txt_statusPort.Text = "Conectado  " + port_Com;
                }
                else
                {
                    //serialPort1.Open();
                    txt_statusPort.Text = "Conectado  " + port_Com;
                }

            }
            catch
            {
                MessageBox.Show("ERRO DE CONEXÃO." + "\n" + " O HARDWARE ESPECIFICADO NÃO FOI LOCALIZADO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btn_voltar_Click_1(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }      
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
        }

        private void btn_condominio_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
          
            frm_Condominio frm = new frm_Condominio();
            frm.Show();
            this.Hide();

        }

        private void btn_consultas_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
          
            frm_Consultas frm = new frm_Consultas();
            frm.Show();
            this.Hide();

        }

        private void btn_manutencao_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
          
            frm_manutencao frm = new frm_manutencao();
            frm.Show();
            this.Hide(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            frm_bakup frm = new frm_bakup();
            frm.Show();
            this.Hide(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            frm_ConsultaEbox frm = new frm_ConsultaEbox();
            frm.Show();
            this.Hide();
        }
    }
}
