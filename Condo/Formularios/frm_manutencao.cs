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
    public partial class frm_manutencao : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

        public string port_Com;
        public string user_logado;
        public string id_os;
        public string abrir_ebox;
        String[] comandSerial = { "Ç", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "X", "W", "Y", "Z" };
        public frm_manutencao()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_manutencao_Load(object sender, EventArgs e)
        {
            
            frm_login frm = new frm_login();
            txt_data.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
            txt_usuario_Logado.Text = "00" + frm.usuario_logado + "  " + frm.nome_usuario;
            user_logado = frm.usuario_logado;

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                txt_listaPorta.Items.Add(s);
                txt_ListPort.Items.Add(s);
            }

            try
            {
                if (txt_listaPorta.Items.Count > 0)
                {
                    txt_listaPorta.SelectedIndex = 0; // seleciona primeira linha
                    port_Com = txt_listaPorta.Items[0].ToString();//pega primeira COM
                    serialPort1.PortName = port_Com;
                    txt_statusPort.Text = "Conectado  " + port_Com;
                    txt_estadoPorta.Text = "Conectado";
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
            limpar();
        
            // tabControl1.SelectedTab = tabPage1;
            //TabControl1.Controls.Remove(tabPage_bloqueio);
            TabControl1.Controls.Remove(tabPage_desbloqueio);
            TabControl1.Controls.Remove(tabPage_abertura);
            TabControl1.Controls.Remove(tabPage_conexao);
            Status_Cheked(0);
            Lista_bloqueio();
        }
        public void limpar()
        {

            txt_dataOcorrencia.Text = "";
            txt_motivo.Text = "";
            txt_idEbox.Text = "";
            txt_nomeEbox.Text = "";

            txt_empresa.Text = "";
            txt_responsavel.Text = "";
            txt_idEbox_desbloqueio.Text = "";
            txt_nomeEbox_desbloqueio.Text = "";
            txt_coment.Text = "";
            txt_dataDesbloqueio.Text = "";

            txt_idEbox_abertura.Text = "";
            txt_NomeEbox_abertura.Text = "";
            txt_MotivoAbertura.Text = "";
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
        private void ckb_bloquearEbox_CheckedChanged(object sender, EventArgs e)
        {
            Status_Cheked(0);
            Lista_bloqueio();
        }

        private void ckb_liberar_CheckedChanged(object sender, EventArgs e)
        {
                Status_Cheked(1);
                Lista_desbloqueio();
        }

        private void ckb_abrirEbox_CheckedChanged(object sender, EventArgs e)
        {
            Lista_LogAbertura();
                Status_Cheked(2);
        }

        private void ckb_conectar_CheckedChanged(object sender, EventArgs e)
        {
            Status_Cheked(3);
            foreach (string s in SerialPort.GetPortNames())
            {             
                txt_ListPort.Items.Add(s);
            }

            try
            {
                if (txt_ListPort.Items.Count > 0)
                {
                    txt_ListPort.SelectedIndex = 0; // seleciona primeira linha
                }
            }
            catch
            {
                MessageBox.Show("ERRO DE CONEXÃO." + "\n" + "VERIFIQUE SE O CABO USB ESTA CONECTADO. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void Status_Cheked(int index)
        {
            limpar();

            TabControl1.Controls.RemoveAt(0);
            CheckBox[] checkBox = {ckb_bloquearEbox,ckb_liberar,ckb_abrirEbox,ckb_conectar};
            TabPage[] tabPag = {tabPage_bloqueio,tabPage_desbloqueio,tabPage_abertura,tabPage_conexao };

            TabControl1.Controls.Add(tabPag[index]);
            TabControl1.SelectedTab = tabPag[index];
           // TabControl1.Controls.RemoveAt(0);

            for (int i = 0; i < 4; i++ )
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
                }
            }
        }

      
        private void ckb_abrirTodos_CheckedChanged(object sender, EventArgs e)
        {
            txt_NomeEbox_abertura.Items.Clear();

            if (ckb_abrirTodos.Checked)
            {
                ckb_abrirTodos.BackColor = Color.Lime;
                ckb_abrirTodos.ForeColor = Color.Red;

                txt_NomeEbox_abertura.Items.Insert(0,"TODOS");
                txt_NomeEbox_abertura.SelectedIndex = 0;
                txt_idEbox_abertura.Text = "1";
                txt_NomeEbox_abertura.Enabled = false;
            }
            else
            {
                ckb_abrirTodos.BackColor = Color.Blue;
                ckb_abrirTodos.ForeColor = Color.White;

                txt_NomeEbox_abertura.Items.Clear();
                txt_idEbox_abertura.Text = "";
                txt_NomeEbox_abertura.Enabled = true;
            }
        }

        private void txt_nomeEbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
            mod.sql = " SELECT id_ebox from tbl_ebox where num_ebox = '"+txt_nomeEbox.SelectedItem+"' ";
            mod.string_1 = "id_ebox";
            ObjDAo.Retorna_String1(mod);
            txt_idEbox.Text = mod.string_1; 
        }

        private void txt_nomeEbox_Click(object sender, EventArgs e)
        {
            txt_nomeEbox.Items.Clear();

            string sql = "SELECT distinct num_ebox from tbl_ebox";
            MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
            DataTable ObjDados = new DataTable();
            ObjAdp.Fill(ObjDados);
            for (int i = 0; i < ObjDados.Rows.Count; i++)
            {
                txt_nomeEbox.Items.Insert(i, ObjDados.Rows[i][0].ToString());
            }
        }

        private void btn_salvarBloqeio_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                string Data = txt_dataOcorrencia.Text;
                Data = Data.Substring(6, 4) + Data.Substring(2, 3) + "/" + Data.Substring(0, 2); //converte para padrao Mysql 

                if ((txt_idEbox.Text == "") || (txt_motivo.Text == "") || (Data == null))
                {
                    MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    mod.sql = "insert into tbl_os_aberto(id_user,id_ebox,motivo,data_ocorrencia,data_cad) values('" + user_logado + "','" + txt_idEbox.Text + "','" +
                               txt_motivo.Text + "','" + Data + "',current_date)";

                    ObjDao.InclusaoDados(mod);

                    MessageBox.Show("O COMPARTIMENTO " + txt_nomeEbox.Text + " FOI BLOQUEADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    Lista_bloqueio();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btn_cancelarBloqueio_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_ccancelarDesbloqueio_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void CancelarAbertura_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void btn_salvarDesbloqueio_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
            string Data = txt_dataDesbloqueio.Text;
            Data = Data.Substring(6, 4) + Data.Substring(2, 3) + "/" + Data.Substring(0, 2); //converte para padrao Mysql 

            if ((txt_empresa.Text == "") || (txt_responsavel.Text == "") || (txt_idEbox_desbloqueio.Text == "") || (Data == null))
            {
                MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

               mod.sql = "insert into tbl_os_fechado(id_os_aberto,id_user,id_ebox,empresa,responsavel,comentario,data_conclusao,data_cad) values('" +
                           id_os+"','"+ user_logado +"','"+txt_idEbox_desbloqueio.Text+"','"+txt_empresa.Text+"','"+txt_responsavel.Text+"','"+
                            txt_coment.Text+"','"+Data+"',current_date)";

                    ObjDao.InclusaoDados(mod);

                    MessageBox.Show("O COMPARTIMENTO " + txt_nomeEbox_desbloqueio.Text + " FOI DESBLOQUEADO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    Lista_desbloqueio();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_nomeEbox_desbloqueio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
            mod.sql = "select tbl_ebox.id_ebox,tbl_ebox.num_ebox,tbl_os_aberto.id_os_aberto from tbl_ebox inner join tbl_os_aberto  where tbl_ebox.id_ebox = tbl_os_aberto.id_ebox and num_ebox = '" +
                     txt_nomeEbox_desbloqueio.SelectedItem + "' and status_os = 'Em aberto'";

            mod.string_1 = "id_ebox";
            mod.string_2 = "num_ebox";
            mod.string_3 = "id_os_aberto";
            ObjDAo.Retorna_String3(mod);

            txt_idEbox_desbloqueio.Text = mod.string_1;
            id_os = mod.string_3;
        }

        private void txt_nomeEbox_desbloqueio_Click(object sender, EventArgs e)
        {
            txt_nomeEbox_desbloqueio.Items.Clear();

            string sql = " select num_ebox from tbl_ebox inner join tbl_os_aberto where tbl_ebox.id_ebox = tbl_os_aberto.id_ebox and status_os = 'Em aberto'";
            MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
            DataTable ObjDados = new DataTable();
            ObjAdp.Fill(ObjDados);
            for (int i = 0; i < ObjDados.Rows.Count; i++)
            {
                txt_nomeEbox_desbloqueio.Items.Insert(i, ObjDados.Rows[i][0].ToString());
            }
        }

        private void txt_empresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_empresa_Click(object sender, EventArgs e)
        {
            txt_empresa.Items.Clear();

            string sql = "SELECT distinct empresa from tbl_os_fechado";
            MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
            DataTable ObjDados = new DataTable();
            ObjAdp.Fill(ObjDados);
            for (int i = 0; i < ObjDados.Rows.Count; i++)
            {
                txt_empresa.Items.Insert(i, ObjDados.Rows[i][0].ToString());
            }
        }

        public void Lista_bloqueio()
        {

            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                mod.sql = "select o.id_os_aberto as Codigo,e.num_ebox as Ebox ,o.Motivo,o.Data_ocorrencia,u.nome as Responsavel from tbl_ebox e "+
                          "inner join tbl_os_aberto o inner join tbl_usuario u where e.id_ebox = o.id_ebox and o.id_user = u.id_user and o.status_os = 'Em aberto'";
                dgv_ListaBloqueio.DataSource = ObjDao.ListarTabela_DGV(mod);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Lista_desbloqueio()
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                mod.sql = "select f.id_os_fechado as Codigo,o.id_os_aberto as Ocorrencia,e.num_ebox as Ebox ,o.Motivo,o.Data_cad as Data_bloqueio,f.data_cad as Data_desbloqueio,f.Empresa,f.responsavel as Responsavel "+
                          "from tbl_ebox e inner join tbl_os_aberto o inner join tbl_os_fechado f where e.id_ebox = o.id_ebox and f.id_os_fechado = o.id_os_aberto";
                dgv_ListaDesbloqueio.DataSource = ObjDao.ListarTabela_DGV(mod);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Lista_LogAbertura()
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            try
            {
                mod.sql = "Select id_log_abertura as Codigo,Ebox,Motivo,data_log as Data,hora_log as Hora,nome as Responsavel "+
                           "from tbl_log_abertura inner join tbl_usuario where tbl_log_abertura.id_user = tbl_usuario.id_user";
                dgv_Lista_LogAbertura.DataSource = ObjDao.ListarTabela_DGV(mod);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("NÃO FOI POSSIVEL CARREGAR A LISTA. " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ConfirmarAbertura_Click(object sender, EventArgs e)
        {
            try
            {
              ConexaoDao ObjDao = new ConexaoDao(ObjCon);

                 if((txt_idEbox_abertura.Text == "")|| (txt_MotivoAbertura.Text == ""))
               {
                   MessageBox.Show("ERRO AO CADASTRAR! TODOS OS CAMPOS DEVEM SER PREENCHIDOS.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
                 else
                 {

                if (ckb_abrirTodos.Checked)
                {
                    abrir_ebox = "%";
                    mod.sql = "insert into tbl_log_abertura (id_user,ebox,motivo,data_log,hora_log)Values('"+user_logado+"','"+txt_NomeEbox_abertura.SelectedItem+"','"+
                               txt_MotivoAbertura.Text+"',current_date,current_time)";
                }
                else
                {
                    abrir_ebox = comandSerial[int.Parse(txt_idEbox_abertura.Text)];

                    mod.sql = "insert into tbl_log_abertura (id_user,ebox,motivo,data_log,hora_log)Values('" + user_logado + "','Todos','" +
                                txt_MotivoAbertura.Text + "',current_date,current_time)";
                }
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(abrir_ebox);
                    ObjDao.InclusaoDados(mod);

                    MessageBox.Show("O COMPARTIMENTO SELECIONADO FOI ABERTO COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    Lista_LogAbertura();
                }
                else
                {
                    MessageBox.Show("SISTEMA NÃO CONECTADO. VERIFIQUE SE O CABO USB ESTA CONECTADO.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                 }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERRO AO CADSTRAR.  " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void txt_NomeEbox_abertura_Click(object sender, EventArgs e)
        {
            txt_NomeEbox_abertura.Items.Clear();

            string sql = "SELECT distinct num_ebox from tbl_ebox";
            MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
            DataTable ObjDados = new DataTable();
            ObjAdp.Fill(ObjDados);
            for (int i = 0; i < ObjDados.Rows.Count; i++)
            {
                txt_NomeEbox_abertura.Items.Insert(i, ObjDados.Rows[i][0].ToString());
            }
        }

        private void txt_NomeEbox_abertura_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexaoDao ObjDAo = new ConexaoDao(ObjCon);
            mod.sql = " SELECT id_ebox from tbl_ebox where num_ebox = '" + txt_NomeEbox_abertura.SelectedItem + "' ";
            mod.string_1 = "id_ebox";
            ObjDAo.Retorna_String1(mod);
            txt_idEbox_abertura.Text = mod.string_1; 

        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            if (txt_estadoPorta.Text == "Conectado")
            {
                MessageBox.Show("O SISTEMA JA ESTÁ CONECTADO.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    port_Com = txt_ListPort.Items[0].ToString();//pega primeira COM
                    serialPort1.PortName = port_Com;
                    if (serialPort1.IsOpen != true)
                    {
                        serialPort1.Open();
                        txt_estadoPorta.Text = "Conectado";
                        txt_statusPort.Text = "Conectado  " + port_Com;
                        btn_conectar.Enabled = false;
                        btn_desconectar.Enabled = true;
                    }
                }
                catch
                {
                    MessageBox.Show("NENHUMA PORTA DISPONIVEL. VERIFIQUE SE O CABO USB ESTA CONECTADO CORRETAMENTE.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
     
        }

        private void btn_desconectar_Click(object sender, EventArgs e)
        {
            if (txt_estadoPorta.Text == "Não conectado")
            {
                MessageBox.Show("O SISTEMA NÃO ESTÁ CONECTADO.", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Close();
                        txt_statusPort.Text = "Não conectado";
                        txt_estadoPorta.Text = "Não conectado";
                        btn_conectar.Enabled = true;
                        btn_desconectar.Enabled = false;
                    }
                }
                catch
                {
                    MessageBox.Show("NENHUMA PORTA DISPONIVEL. VERIFIQUE SE O CABO USB ESTA CONECTADO CORRETAMENTE.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

    }
}
