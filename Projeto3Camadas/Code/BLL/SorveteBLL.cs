using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importação da camada de negócio e da camada de acesso a dados
using Projeto3Camadas.Code.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.Code.DAL;
using System.Data;

namespace Projeto3Camadas.Code.BLL
{
    class SorveteBLL
    { 
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_Sorvetes";


        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(SorveteDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Sabor}','{medDto.Marca}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(SorveteDTO medDto)
        {
            string editar = $"update {tabela} set sabor = '{medDto.Sabor}', marca = '{medDto.Marca}' where id = '{medDto.Id}';";
            conexao.ExecutarComando(editar);
        }
        public void Excluir(SorveteDTO medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
