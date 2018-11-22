using MySql.Data.MySqlClient;
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
    public partial class frm_Condominio : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

        public string Data;
        public string user_logado;
        string RxString;
        string max_id_user;
        public string port_Com;
        //varial para verificar validação de campos
        bool validados;
        public frm_Condominio()
        {
            InitializeComponent();
        }

        private void frm_Condominio_Load(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            frm_Inicio frm_port = new frm_Inicio();
            port_Com = frm_port.port_Conect;

            frm_login frm = new frm_login();
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
            txt_usuario_Logado.Text = "00" + frm.usuario_logado + "  " + frm.nome_usuario;
            user_logado = frm.usuario_logado;

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
                    txt_statusPort.Text = "Conectado  " + port_Com;
                    if (serialPort1.IsOpen != true)
                    {
                        serialPort1.Open();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERRO DE CONEXÃO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void ValidaCampos()
        {

            if (txt_condominio.Text == "")
            {
                txt_condominio.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_rua.Text == "")
            {
                txt_rua.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_numero.Text == "")
            {
                txt_numero.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_cidade.Text == "")
            {
                txt_cidade.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_estado.Text == "")
            {
                txt_estado.BackColor = Color.Bisque;
                validados = true;
            }
        }
        private void limpar()
        {
            txt_condominio.Text = "";
            txt_rua.Text = "";
            txt_numero.Text = "";
            txt_estado.Text = "";
            txt_cidade.Text = "";
        } 

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_setup frm = new frm_setup();
            frm.Show();
            this.Hide();
        } 
        private void ckb_Incluir_unidades_Click(object sender, EventArgs e)
        {
            if (ckb_Incluir_unidades.Checked)
            {
                ckb_Incluir_unidades.BackColor = Color.Lime;
                ckb_Incluir_unidades.ForeColor = Color.Red;
                panel_Info_condominio.Visible = false;
                painel_unidades.Visible = true;
                painel_ebox.Visible = false;
                ckb_incluir_ebox.Checked = false;
                ckb_incluir_ebox.BackColor = Color.Blue;
                ckb_incluir_ebox.ForeColor = Color.White;
                Lista_Dados_Unidades();
            }            
        }

        private void ckb_incluir_ebox_Click(object sender, EventArgs e)
        {
            if (ckb_incluir_ebox.Checked)
            {
                ckb_incluir_ebox.BackColor = Color.Lime;
                ckb_incluir_ebox.ForeColor = Color.Red;
                panel_Info_condominio.Visible = false;
                painel_unidades.Visible = false;
                painel_ebox.Visible = true;
                ckb_Incluir_unidades.Checked = false;
                ckb_Incluir_unidades.BackColor = Color.Blue;
                ckb_Incluir_unidades.ForeColor = Color.White;
                Lista_Dados_Ebox();
            }
           
        }

        private void btn_salvarCondo_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaCampos();


                if (validados)
                {
                    MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVE SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    validados = false;
                }
                else
                {
                    mod.sql = "insert into tbl_condominio(nome,rua,numero,cidade,estado,data_cad)Values('" + txt_condominio.Text
                     + "','" + txt_rua.Text + "','" + txt_numero.Text + "','" + txt_cidade.Text + "','" + txt_estado.Text + "',current_date)";

                    ConexaoDao ObjDao = new ConexaoDao(ObjCon);
                    ObjDao.InclusaoDados(mod);
                    MessageBox.Show("O CADASTRADO FOI REALIZADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpar();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvarUnidaes_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            mod.sql = "select id_unidades,apto,bloco from tbl_unidades where apto = '" + txt_apto.Text + "'and bloco = '" + txt_bloco.Text + "'";
            mod.string_1 = "id_unidades";
            mod.string_2 = "apto";
            mod.string_3 = "bloco";
            ObjDao.Retorna_String3(mod);
            string apto = mod.string_2;
            string bloco = mod.string_3;

            if((apto == txt_apto.Text)&& (bloco == txt_bloco.Text))
            {
                MessageBox.Show("UNIDADE INFORMADA JÁ CADASTRADO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                mod.sql = "insert into tbl_unidades(id_user,apto,bloco)values( '"+user_logado+"','" + txt_apto.Text + "','" + txt_bloco.Text + "')";
                ObjDao.InclusaoDados(mod);
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lista_Dados_Unidades();
                txt_apto.Text = "";
                txt_bloco.Text = "";
            }
        }

        private void btn_SalvarEbox_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            mod.sql = "select id_ebox,num_ebox,tamanho from tbl_ebox where num_ebox = '" + txt_nomeEbox.Text+ "'";
            mod.string_1 = "id_ebox";
            mod.string_2 = "num_ebox";
            mod.string_3 = "tamanho";
            ObjDao.Retorna_String3(mod);
            string num_ebox = mod.string_2;

            if (num_ebox == txt_nomeEbox.Text)
            {
                MessageBox.Show("E-BOX INFORMADo JÁ CADASTRADO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    ValidaCampos_ebox();

                    if (validados)
                    {
                        MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVE SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validados = false;
                    }
                    else
                    {
                        mod.sql = "Insert into tbl_ebox(id_user,num_ebox,tamanho,status_ebox,data_cad)" +
                                  " values( '" + user_logado + "','" + txt_nomeEbox.Text + "','" + txt_tamanho.Text + "','" + txt_statusEbox.Text + "',current_date)";

                        ObjDao.InclusaoDados(mod);
                        MessageBox.Show("O Ebox " + txt_nomeEbox.Text + " FOI CADASTRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar_ebox();
                        Lista_Dados_Ebox();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ValidaCampos_ebox()
        {

            if (txt_nomeEbox.Text == "")
            {
                txt_nomeEbox.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_tamanho.Text == "")
            {
                txt_tamanho.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_statusEbox.Text == "")
            {
                txt_statusEbox.BackColor = Color.Bisque;
                validados = true;
            }
        }
        private void limpar_ebox()
        {
            txt_idEbox.Text = "";
            txt_nomeEbox.Text = "";
            txt_tamanho.Text = "";
            txt_statusEbox.Text = "";

        }
        private void Lista_Dados_Ebox()
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                mod.sql = "select id_ebox as Codigo,num_ebox as Ebox,Tamanho,status_ebox from tbl_ebox";
                dgv_Lista_Dados.DataSource = ObjDao.ListarTabela_DGV(mod);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE EBOX. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Lista_Dados_Unidades()
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
               
                mod.sql = "SELECT distinct apto as Apartamento,Bloco from tbl_unidades group by bloco,apto";
                dgv_Lista_Dados.DataSource = ObjDao.ListarTabela_DGV(mod);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE EBOX. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nomeEbox_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
            mod.sql = " SELECT MAX(id_ebox) + 1 FROM tbl_ebox";
            mod.string_1 = "MAX(id_ebox) + 1";
            ObjDAo.Retorna_String1(mod);
            txt_idEbox.Text = mod.string_1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

    }
}
