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
using MySql.Data.MySqlClient;

namespace Condo
{
    public partial class frm_CadastroUsuario : Form

    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

        public static string port_Com;
        public string Data;
        public string user_logado;
        string perfil_usuario;
        bool validados;
        public string Serial_read;
        public int acao;
        //public int id = 13;

        public frm_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void frmCadastro_Usuario_Load(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
            }

            frm_Inicio frm_port = new frm_Inicio();
            port_Com = frm_port.port_Conect;

            frm_login frm = new frm_login();
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
            txt_usuario_Logado.Text = "00" + frm.usuario_logado + "  " + frm.nome_usuario;
            user_logado = frm.usuario_logado;
            Lista_Dados();

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

    
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoDao ObjDao = new ConexaoDao(ObjCon);              
                if (ckb_admin.Checked)
                {
                    if (validados)
                    {
                        MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validados = false;
                    }
                    else if (txt_senha.Text.Length < 8)
                    {
                        MessageBox.Show("SENHA DEVE CONTER 8 DIGITOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mod.sql = "Insert into tbl_usuario(nome,perfil,apto,bloco,senha,id_biometria,data_cad,user_logado)" +
                               " values('" + txt_nome.Text + "','" + perfil_usuario + "','" + txt_apto_empresa.Text
                               + "','" + txt_bloco_funcao.Text + "','" + txt_senha.Text + "','" + txt_id_Biometria.Text + "',current_date,'" + user_logado + "')";

                        ObjDao.InclusaoDados(mod);

                        MessageBox.Show("O USUARIO " + txt_nome.Text + " FOI CADASTRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        Lista_Dados();
                    }

                }
                else if (ckb_entregador.Checked)
                {
                    if (validados)
                    {
                        MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validados = false;
                    }
                    else if (txt_senha.Text.Length < 8)
                    {
                        MessageBox.Show("SENHA DEVE CONTER 8 DIGITOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mod.sql = "Insert into tbl_usuario(nome,perfil,apto,bloco,senha,id_biometria,data_cad,user_logado)" +
                               " values('" + txt_nome.Text + "','" + perfil_usuario + "','" + txt_apto_empresa.Text
                               + "','" + txt_bloco_funcao.Text + "','" + txt_senha.Text + "','" + txt_id_Biometria.Text + "',current_date,'" + user_logado + "')";

                        ObjDao.InclusaoDados(mod);

                        MessageBox.Show("O USUARIO " + txt_nome.Text + " FOI CADASTRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        Lista_Dados();
                    }

                }
                else if (ckb_morador.Checked)
                {
                    ValidaCampos();

                    mod.sql = "select nome,apto,bloco from tbl_usuario where apto = '" + txt_apto_empresa.Text + "'and bloco = '" + txt_bloco_funcao.Text + "'";
                    mod.string_1 = "nome";
                    mod.string_2 = "apto";
                    mod.string_3 = "bloco";

                    ObjDao.Retorna_String3(mod);

                    string nome = mod.string_1;
                    string apto = mod.string_2;
                    string bloco = mod.string_3;

                    if ((apto == txt_apto_empresa.Text) && (bloco == txt_bloco_funcao.Text))
                    {
                        MessageBox.Show("UNIDADE INFORMADA JÁ CADASTRADO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (validados)
                    {
                        MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        validados = false;
                    }
                    else if (txt_senha.Text.Length < 8)
                    {
                        MessageBox.Show("SENHA DEVE CONTER 8 DIGITOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mod.sql = "Insert into tbl_usuario(nome,perfil,apto,bloco,senha,id_biometria,data_cad,user_logado)" +
                               " values('" + txt_nome.Text + "','" + perfil_usuario + "','" + txt_apto_empresa.Text
                               + "','" + txt_bloco_funcao.Text + "','" + txt_senha.Text + "','" + txt_id_Biometria.Text + "',current_date,'" + user_logado + "')";

                        ObjDao.InclusaoDados(mod);
  
                        MessageBox.Show("O USUARIO " + txt_nome.Text + " FOI CADASTRADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        Lista_Dados();
                    }
                }  
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void ValidaCampos()
        {
            //if (txt_idMorador.Text == "")
            //{
            //    txt_idMorador.BackColor = Color.Bisque;
            //    validados = true;
            //}
            if (txt_nome.Text == "")
            {
                txt_nome.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_apto_empresa.Text=="")
            {
                txt_apto_empresa.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_bloco_funcao.Text == "")
            {
                txt_bloco_funcao.BackColor = Color.Bisque;
                validados = true;
            }
            if (txt_senha.Text == "")
            {
                txt_senha.BackColor = Color.Bisque;
                validados = true;
            }      
        }
        private void limpar()
        {
            txt_id_Biometria.Text = "";
            txt_iduser.Text = "";
            txt_nome.Text = "";
            txt_apto_empresa.Items.Clear();
            txt_senha.Text = "";
            txt_bloco_funcao.Items.Clear();
            btn_update.Enabled = false;
            btn_salvar.Enabled = true;       
            picture_biometria.Image = Condo.Properties.Resources.semdigital;
        }
        private void Lista_Dados()
        {
             ckb_morador.Checked = false;
             ckb_entregador.Checked = false;
             ckb_admin.Checked = false; 
             panel4.Enabled = false; 

            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                mod.sql = "select id_user as Codigo,Nome,apto as Apartamento,Bloco,senha,id_biometria,data_cad from tbl_usuario where perfil = 'Morador' ";
                dgv_ListaUsuarios.DataSource = ObjDao.ListarTabela_DGV(mod);

                dgv_ListaUsuarios.Columns[4].Visible = false;
                dgv_ListaUsuarios.Columns[5].Visible = false;
  
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. "+ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void txt_nomeMorador_Click(object sender, EventArgs e)
        {
                ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
                mod.sql = " SELECT MAX(id_user) + 1 FROM tbl_usuario";
                mod.string_1 = "MAX(id_user) + 1";
                ObjDAo.Retorna_String1(mod);
                int id = int.Parse(mod.string_1);
                if (id < 10)
                {
                    txt_iduser.Text = "0" + id.ToString();
                }
                else
                {
                    txt_iduser.Text = id.ToString();
                }
              
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            this.Invoke(new EventHandler(Read_serial));   //chama outra thread para escrever o dado no text box 
        }
        private void Read_serial(object sender, EventArgs e)
        {
           // txt_msg_port.Text = "";   
            Serial_read = serialPort1.ReadLine();
            ReadStringPort(Serial_read);
            txt_msg_port.Text = Serial_read;
           
        }
        public void ReadStringPort(String msg)
        {
            if (msg.Contains(txt_iduser.Text))
            {
                txt_id_Biometria.Text = txt_iduser.Text;
                picture_biometria.Image = Condo.Properties.Resources.digital;
                txt_msg_port.Visible = false;
                dgv_ListaUsuarios.Visible = true;
            }
        }

        private void btn_cadBiometria_Click(object sender, EventArgs e)
        {
            if (txt_iduser.Text == "")
            {
                MessageBox.Show("INFORME O NOME DO USUÁRIO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_msg_port.Visible = true;
                dgv_ListaUsuarios.Visible = false;

                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(txt_iduser.Text);
                }
            }
           
        }
        public void Verifica_Cheked(int index)
        {
            CheckBox[] checkBox = {ckb_morador,ckb_entregador,ckb_admin };
            for (int i = 0; i < 3; i++)
            {
                if (i == index)
                {
                    checkBox[i].BackColor = Color.Lime;
                    checkBox[i].ForeColor = Color.Red;
                }
                else
                {
                    checkBox[i].BackColor = Color.Blue;
                    checkBox[i].ForeColor = Color.White;
                    checkBox[i].Checked = false;
                }
            }
        }

        private void ckb_morador_CheckedChanged(object sender, EventArgs e)
        {
            limpar();

            if (ckb_morador.Checked)
            {
                panel4.Enabled = true;
                txt_bloco_funcao.Items.Clear();
                txt_apto_empresa.Items.Clear();
                lb_bloco_funcao.Text = "Bloco:";
                lb_apto_empresa.Text = "Apartamento:";
                perfil_usuario = "Morador";

                Verifica_Cheked(0);

                string sql = "SELECT distinct bloco from tbl_unidades group by bloco";
                MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
                DataTable ObjDados = new DataTable();
                ObjAdp.Fill(ObjDados);
                for (int i = 0; i < ObjDados.Rows.Count; i++)
                {
                    txt_bloco_funcao.Items.Insert(i, ObjDados.Rows[i][0].ToString());
                }

                string sql2 = "SELECT distinct apto from tbl_unidades group by apto";
                MySqlDataAdapter ObjAdp2 = new MySqlDataAdapter(sql2, ObjCon.Conection);
                DataTable ObjDados2 = new DataTable();
                ObjAdp2.Fill(ObjDados2);
                for (int i = 0; i < ObjDados2.Rows.Count; i++)
                {
                    txt_apto_empresa.Items.Insert(i, ObjDados2.Rows[i][0].ToString());
                }

            }
            
        }

        private void ckb_entregador_CheckedChanged(object sender, EventArgs e)
        {
            limpar();

            if (ckb_entregador.Checked)
            {
                panel4.Enabled = true;
              
                lb_bloco_funcao.Text = "Função:";
                lb_apto_empresa.Text = "Empresa:";
                perfil_usuario = "Entregador";

                txt_apto_empresa.Items.Clear();
                txt_bloco_funcao.Items.Clear();

                Verifica_Cheked(1);

                string[] empresa = { "Correios", "Condominio", "Terceirizado" };
                for (int i = 0; i < 3; i++)
                {
                    txt_apto_empresa.Items.Insert(i, empresa[i]);
                }

                string[] funcao = { "Porteiro", "Zelador", "Sindico", "Entregador" };
                for (int i = 0; i < 4; i++)
                {
                    txt_bloco_funcao.Items.Insert(i, funcao[i]);
                }
            }
        }
        private void ckb_admin_CheckedChanged(object sender, EventArgs e)
        {
            limpar();

            if (ckb_admin.Checked)
            {
                panel4.Enabled = true;

                txt_bloco_funcao.Items.Clear();
                txt_apto_empresa.Items.Clear();

                lb_bloco_funcao.Text = "Função:";
                lb_apto_empresa.Text = "Empresa:";
                perfil_usuario = "Admin";

                Verifica_Cheked(2);

               
                string[] empresa = { "Correios", "Condominio", "Terceiro" };
                for (int i = 0; i < 3; i++)
                {
                    txt_apto_empresa.Items.Insert(i, empresa[i]);
                }

                string[] funcao = { "Porteiro", "Zelador", "Sindico", "Entregador" };
                for (int i = 0; i < 4; i++)
                {
                    txt_bloco_funcao.Items.Insert(i, funcao[i]);
                }
            }
        }
   
        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }
     
        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                mod.sql = "select id_user as Codigo,Nome,apto as Apartamento,Bloco,senha,id_biometria,data_cad  from tbl_usuario where perfil = 'Morador' and  (nome like '%" + txt_pesquisa.Text + "%')";
                dgv_ListaUsuarios.DataSource = ObjDao.ListarTabela_DGV(mod);

                dgv_ListaUsuarios.Columns[4].Visible = false;
                dgv_ListaUsuarios.Columns[5].Visible = false;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                mod.sql = "select id_user as Codigo,Nome,apto as Apartamento,Bloco,senha,id_biometria,data_cad  from tbl_usuario where perfil = 'Morador' and  (nome like '%" + txt_pesquisa.Text + "%')";               
                dgv_ListaUsuarios.DataSource = ObjDao.ListarTabela_DGV(mod);

                dgv_ListaUsuarios.Columns[4].Visible = false;
                dgv_ListaUsuarios.Columns[5].Visible = false;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA DE USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_msg_port_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void dgv_ListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btn_update.Enabled = true;
            //btn_salvar.Enabled = false;
            //panel4.Enabled = true;
            //txt_apto_empresa.Items.Clear();
            //txt_bloco_funcao.Items.Clear();

            //txt_iduser.Text = dgv_ListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            //txt_nome.Text = dgv_ListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            //txt_bloco_funcao.Items.Insert(0,dgv_ListaUsuarios.CurrentRow.Cells[2].Value.ToString());
            //txt_apto_empresa.Items.Insert(0,dgv_ListaUsuarios.CurrentRow.Cells[3].Value.ToString());
            //txt_senha.Text = dgv_ListaUsuarios.CurrentRow.Cells[4].Value.ToString();
            //txt_cod_cartao.Text = dgv_ListaUsuarios.CurrentRow.Cells[5].Value.ToString();
            //txt_id_Biometria.Text = dgv_ListaUsuarios.CurrentRow.Cells[6].Value.ToString();

            //txt_apto_empresa.SelectedIndex=0;
            //txt_bloco_funcao.SelectedIndex = 0;


        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validados)
            {
                MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS IDENTIFICADOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validados = false;
            }
            else
            {
                try
                {
                    ConexaoDao ObjDao = new ConexaoDao(ObjCon);

                    mod.sql = "Update tbl_usuario set nome = '"+txt_nome.Text+"',apto = '"+txt_apto_empresa.Text+"',bloco = '"+txt_bloco_funcao.Text+"',senha = '"+
                         txt_senha.Text+"',id_biometria = '"+txt_id_Biometria.Text+"' WHERE id_user = '"+txt_iduser.Text+"' ";

                    ObjDao.Modifica_Dados(mod);

                    MessageBox.Show("O CADASTRO FOI ATUALIZADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    Lista_Dados();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("NÃO FOI POSSIVEL ATUALIZAR  OS DADOS DO USUARIOS. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_ListaUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_update.Enabled = true;
            btn_salvar.Enabled = false;
            panel4.Enabled = true;
            txt_apto_empresa.Items.Clear();
            txt_bloco_funcao.Items.Clear();

            txt_iduser.Text = dgv_ListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dgv_ListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            txt_bloco_funcao.Items.Insert(0, dgv_ListaUsuarios.CurrentRow.Cells[2].Value.ToString());
            txt_apto_empresa.Items.Insert(0, dgv_ListaUsuarios.CurrentRow.Cells[3].Value.ToString());
            txt_senha.Text = dgv_ListaUsuarios.CurrentRow.Cells[4].Value.ToString();
            txt_id_Biometria.Text = dgv_ListaUsuarios.CurrentRow.Cells[5].Value.ToString();
            if (txt_id_Biometria.Text != "")
            {
                picture_biometria.Image = Condo.Properties.Resources.digital;
            }
            else
            {
             picture_biometria.Image = Condo.Properties.Resources.semdigital;
            }

            txt_apto_empresa.SelectedIndex = 0;
            txt_bloco_funcao.SelectedIndex = 0;
        }

        private void txt_apto_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

     

    }
}
