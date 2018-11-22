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
    public partial class frm_ConsultaEbox : Form
    {
        Conexao ObjCon = new Conexao(DadosConexao.StringConection);

        int max_Ebox;
        int max_inclusao;
        Modelo mod = new Modelo();
        MySqlCommand ObjCmd;
        MySqlDataReader ObjDr;

        string[] lbs = new string[50]; //dar nomes aos labels

        
        public frm_ConsultaEbox()
        {
            InitializeComponent();
        }


        private void frm_ConsultaEbox_Load(object sender, EventArgs e)
        {

            ConexaoDao ObjDAo = new ConexaoDao(ObjCon);

            //verifica prazo de retirada encomendas
            mod.sql = "select max(id_inclusao) from tbl_inclusao_ebox";
            mod.string_1 = "max(id_inclusao)";
            ObjDAo.Retorna_String1(mod);
            max_inclusao = int.Parse(mod.string_1);

            for (int id_inclusao = 1; id_inclusao < max_inclusao + 1; id_inclusao ++)
            {
                mod.sql = "call pcd_update_data('" + id_inclusao + "')";
                ObjCmd = new MySqlCommand(mod.sql, ObjCon.Conection);
                ObjCon.Abrir();
                ObjCmd.ExecuteNonQuery();
                ObjCon.Fechar();
            }


                //conta quantas ebox cadastrada
            mod.sql = " SELECT MAX(id_ebox) FROM tbl_ebox";
            mod.string_1 = "MAX(id_ebox)";
            ObjDAo.Retorna_String1(mod);
            max_Ebox = int.Parse(mod.string_1);

           //Pega os nomes da ebox pelo indece
            for (int i = 1; i < max_Ebox +1; i++ )
            {               
                mod.sql = " SELECT num_ebox FROM tbl_ebox where id_ebox = '" + i + "'";
                mod.string_1 = "num_ebox";
                ObjDAo.Retorna_String1(mod);
                //recebe 1 guaarda na posicao 0 e concaterna id_ebox com Num_ebox                
                lbs[i - 1] = i.ToString() + "- " + mod.string_1;
                Carrega_Ebox();
            }

           //carrega a cor das pictures de acordo com seu status
            for (int i =0; i < max_Ebox + 1; i++)
            {
                mod.sql = " SELECT status_ebox FROM tbl_ebox where id_ebox = '" + i + "'";
                mod.string_1 = "status_ebox";
                ObjDAo.Retorna_String1(mod);
                string result = mod.string_1;

                if (result == "Livre")
                {
                    Carrega_pictureBox_color(i, Color.Lime);

                }
                else if (result == "Ocupado")
                {
                    Carrega_pictureBox_color(i,Color.Orange);
                }
                else if (result == "Bloqueado")
                {
                    Carrega_pictureBox_color(i, Color.Red);
                }
                else if (result == "Inativo")
                {
                    Carrega_pictureBox_color(i, Color.Blue);
                }             
                if (result == "Ocupado/Atraso")
                {
                    Carrega_pictureBox_color(i, Color.Pink);

                }
            }
        }
        public void Carrega_Ebox()
        {
            lb1.Text = lbs[0]; lb2.Text = lbs[1]; lb3.Text = lbs[2]; lb4.Text = lbs[3];
            lb5.Text = lbs[4]; lb6.Text = lbs[5]; lb7.Text = lbs[6]; lb8.Text = lbs[7];
            lb9.Text = lbs[8]; lb10.Text = lbs[9]; lb11.Text = lbs[10]; lb12.Text = lbs[11];
            lb13.Text = lbs[12]; lb14.Text = lbs[13]; lb15.Text = lbs[14]; lb16.Text = lbs[15];
            lb17.Text = lbs[16]; lb18.Text = lbs[17]; lb19.Text = lbs[18]; lb20.Text = lbs[19];

            lb21.Text = lbs[20]; lb22.Text = lbs[21]; lb23.Text = lbs[22]; lb24.Text = lbs[23];
            lb25.Text = lbs[24]; lb26.Text = lbs[25]; lb27.Text = lbs[26]; lb28.Text = lbs[27];
            lb29.Text = lbs[28]; lb30.Text = lbs[29]; lb31.Text = lbs[30]; lb32.Text = lbs[31];
            lb33.Text = lbs[32]; lb34.Text = lbs[33]; lb35.Text = lbs[34]; lb36.Text = lbs[35];
            lb37.Text = lbs[36]; lb38.Text = lbs[37]; lb39.Text = lbs[38]; lb40.Text = lbs[39];
            lb41.Text = lbs[40]; lb42.Text = lbs[41]; lb43.Text = lbs[42]; lb44.Text = lbs[43];
            lb45.Text = lbs[44]; lb46.Text = lbs[45]; lb47.Text = lbs[46]; lb48.Text = lbs[47];
            lb49.Text = lbs[48]; lb50.Text = lbs[49];
        }

        public void Carrega_pictureBox_color(int index, Color cor)
        {
            PictureBox[] pictures = { pb1, pb2,pb3, pb4,pb5,pb6,pb7,pb8,pb9,pb10,pb11,pb12,pb13,pb14,pb15,
                                      pb16,pb17,pb18,pb19,pb20,pb21,pb22,pb23,pb24,pb25,pb26,pb27,pb28,pb29,pb30 ,
                                      pb31,pb32,pb33,pb34,pb35,pb36,pb37,pb38,pb39,pb40,pb41,pb42,pb43,pb44,pb45,
                                      pb46,pb47,pb48,pb49,pb50
                                    };
            //recebe 1 guaarda na posicao 0
            pictures[index - 1].BackColor = cor;
            if (cor == Color.Pink)
            {
                pictures[index - 1].Image = picture_OcupadoAtraso.Image;
            }
            
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {            
            frm_setup frm = new frm_setup();
            frm.Show();
            this.Hide();
        }
                
    }
}


