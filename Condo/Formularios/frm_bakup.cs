using Condo.Class;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condo.Formularios
{
    public partial class frm_bakup : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

        public static string port_Com;
        public string Data;
        public string user_logado;
        public string nome_logado;
        public static string script_backup;//passa  valor para class
        public static string local_backup;
        public static string local_restore;
        public static string caminho_instalacao_Mysql;

      
        public string Caminho_backup
        {
            get { return local_backup;  }
        }
        public string Caminho_restore
        {
            get { return local_restore; }
        }
        public string Arquivo_sql
        {
            get { return script_backup; }
        }
        public string local_instalacao
        {
            get { return caminho_instalacao_Mysql; }
        }
        public frm_bakup()
        {
            InitializeComponent();
        }

        private void frm_bakup_Load(object sender, EventArgs e)
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
            nome_logado = frm.nome_usuario;

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

            ConexaoDao ObjDao = new ConexaoDao(ObjCon);

            mod.sql = "Select local_bd,freq_backup,local_backup from tbl_backup where id_backup = (Select max(id_backup) from tbl_backup)";
            mod.string_1 = "local_bd";
            mod.string_2 = "freq_backup";
            mod.string_3 = "local_backup";

            ObjDao.Retorna_String3(mod);

            txt_local_instalacaoMsql.Text = mod.string_1.Replace("#", "\\");
            txt_freq_backup.Text = mod.string_2;
            txt_local_backup.Text = mod.string_3.Replace("#", "\\");

            caminho_instalacao_Mysql = mod.string_1.Replace("#", "\\");
            local_backup = mod.string_3.Replace("#", "\\");
         ///
        }

        private void btn_alterarLocal_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "LOCAL PARA FAZER O BACKUP.";
            //abre caixa de diálogo para a busca de uma pasta para se salvar os arquivos
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                    txt_local_backup.Text = folderBrowserDialog1.SelectedPath;
                    local_backup = txt_local_backup.Text;           
                
            }
        }

        private void btn_salvarBackup_Click(object sender, EventArgs e)
        {
            Backup backup = new Backup();
            backup.Realizar_Backup();
          
        }

        private void btn_buscarArquivo_Click(object sender, EventArgs e)
        {
            txt_localRestore.Text = "";           
            //define as propriedades do controle 
            //OpenFileDialog
            this.openFileDialog1.Multiselect = false;
            this.openFileDialog1.Title = "SELECIONE ARQUIVO DE RECUPERAÇAO";
            openFileDialog1.InitialDirectory = "C:\\";
            //filtra para exibir somente arquivos de imagens    
            openFileDialog1.Filter = "Arquivo SQL(*.sql)|*.sql";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Le os arquivos selecionados 
                foreach (String arquivo in openFileDialog1.FileNames)
                {
                    txt_localRestore.Text += arquivo;                  
                    script_backup = txt_localRestore.Text;
                    caminho_instalacao_Mysql = txt_local_instalacaoMsql.Text;
                    // script_backup = System.IO.Path.GetFileName(openFileDialog1.FileName);
                }
            }
        }

        private void btn_Restaurar_Click(object sender, EventArgs e)
        {   

     
            if (script_backup == null)
            {
                MessageBox.Show("SELECIONE O ARQUIVO PARA RESTAURAÇÃO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Backup bk = new Backup();
                bk.Realizar_Restore();
                Resgistra_restore();//salva no bd
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {            
            folderBrowserDialog1.Description = "CAMINHO DA INSTALAÇÃO DO BANCO DE DADOS.";
            //abre caixa de diálogo para a busca de uma pasta para se salvar os arquivos
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txt_local_instalacaoMsql.Text = folderBrowserDialog1.SelectedPath;
                caminho_instalacao_Mysql = txt_local_instalacaoMsql.Text;

            }
        }

        private void btn_configBackup_Click(object sender, EventArgs e)
        {
            painel_backup.Visible = true;
            txt_horaRestore.Visible = false;

            ConexaoDao ObjDao = new ConexaoDao(ObjCon);

            mod.sql = "Select local_bd,freq_backup,local_backup from tbl_backup where id_backup = (Select max(id_backup) from tbl_backup)";
            mod.string_1 = "local_bd";
            mod.string_2 = "freq_backup";
            mod.string_3 = "local_backup";

            ObjDao.Retorna_String3(mod);

            txt_local_instalacaoMsql.Text = mod.string_1.Replace("#", "\\");
            txt_freq_backup.Text = mod.string_2;
            txt_local_backup.Text = mod.string_3.Replace("#", "\\");

            caminho_instalacao_Mysql = mod.string_1.Replace("#", "\\");
            local_backup = mod.string_3.Replace("#", "\\");
        }

        private void btn_Config_restore_Click(object sender, EventArgs e)
        {
            painel_backup.Visible = false;
            txt_horaRestore.Visible = true;

            ConexaoDao ObjDao = new ConexaoDao(ObjCon);

            mod.sql = "Select usuario,data_restore,hora_restore from tbl_restore where id_restore = (Select max(id_restore) from tbl_restore)";
            mod.string_1 = "usuario";
            mod.string_2 = "data_restore";
            mod.string_3 = "hora_restore";

            ObjDao.Retorna_String3(mod);

            txt_resp_backup_anterior.Text = mod.string_1;           
            txt_dataRestore.Text = mod.string_2;
            txt_hora.Text = mod.string_3;
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);

            mod.sql = "Insert into tbl_backup(id_user,local_bd,freq_backup,local_backup) Values('" + user_logado + "','" + txt_local_instalacaoMsql.Text.Replace(@"\","#")
                      + "','" + txt_freq_backup.Text + "','" + txt_local_backup.Text.Replace(@"\", "#") + "')";

            ObjDao.InclusaoDados(mod);

            MessageBox.Show("OS DADOS FORAM SALVOS COM SUCESSO!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Resgistra_restore()
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);

             mod.sql = "Insert into tbl_restore(id_user,usuario,local_restore,data_restore,hora_restore)Values('"+
                        user_logado +"','"+ nome_logado+"','"+txt_localRestore.Text.Replace(@"\","#")+"',current_date,current_time)";

             ObjDao.InclusaoDados(mod);
        
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
       
    }
}
