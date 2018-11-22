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

namespace Condo.Formularios
{
    public partial class frm_Retirar : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

    
        public string String_port;
        public static string port_Com;
        public string Data;    //string coverte data para padrao sql
        public string user_logado; // chave foreign key
        public string name_logado;
        public int acao = 0;
        public string id_ebox;  //id_ ebox foreing key
        public string num_ebox;  //nome da ebox salvo no bd
        public int max_ebox;     //pega a quantidade max de ebox no bd
        public string senha_port;
        public string max_id_user; //max usuario cadastrado para id do proximo cadastro
        public string porta_ebox;
        public string abrir_ebox;
        String[] comandSerial = { "Ç", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z" };

        public frm_Retirar()
        {
            InitializeComponent();
        }

        private void frm_Retirar_Load(object sender, EventArgs e)
        {
             
            frm_login frm = new frm_login();
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
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
        
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3);
            tabControl1.Controls.Remove(tabPage4);
        }

        //altera tabPage
        public void Adiciona_TabPage(int index)
        {
            tabControl1.Controls.RemoveAt(0);
            TabPage[] tabPag = { tabPage1, tabPage2, tabPage3, tabPage4 };
            tabControl1.Controls.Add(tabPag[index]);
            tabControl1.SelectedTab = tabPag[index];
        }

        private void btn_verificar_Click_1(object sender, EventArgs e)
        {
            if ((txt_apartamento.Text == "") || (txt_bloco.Text == ""))
            {
                MessageBox.Show("SELECIONE BLOCO E APARTAMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            {
                ConexaoDao ObjDao = new ConexaoDao(ObjCon);
                mod.sql = "SELECT id_inclusao as Codigo,num_encomenda as Encomenda,id_ebox as Ebox,Bloco,Apto,data_inclusao FROM tbl_inclusao_ebox WHERE apto = '" +
                          txt_apartamento.Text + "' and bloco = '" + txt_bloco.Text + "' and processo = 'Em andamento'";
                dgv_ListaEncomendas.DataSource = ObjDao.ListarTabela_DGV(mod);
            }
        }

        private void txt_apartamento_Click_1(object sender, EventArgs e)
        {
            txt_apartamento.Items.Clear();

            string sql = "SELECT distinct apto from tbl_unidades group by apto";
            MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
            DataTable ObjDados = new DataTable();
            ObjAdp.Fill(ObjDados);
            for (int i = 0; i < ObjDados.Rows.Count; i++)
            {
                txt_apartamento.Items.Insert(i, ObjDados.Rows[i][0].ToString());
            }
        }

        private void txt_bloco_Click(object sender, EventArgs e)
        {
            txt_bloco.Items.Clear();

            string sql = "SELECT distinct bloco from tbl_unidades group by bloco";
            MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
            DataTable ObjDados = new DataTable();
            ObjAdp.Fill(ObjDados);
            for (int i = 0; i < ObjDados.Rows.Count; i++)
            {
                txt_bloco.Items.Insert(i, ObjDados.Rows[i][0].ToString());
            }
        }

        private void btn_RetirarEncomneda_Click(object sender, EventArgs e)
        {
            acao = 0;
            if (dgv_ListaEncomendas.RowCount < 1)
            {
                MessageBox.Show("NÃO EXISTE ENCOMENDAS PARA A UNIDADE INFORMADA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Adiciona_TabPage(1);
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("@");
                }
            }
        }

        private void txt_senha_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (txt_senha.Text.Length > 7)
            {
                ConexaoDao ObjDao = new ConexaoDao(ObjCon);
                try
                {
                    mod.sql = "Select id_user,nome,senha from tbl_usuario where senha = '" + txt_senha.Text + "'and apto = '" + txt_apartamento.SelectedItem + "' and bloco = '" + txt_bloco.SelectedItem + "' and perfil = 'Morador' ";
                    mod.string_1 = "id_user";
                    mod.string_2 = "nome";
                    mod.string_3 = "senha";

                    ObjDao.Retorna_String3(mod);
                    user_logado = mod.string_1;
                    name_logado = mod.string_2;
                    string senha = mod.string_3;
                    if ((user_logado != null) && (senha == txt_senha.Text))
                    {
                        // MessageBox.Show(cartao);
                        btn_Confirmar.Enabled = true;
                        txt_senha.Enabled = false;
                        txt_user.Text = "00" + user_logado + " - " + name_logado;
                    }
                    else
                    {
                        MessageBox.Show("ACESSO NEGADO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_senha.Text = "";
                        txt_user.Text = "********";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
                }

            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            acao = 1;            
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);

            if (dgv_ListaEncomendas.Rows.Count > 0)
            { 
                string id_inclusao = dgv_ListaEncomendas.Rows[0].Cells[0].Value.ToString();
                id_ebox = dgv_ListaEncomendas.Rows[0].Cells[2].Value.ToString();

                abrir_ebox = comandSerial[int.Parse(id_ebox)];
               // MessageBox.Show(abrir_ebox);
           
                //pega numero encomenda
                mod.sql = "select num_encomenda from tbl_inclusao_ebox where id_inclusao = '" + id_inclusao + "' ";
                mod.string_1 = "num_encomenda";
                ObjDao.Retorna_String1(mod);
                lb_encomenda.Text = "0" + id_inclusao + " " + mod.string_1;
                //pega nome da ebox
                mod.sql = "select num_ebox from tbl_ebox where id_ebox = '" + id_ebox + "' ";
                mod.string_1 = "num_ebox";
                ObjDao.Retorna_String1(mod);
                lb_compartimento.Text = "0" + id_ebox + " " + mod.string_1;
                lb_ebox.Text = mod.string_1;
                lb_bloco.Text = txt_bloco.Text;
                lb_apto.Text = txt_apartamento.Text;
                lb_morador.Text = txt_user.Text;
            }
            else
            {
                MessageBox.Show("NAO TEM ENCOMENDAS PARA A UNIDADE SELECIONADA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Adiciona_TabPage(2);        
            
        }
        private void Retirar_encomenda()
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);

            if (dgv_ListaEncomendas.Rows.Count > 0)
            {
                string id_inclusao = dgv_ListaEncomendas.Rows[0].Cells[0].Value.ToString();
                id_ebox = dgv_ListaEncomendas.Rows[0].Cells[2].Value.ToString();

                mod.sql = "Insert into tbl_retirada_ebox(id_inclusao,id_user,id_ebox,data_retirada)values('" + id_inclusao + "','" + user_logado + "','" + id_ebox + "',current_date)";

                ObjDao.InclusaoDados(mod);                
                ////pega numero encomenda
                //mod.sql = "select num_encomenda from tbl_inclusao_ebox where id_inclusao = '" + id_inclusao + "' ";
                //mod.string_1 = "num_encomenda";
                //ObjDao.Retorna_String1(mod);
                //lb_encomenda.Text = "0" + id_inclusao + " " + mod.string_1;
                ////pega nome da ebox
                //mod.sql = "select num_ebox from tbl_ebox where id_ebox = '" + id_ebox + "' ";
                //mod.string_1 = "num_ebox";
                //ObjDao.Retorna_String1(mod);
                //lb_compartimento.Text = "0" + id_ebox + " " + mod.string_1;
                //lb_ebox.Text = mod.string_1;
                //lb_bloco.Text = txt_bloco.Text;
                //lb_apto.Text = txt_apartamento.Text;
                //lb_morador.Text = txt_user.Text;
            }
            else
            {
                MessageBox.Show("NAO TEM ENCOMENDAS PARA A UNIDADE SELECIONADA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btn_cancelarLogin_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(Read_serial));   //chama outra thread para escrever o dado no text box
        }

        private void Read_serial(object sender, EventArgs e)
        {
            txt_readSerial.Text = "";

            String_port = serialPort1.ReadLine();
            txt_readSerial.Text = String_port;

            if (acao == 0)
            {
                senha_port = txt_readSerial.Text;
                Authetication_user(senha_port);
            }
            else if (acao == 1)
            {
                txt_portaEbox.Text = "PORTA  " + txt_readSerial.Text;
                porta_ebox = txt_readSerial.Text;
                Verifica_porta(porta_ebox);
            }

        }
        public void Authetication_user(string sql)
        {
               
                ConexaoDao ObjDao = new ConexaoDao(ObjCon);
                mod.sql = "Select id_user,nome,id_biometria from tbl_usuario where id_biometria = '" + sql + "'and apto = '" + txt_apartamento.SelectedItem + "' and bloco = '" + txt_bloco.SelectedItem + "' ";
                mod.string_1 = "id_user";
                mod.string_2 = "nome";
                mod.string_3 = "id_biometria";

                ObjDao.Retorna_String3(mod);

                user_logado = mod.string_1;
                name_logado = mod.string_2;
                string biometria = mod.string_3;
            try
            {
                int id_enviado = int.Parse(sql);
                int id_confirmado = int.Parse(biometria);

                if (id_enviado == id_confirmado)
                {
                    //MessageBox.Show(id_enviado.ToString() + "__" + id_confirmado.ToString());
                    btn_Confirmar.Enabled = true;
                    txt_senha.Enabled = false;
                    txt_user.Text = "00" + user_logado + " - " + name_logado;
                    picture_biometria.Image = Condo.Properties.Resources.digital;
                }
            }
            catch
            {
                txt_senha.Text = "";
                txt_user.Text = "PERFIL USUARIO NEGADO!";
                user_logado = null;
                name_logado = null;
                senha_port = null;
            }
            }
       
    private void Limpar()
        {
            txt_user.Text = "";
            user_logado = null;
            name_logado = null;
            senha_port = null;
            txt_apartamento.SelectedItem =null;
            txt_bloco.SelectedItem = null;
            txt_apartamento.Items.Clear();
            txt_bloco.Items.Clear();
            lb_apto.Text = "";
            lb_bloco.Text = "";
            lb_compartimento.Text = "";
            lb_ebox.Text = "";
            lb_encomenda.Text = "";
            lb_morador.Text = "";
            txt_info.Text = "Para abrir pressione abrir compartimento.";
            dgv_ListaEncomendas.DataSource = null;
            txt_portaEbox.Text = "PORTA FECHADO";
            painel_Porta.BackColor = Color.Blue;
            txt_portaEbox.ForeColor = Color.Yellow;
            btn_Cancelarretirada.Enabled = true;
            Adiciona_TabPage(0);
            picture_biometria.Image = Condo.Properties.Resources.pressione;
        }

        public void Verifica_porta(string porta)
        {
            if(porta.Contains("ABERTO"))
            {
                txt_portaEbox.Text = "PORTA ABERTO";
                painel_Porta.BackColor = Color.Lime;
                txt_portaEbox.ForeColor = Color.Red;
                btn_confirmarRetirada.Text = "Continuar";
                btn_Cancelarretirada.Enabled = false;
                txt_info.Text = "Retire a encomenda e feche a porta.";
                Retirar_encomenda();
            }
            else if (porta.Contains("FECHADO"))
            {
                txt_portaEbox.Text = "PORTA FECHADO";
                painel_Porta.BackColor = Color.Blue;
                txt_portaEbox.ForeColor = Color.Yellow;
                btn_confirmarRetirada.Text = "Confirmar retirada";
                txt_info.Text = "Pressione confirmar retirada para finalizar.";
            }
            else if (porta.Contains("ERRO"))
            {
                txt_portaEbox.Text = "PORTA ERRO";
                painel_Porta.BackColor = Color.Red;
                txt_portaEbox.ForeColor = Color.Yellow;
               // txt_portaEbox.Text = "PORTA ERRO";
               // MessageBox.Show("OCORREU UM ERRO COM A PORTA DO COMPARTIMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
            
        }

     
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void btn_confirmarRetirada_Click(object sender, EventArgs e)
        {
            if (btn_confirmarRetirada.Text == "Abrir compartimento")
            {
                if (serialPort1.IsOpen)
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write(abrir_ebox);
                    }
                    else
                    {
                        MessageBox.Show("ERRO DE CONEXÃO.VERIFIQUE SE O CABO USB ESTÁ CONECTADO CORRETAMENTE.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (btn_confirmarRetirada.Text == "Continuar")
            {
                if (txt_portaEbox.Text.Contains("PORTA ABERTO"))
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write("?");
                    }
                }
                else if (txt_portaEbox.Text.Contains("PORTA FECHADO"))
                {
                    MessageBox.Show("O COMPARTIMENTO NÃO FOI ABERTO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_portaEbox.Text.Contains("PORTA ERRO"))
                {
                    MessageBox.Show("VERIFIQUE SE A PORTA DO COMPARTIMETO ESTA FECHADO CORRETAMENTE.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write("?");
                    }
                }
            }
            else if (btn_confirmarRetirada.Text == "Confirmar retirada")
            {
                if (txt_portaEbox.Text.Contains("PORTA FECHADO"))
                {
                    Adiciona_TabPage(3);

                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write("*");
                    }
                }
                else if (txt_portaEbox.Text.Contains("PORTA ABERTO"))
                {
                    MessageBox.Show("FECHA O COMPARTIMENTO PARA FINALIZAR ENTREGA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txt_portaEbox.Text.Contains("PORTA ERRO"))
                {
                    MessageBox.Show("VERIFIQUE SE A PORTA DO COMPARTIMETO ESTA FECHADO CORRETAMENTE.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write("?"); 
                    }
                }
            }
          
        }

        private void btn_Cancelarretirada_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Limpar();
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
        }

        private void btn_retirarNovaEncomenda_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            frm_Retirar frm = new frm_Retirar();
            frm.Show();
            this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            Limpar();
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
