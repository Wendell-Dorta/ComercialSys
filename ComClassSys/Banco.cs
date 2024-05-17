using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComClassSys
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {
            MySqlCommand cmd = new MySqlCommand();
            /* dados da conexão */
            string strconn = @"server=127.0.0.1;database=ComercialDB;user id=root;password=";
            MySqlConnection cn = new MySqlConnection(strconn);
            try /* tratamento de excessão */
            {
                cn.Open();
                cmd.Connection = cn;

                /* o que e cn?
                   cn é uma variavel do tipo MySqlConnection
                   um objeto do tipo mysqlconnectio, o metodo contrutor
                   suporta que passe por parametro uma string, que e em
                   especial uma string de conexão que tem caracteristicas 
                   (ip do server, nome, usuario, senha). Quando executado
                   ele pega o metodo acossiado e faz uma tentativa de conexão
                   ao servidor de banco de dados. Podendo executar comandos mysql nessa execução
                   cmd e do tipo MySqlCommand, e o metodo entrega este metodo, dentro do cmd,
                   é preciso dizer a conexão que sera usado esses comandos. A propriedade Connection
                   do MySqlCommand necessita de um valor MySqlConnection. Todos os comandos feitos no MySql
                   seram feitos pelo objeto cmd(MySqlCommand). Ele sera o cmd/workbench a partir de agora. */
            }
            catch (Exception)
            {

                throw;
            }

            return cmd;
        }
    }
}
