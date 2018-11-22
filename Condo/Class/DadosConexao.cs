using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condo
{
    class DadosConexao
    {

        //Metodo contrutor devolve string de conexao com banco de dados
        public static string StringConection
        {
            get
            {
                return "SERVER=127.0.0.1;DATABASE=condo;UID=root;PASSWORD=;";
            }
        }
    }
}
