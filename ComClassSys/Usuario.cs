using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System.Data;

namespace ComClassSys
{
    public class Usuario
    {
        // propriedades da classe
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel? Nivel { get; set; }
        public bool Ativo { get; set; }

        // metodos contrutores
        public Usuario() { }

        public Usuario(int id, string nome, string email, string? senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }
        public Usuario(string nome, string email, string senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }
        /* metodos da classe - funcionalidades de usuario:
           | RF04-Inserir Usuario |
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
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.ExecuteNonQuery(); // executar do MySql (sinal do raio/ enter do terminal)
        }
        public bool Editar(int id)  // e possivel fazer com singleton
        {
            bool resultado = false;
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "sp_usuario_altera";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            try
            {
                cmd.ExecuteNonQuery();
                resultado = true;
            }
            catch(Exception)
            {
                throw;
            }

            return resultado;
        }
        public static Usuario ObterPorId(int id)
        {
            Usuario usuario = new Usuario();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id={id}";
            var dr = cmd.ExecuteReader(); // <- dr = dataReader = retorno da consulta (caso haja retorno)

            while (dr.Read())
            {
                /* 1º Forma de fazer
                   usuario = new Usuario(
                                         dr.GetInt32(0),
                                         dr.GetString(1),
                                         dr.GetString(2),
                                         null,
                                         dr.GetString(4), 
                                         dr.GetBoolean(5)
                                        ); // <- senha pode ser suprimida com null
                */

                // 1ª forma jeito 2 
                usuario = new(dr.GetInt32(0),
                              dr.GetString(1),
                              dr.GetString(2),
                              dr.GetString(3),
                              Nivel.ObterPorId(dr.GetInt32(4)),
                              dr.GetBoolean(5)
                             );

                /*  2º Forma de fazer
                    usuario.Id = dr.GetInt32(0); 
                    usuario.Nome = dr.GetString(1);
                    usuario.Email = dr.GetString(2);
                    usuario.Senha = dr.GetString(3);
                    usuario.Nivel = dr.GetString(4);
                    usuario.Ativo = dr.GetBoolean(5);
                */
            }

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
                                        Nivel.ObterPorId((4)),
                                        dr.GetBoolean(5)
                                     )
                         );
                // pode ser feito com o nome da tabela, sem ser com o indice da coluna
            }

            return lista;
        }
    }
}