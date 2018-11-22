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
    public partial class frm_Consultas : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

        public frm_Consultas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_ConsultaEbox frm = new frm_ConsultaEbox();
            frm.Show();
            this.Hide();
        }

        private void btn_cadastrarUsuario_Click(object sender, EventArgs e)
        {
            dgv_ListarDados.DataSource = null;
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            mod.sql = "select id_user as Codigo,Nome,Perfil,Apto,Bloco,Data_cad as Data_Cadastro from tbl_usuario";
            dgv_ListarDados.DataSource = ObjDao.ListarTabela_DGV(mod);
        }

        private void btn_ConsultaEbox_Click(object sender, EventArgs e)
        {
            dgv_ListarDados.DataSource = null; 
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
            mod.sql = "select id_ebox as Codigo,Num_ebox,Tamanho,Status_Ebox,Data_cad as Data_Cadastro from tbl_ebox";
            dgv_ListarDados.DataSource = ObjDao.ListarTabela_DGV(mod);
        }

        private void btn_ConsultarEncomendas_Click(object sender, EventArgs e)
        {
            dgv_ListarDados.DataSource = null;
            ConexaoDao ObjDao = new ConexaoDao(ObjCon);
           mod.sql=" SELECT id_inclusao as Codigo, id_user as Entregador, id_ebox as Ebox, num_encomenda as Encomenda,"+
                     "apto,bloco,comentario, data_inclusao, data_retirada, status_retirada, processo FROM tbl_inclusao_ebox";
            dgv_ListarDados.DataSource = ObjDao.ListarTabela_DGV(mod);
        }

        private void btn_Relatorios_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
          
            frm_Inicio frm = new frm_Inicio();
            frm.Show();
            this.Hide();
        }

        private void frm_Consultas_Load(object sender, EventArgs e)
        {

        }

        private void btn_AtualizaLista_Click(object sender, EventArgs e)
        {

        }

       
    }
}
