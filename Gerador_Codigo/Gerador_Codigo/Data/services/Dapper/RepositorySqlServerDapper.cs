using Dapper;
using Gerador_Codigo.Data.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Gerador_Codigo.Data.Services
{
    public class RepositorySqlServerDapper : IRepositoryDapper
    {
        private readonly ApplicationDbContext _db;
        private string _connectionString = string.Empty;

        public RepositorySqlServerDapper(ApplicationDbContext db)
        {
            _db = db;
            _connectionString = _db.Database.GetDbConnection().ConnectionString;
        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public T RetornarObjeto<T>(string procedureName, DynamicParameters param = null, CommandType commandType = CommandType.Text)
        {
            using (var sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                return (T)Convert.ChangeType(sqlCon.ExecuteScalar<T>(procedureName, param, commandType: commandType), typeof(T));
            }
        }


        public void ExecutarSemRetorno(string procedureName, DynamicParameters param = null, CommandType commandType = CommandType.Text)
        {
            using (var sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: commandType);
            }
        }

        public IEnumerable<T> RetornarLista<T>(string procedureName,
            DynamicParameters param = null,
            CommandType commandType = CommandType.Text)
        {
            using (var sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: commandType);
            }
        }

        public async Task<bool> ExecuteWithoutReturnAsync(string procedureName, DynamicParameters param = null, CommandType commandType = CommandType.Text)
        {
            using (var sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                await sqlCon.ExecuteAsync(procedureName, param, commandType: commandType);
            }

            return true;
        }

        public string ObterNomeBanco()
        {
            throw new NotImplementedException();
        }

        public string ObterNomeServidor()
        {
            throw new NotImplementedException();
        }

        public string ObterStringConexao()
        {
            return _connectionString;
        }
    }
}
