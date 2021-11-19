using Projeto3Camadas.Code.DAL;
using Projeto3Camadas.Code.DTO;
using System.Data;

namespace Projeto3Camadas.Code.BLL
{
    class LoginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_usuarios";


        public bool RealizarLogin(LoginDTO Login)
        {
            string sql = $"select * from {tabela} where email='{Login.Email}' and senha='{Login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RetornarSenha(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarConsulta(sql);


            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }
    }
}
