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
    public partial class frm_inclusao : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

        //varial para verificar validação de campos
        bool validados;
        public string String_port;
        public int acao = 0; //variavel para seleciona o acao serialport
        public static string port_Com;
        public string Data;    //string coverte data para padrao sql
        public string user_logado; // chave foreign key
        public string name_logado;
        public string id_ebox;  //id_ ebox foreing key
        public string num_ebox;  //nome da ebox salvo no bd
        public int max_ebox;     //pega a quantidade max de ebox no bd
        public string senha_port;
        public string max_id_user; //max usuario cadastrado para id do proximo cadastro Ç,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,X,W,Y,Z
        public string porta_ebox;
        string abrir_ebox;
        String[] comandSerial = { "Ç","A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z" };
        public frm_inclusao()
        {
            InitializeComponent();
        }
        
        private void frm_Inclusao_Load(object sender, EventArgs e)
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
            tabControl1.Controls.Remove(tabPage_autenticacao);          
            tabControl1.Controls.Remove(tagPage_compartimento);
            tabControl1.Controls.Remove(tabPage_finalizar);
            Listar_Encomenda();
        }
        public void Listar_Encomenda()
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            mod.sql = "Select id_inclusao as Codigo,id_ebox as Compartimento,num_encomenda,apto,bloco,data_inclusao,data_retirada from tbl_inclusao_ebox where processo = 'Em andamento'";
            dgv_ListaEncomendas.DataSource = ObjDao.ListarTabela_DGV(mod);
        }

        private void limpar()
        {
            txt_Num_encomenda.Text = "";
          //  txt_peso.Text = "";
            txt_apartamento.SelectedItem = null;
            txt_bloco.SelectedItem = null;
            txt_comnet.Text = "";
            txt_tamanho.Text = "";
            txt_dataRetirada.Text = "";
            txt_senha.Enabled = true;

            txt_senha.Text = "";
            txt_user.Text = "";
            txt_idEboxSelecionado.Text = "";
            txt_EboxSelecionado.Text = "";
            id_ebox = null;
            num_ebox = null;
            lb_apartamento.Text = "";
            lb_bloco.Text = "";
            lb_codigo.Text = "";
            lb_eboxSelecionado.Text = "";
            acao = 0;
            txt_info.Text = "Para abrir pressione abrir compartimento.";
            btn_confirmarEntrega.Text = "Abrir compartimento";

            tabControl1.Controls.Add(tagPage_dadosEncomenda);
            tabControl1.SelectedTab = tagPage_dadosEncomenda;
            tabControl1.Controls.Remove(tabPage_autenticacao);
            tabControl1.Controls.Remove(tagPage_compartimento);
            tabControl1.Controls.Remove(tabPage_finalizar);
            picture_biometria.Image = Condo.Properties.Resources.pressione;
            txt_portaEbox.Text = "PORTA FECHADO";
            painel_Porta.BackColor = Color.Blue;
            txt_portaEbox.ForeColor = Color.Yellow;
            Listar_Encomenda();
           // 
        }
        private void ValidaCampos()
        {

            if (txt_tamanho.Text == "")
            {
                txt_tamanho.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_Num_encomenda.Text == "")
            {
                txt_Num_encomenda.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_apartamento.Text == "")
            {
                txt_apartamento.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_bloco.Text == "")
            {
                txt_bloco.BackColor = Color.Bisque;
                validados = true;
            }          
            Data = txt_dataRetirada.Text;//.Now.ToString(); //pega data atual     
            try
            {
                Data = Data.Substring(6, 4) + Data.Substring(2, 3) + "/" + Data.Substring(0, 2); //converte para padrao Mysql 
            }
            catch
            {
                txt_dataRetirada.BackColor = Color.Bisque;
                validados = true;
            }
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            ValidaCampos();
            acao = 0;

            if (validados)
            {
                MessageBox.Show("ERRO! TODOS OS CAMPOS IDENTIFICADOS DEVE SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validados = false;
            }
            else
            {
                tabControl1.Controls.Add(tabPage_autenticacao);
                tabControl1.SelectedTab = tabPage_autenticacao;
                tabControl1.Controls.Remove(tagPage_dadosEncomenda);
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("@");
                }

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_Num_encomenda.Text = "";
            //  txt_peso.Text = "";
            txt_apartamento.Text = "";
            txt_bloco.Text = "";
            txt_comnet.Text = "";
            txt_tamanho.Text = "";
            txt_dataRetirada.Text = "";
            txt_senha.Enabled = true;
        }

        private void txt_apartamento_Click(object sender, EventArgs e)
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

        private void txt_senha_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt_senha.Text.Length > 7)
            {

                ConexaoDao ObjDao = new ConexaoDao(ObjCon);
                try
                {
                    mod.sql = "Select id_user,nome,perfil from tbl_usuario where senha = '" + txt_senha.Text + "' and perfil != 'Morador' ";
                    mod.string_1 = "id_user";
                    mod.string_2 = "nome";
                    mod.string_3 = "perfil";

                    ObjDao.Retorna_String3(mod);
                    user_logado = mod.string_1;
                    name_logado = mod.string_2;
                    string perfil = mod.string_3;
                    if ((user_logado != null) && ((perfil == "Entregador") || (perfil == "Admin")))
                    {
                        txt_user.Text = "00" + user_logado + " - " + name_logado;
                        txt_senha.Enabled = false;
                        btn_continuar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("PERFL DO USUARIO NÃO AUTORIZADO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_senha.Text = "";
                        txt_user.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Nao foi possivel se conectar base de dados" + "ERROS DE COMANDOS:" + ex.Message);
                }

            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            acao = 1;
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {

                for (int i = 1; i < max_ebox + 1; i++)
                {
                    mod.sql = " SELECT id_ebox,num_ebox,status_ebox FROM tbl_ebox where tamanho = '" + txt_tamanho.SelectedItem + "' and status_ebox = 'Livre' ";
                    mod.string_1 = "id_ebox";
                    mod.string_2 = "num_ebox";
                    mod.string_3 = "status_ebox";

                    ObjDao.Retorna_String3(mod);

                    id_ebox = mod.string_1;
                    num_ebox = mod.string_2;
                    string result = mod.string_3;
                    //  MessageBox.Show(id_ebox + " " + num_ebox + " " + result);
                    if (result == "Livre")
                    {
                        break;
                    }
                }
                
                if (txt_user.Text == "")
                {
                    MessageBox.Show("AUTENTICAÇÃO INVÁLIDA.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (id_ebox == null)
                {
                    MessageBox.Show("COMPARTIMENTO E-BOX INDISPONÍVEL.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                     abrir_ebox = comandSerial[int.Parse(id_ebox)];//ENVIA A LETRA CONRRESPONDE AO NUMERO DO COMPARTIMENTO
                  //   MessageBox.Show(abrir_ebox);

                    txt_idEboxSelecionado.Text = "00" + id_ebox;
                    txt_EboxSelecionado.Text = num_ebox;

                    tabControl1.Controls.Add(tagPage_compartimento);
                    tabControl1.SelectedTab = tagPage_compartimento;
                    tabControl1.Controls.Remove(tabPage_autenticacao);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            } 
        }

        public void Incluir_Encomenda()
        {
            try
            {
                ConexaoDao ObjDao = new ConexaoDao(ObjCon);

                mod.sql = "Insert into tbl_inclusao_ebox(id_user,id_ebox,num_encomenda,apto,bloco,comentario,data_inclusao,data_retirada)" +
                                  " values( '" + user_logado + "','" + id_ebox + "','" + txt_Num_encomenda.Text + "','" + txt_apartamento.Text
                                  + "','" + txt_bloco.Text + "','" + txt_comnet.Text + "',current_date,'" + Data + "')";

                ObjDao.InclusaoDados(mod);
              //  tabControl1.Controls.Add(tabPage_finalizar);
                lb_codigo.Text = txt_Num_encomenda.Text;
                lb_apartamento.Text = txt_apartamento.Text;
                lb_bloco.Text = txt_bloco.Text;
                lb_eboxSelecionado.Text = id_ebox + " " +txt_EboxSelecionado.Text;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpar();
            } 
            
        }
        private void txt_tamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexaoDao ObjDAo = new ConexaoDao(ObjCon);

            mod.sql = "select count(num_ebox) from tbl_ebox where tamanho = '" + txt_tamanho.Text + "' and status_ebox = 'Livre'";
            mod.string_1 = "count(num_ebox)";
            ObjDAo.Retorna_String1(mod);
            int Contagem = int.Parse(mod.string_1);
            max_ebox = Contagem;
            if (Contagem < 1)
            {
                MessageBox.Show("TAMANHO E-BOX SELECIONADO INDISPONÍVEL NO MOMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_tamanho.Items.Remove(txt_tamanho.Items[txt_tamanho.SelectedIndex]);

            }
        }
        public void Authetication_user(string sql)
        {
            try
            {
                ConexaoDao ObjDao = new ConexaoDao(ObjCon);
                mod.sql = "Select id_user,nome,perfil from tbl_usuario where id_biometria = '" + sql + "' ";
                mod.string_1 = "id_user";
                mod.string_2 = "nome";
                mod.string_3 = "perfil";

                ObjDao.Retorna_String3(mod);
                user_logado = mod.string_1;
                name_logado = mod.string_2;
                string perfil = mod.string_3;
                if ((perfil == "Entregador") || (perfil == "Admin"))
                {
                    if ((user_logado != null) && (name_logado != null))
                    {
                        txt_senha.Enabled = false;
                        txt_senha.Text = sql;
                        txt_user.Text = "00" + user_logado + " - " + name_logado;
                        txt_senha.Enabled = false;
                        btn_continuar.Enabled = true;
                        picture_biometria.Image = Condo.Properties.Resources.digital;
                    }
                }
                else
                {
                    txt_senha.Text = "";
                    txt_user.Text = "PERFIL USUARIO NEGADO!";
                    user_logado = null;
                    name_logado = null;
                    senha_port = null;
                    picture_biometria.Image = Condo.Properties.Resources.pressione;
                }
            }
            catch
            {
                txt_user.Text = senha_port;
                picture_biometria.Image = Condo.Properties.Resources.pressione;
            }
        }
        

        private void btn_finalizaar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            limpar();
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
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
            else if (acao == 2)
            {
                txt_portaEbox.Text = "PORTA  " + txt_readSerial.Text;
                porta_ebox = txt_readSerial.Text;
                Verifica_porta(porta_ebox);
            }
            //txt_readSerial.Text = "";

            //String_port = serialPort1.ReadLine();
            //txt_readSerial.Text = String_port;

            //if (acao == 0)
            //{
            //    senha_port = txt_readSerial.Text;
            //    Authetication_user(senha_port);
            //}
            //else if (acao == 1)
            //{
            //        txt_portaEbox.Text = "PORTA  " + txt_readSerial.Text;
            //        porta_ebox = txt_readSerial.Text;
            //}
           
        }
    
        private void serialPort1_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(Read_serial));   //chama outra thread para escrever o dado no text box 
        }

        private void btn_cancelarLogin_Click(object sender, EventArgs e)
        {           
            limpar();
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

        private void btn_CancelarEntrega_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            limpar();
        }

        private void btn_confirmarEntrega_Click(object sender, EventArgs e)
        {
            if (btn_confirmarEntrega.Text == "Abrir compartimento")
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
            else if (btn_confirmarEntrega.Text == "Continuar")
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
            else if (btn_confirmarEntrega.Text == "Confirmar entrega")
            {
                if (txt_portaEbox.Text.Contains("PORTA FECHADO"))
                {
                    tabControl1.Controls.Add(tabPage_finalizar);
                    tabControl1.SelectedTab = tabPage_finalizar;
                    tabControl1.Controls.Remove(tagPage_compartimento);
                    Incluir_Encomenda();

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

        private void btn_novaEncomenda_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }           
            frm_inclusao frm = new frm_inclusao();
            frm.Show();
            this.Hide();
        }

        public void Verifica_porta(string porta)
        {
            if (porta.Contains("ABERTO"))
            {
                txt_portaEbox.Text = "PORTA ABERTO";
                painel_Porta.BackColor = Color.Lime;
                txt_portaEbox.ForeColor = Color.Red;
                btn_confirmarEntrega.Text = "Continuar";
                txt_info.Text = "Coloque a encomenda e feche a porta.";
            }
            else if (porta.Contains("FECHADO"))
            {
                txt_portaEbox.Text = "PORTA FECHADO";
                painel_Porta.BackColor = Color.Blue;
                txt_portaEbox.ForeColor = Color.Yellow;
                btn_confirmarEntrega.Text = "Confirmar entrega";
                txt_info.Text = "Pressione confirmar entrega para finalizar.";
            }
            else if (porta.Contains("ERRO"))
            {
                txt_portaEbox.Text = "PORTA ERRO";
                painel_Porta.BackColor = Color.Red;
                txt_portaEbox.ForeColor = Color.Yellow;
                // txt_portaEbox.Text = "PORTA ERRO";
                //MessageBox.Show("OCORREU UM ERRO COM A PORTA DO COMPARTIMENTO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void dgv_ListaEncomendas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        ///////       
    }  ////
}      //////
