using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;

namespace ComClassSys
{
    public class Usuario
    {
        // propriedades da classe
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public string? Nivel { get; set; }
        public bool Ativo { get; set; }

        // metodos contrutores
        public Usuario() { }

        public Usuario(int id, string nome, string email, string senha, string nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public Usuario(string nome, string email, string senha, string nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        /* metodos da classe - funcionalidades de usuario:
           | RF04-Inserir Usuario |
           | --- |
           | --- |
        */

        public void Inserir()
        {
            var cmd = Banco.Abrir(); // obj do tipo sql command
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            // adicionar valores de insersão no banco
            // spnome varchar(60), spemail varchar(60), spsenha varchar(32), spnivel char(1)
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel);
            cmd.ExecuteNonQuery(); // executar do MySql (sinal do raio/ enter do terminal)
        }
        public bool Editar(int id)  // e possivel fazer com singleton
        {
            return true;
        }
        public Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            return usuario;
        }
        public static List<Usuario> ObterLista()
        {
            // listar o usuario
            List<Usuario> lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios order by nome";
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Usuario(
                                        dr.GetInt32(0),
                                        dr.GetString(1),
                                        dr.GetString(2),
                                        dr.GetString(3),
                                        dr.GetString(4),
                                        dr.GetBoolean(5)
                                     ));
                // pode ser feito com o nome da tabela, sem ser com o indice da coluna
            }
            return lista;
        }
    }
}