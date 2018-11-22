using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condo
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        //instancia classes
        Modelo mod = new Modelo();
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);

        //variaveis para passar dados para outro forms  
        public static string nome;
        public static string user_logado;

        //metodo construtor para passar dados para outros forms
        public string usuario_logado
        {
            get { return user_logado; }
        }
        public string nome_usuario
        {
            get { return nome; }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            string sql = "select nome from tbl_usuario where perfil = 'Admin' ";
            MySqlDataAdapter ObjAdp = new MySqlDataAdapter(sql, ObjCon.Conection);
            DataTable ObjDados = new DataTable();
            ObjAdp.Fill(ObjDados);
            for (int i = 0; i < ObjDados.Rows.Count; i++)
            {
                txt_nome.Items.Insert(i, ObjDados.Rows[i][0].ToString());
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);//instancia classe de conexao

            mod.nome = txt_nome.Text;
            mod.senha = txt_senha.Text;
            //string sql
            mod.sql = "SELECT * FROM tbl_usuario WHERE nome = '" + mod.nome + "' AND senha = '" + mod.senha + "' and perfil = 'Admin' ";

            if ((txt_nome.Text == "") || (txt_senha.Text == ""))
            {
                MessageBox.Show("PREENCHA OS CAMPOS NOME E SENHA!", "ACESO NEGADO!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //chama metodo para fazer login
                ObjDao.Verifica_Login(mod);
                //faz a leituras dos dados e retorna os valores lido
                nome = mod.nome;
                user_logado = mod.user_logado;
                //verifica se retornou algum dado ou nao
                if ((nome == null) || (user_logado == null))
                {
                    MessageBox.Show("LOGIN OU SENHA INVÁLIDOS!", "ACESSO NEGADO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_nome.Text = "";
                    txt_senha.Text = "";
                }
                else
                {                  
                    frm_setup frm = new frm_setup();
                    this.Hide();
                    frm.ShowDialog();  
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
