using Gerador_Codigo.Configuration;
using Npgsql;
using System;
using System.Data;

namespace Gerador_Codigo.Data.Services
{
    public class ConnectionAdoPostgres : ConnectionAdo
    {
        private Cryptography _crypto;
        private XmlOperation _xml;
        public ConnectionAdoPostgres()
        {
            ParamCollection = new NpgsqlCommand().Parameters;
            _crypto = new Cryptography();
            _xml = new XmlOperation();
            ConnectionString = _crypto.OpCrypto(_xml.loadFromConfig("connBD"), false, 2);
            ConnectionStringImage = _crypto.OpCrypto(_xml.loadFromConfig("connBDImage"), false, 2);
                   VerificarConexao(ConnectionStringImage);
        }

        /// <summary>
        /// Método responsável por adicionar um parâmetro em uma coleção.
        /// </summary>
        /// <param name="name">Informe o nome do parâmetro.</param>
        /// <param name="value">Informe o valor do parâmetro.</param>
        public override void AdicionarParametros(string name, object value)
        {
            ParamCollection.Add(new NpgsqlParameter(name, value));
        }


        /// <summary>
        /// Método para retornar uma instância de Connection
        /// </summary>
        /// <returns>NpgsqlConnection</returns>
        public override IDbConnection CriarConexao()
        {
            return new NpgsqlConnection(ConnectionString);
        }


        /// <summary>
        /// Método para efetuar a persistência dos dados e retornar um DataTable.
        /// </summary>
        /// <param name="commandType">Informe o tipo da operação, Text ou StoredProcedure.</param>
        /// <param name="textSql">Infome a string sql ou o nome da StoredProcedure.</param>
        /// <returns></returns>
        public override DataTable ExecutarConsultaComRetorno(CommandType commandType, string textSql)
        {
            try
            {
                var conn = CriarConexao();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = textSql;
                cmd.CommandTimeout = 0;

                foreach (NpgsqlParameter sqlParameter in ParamCollection)
                    cmd.Parameters.Add(new NpgsqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                var dataAdapter = new NpgsqlDataAdapter((NpgsqlCommand)cmd);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (NpgsqlException ex)
            {
                var error = ex.Message;
                return null;
            }
        }


        /// <summary>
        /// Método para efetuar a persistência dos dados e retornar um Object.
        /// </summary>
        /// <param name="commandType">Informe o tipo da operação, Text ou StoredProcedure.</param>
        /// <param name="textSql">Infome a string sql ou o nome da StoredProcedure.</param>
        /// <returns>NpgsqlDataReader</returns>
        public override IDataReader ExecuteReader(CommandType commandType, string textSql)
        {
            try
            {
                var conn = CriarConexao();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = textSql;
                cmd.CommandTimeout = 0;
                return (NpgsqlDataReader)cmd.ExecuteReader();
            }
            catch (NpgsqlException ex)
            {
                var error = ex.Message;
                return null;
            }
        }


        /// <summary>
        /// Método para efetuar a persistência dos dados e retornar um Object.
        /// </summary>
        /// <param name="commandType">Informe o tipo da operação, Text ou StoredProcedure.</param>
        /// <param name="textSql">Infome a string sql ou o nome da StoredProcedure.</param>
        /// <returns></returns>
        public override object ExecuteScalar(CommandType commandType, string textSql)
        {
            try
            {
                var conn = CriarConexao();

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var cmd = conn.CreateCommand();
                cmd.CommandType = commandType;
                cmd.CommandText = textSql;
                cmd.CommandTimeout = 0;

                foreach (NpgsqlParameter sqlParameter in ParamCollection)
                    cmd.Parameters.Add(new NpgsqlParameter(sqlParameter.ParameterName, sqlParameter.Value));

                return (NpgsqlDataReader)cmd.ExecuteScalar();
            }
            catch (NpgsqlException ex)
            {
                var error = ex.Message;
                return null;
            }
        }


        /// <summary>
        /// Método responsável por limpar os parâmetros de uma coleção.
        /// </summary>
        public override void LimparParamentros()
        {
            ParamCollection.Clear();
        }


        /// <summary>
        /// Método para retornar a string de conexão
        /// </summary>
        /// <returns>string de conexão</returns>
        public override string ObterStringConexao()
        {
            return ConnectionString;
        }


        /// <summary>
        /// Método responsável por verificar a conexão com o banco de dados
        /// </summary>
        /// <param name="connectionString">Informe a String de conexão.</param>
        /// <returns>Verdadeiro ou Falso</returns>
        public override bool VerificarConexao(string connectionString)
        {
            try
            {
                if (string.IsNullOrEmpty(connectionString)) return false;
                var conn = new NpgsqlConnection(connectionString);
                conn.Open();
                ConnectionString = conn.ConnectionString;
                return true;
            }
            catch (Exception ex)
            {
                var error = ex.Message;
                return false;
            }
        }
        public override void BancoConectado()
        {
            Console.WriteLine("Foi Conectado com o Postgres!!!");
        }
    }
}
