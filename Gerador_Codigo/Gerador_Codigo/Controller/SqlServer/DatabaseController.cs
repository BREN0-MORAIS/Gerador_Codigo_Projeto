using Dapper;
using Gerador_Codigo.Data.Services;
using Gerador_Codigo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gerador_Codigo.Controller
{
    public class DatabaseController
    {
        private readonly IRepositoryDapper _dapper;

        public DatabaseController(IRepositoryDapper dapper)
        {
            _dapper = dapper;
        }

        public List<Database> ObterTodos()
        {
            var sql = $"SELECT database_id	AS Id,name	AS Nome FROM SYS.DATABASES ORDER BY name";
            var query = _dapper.RetornarLista<Database>(sql).ToList();
            if(query == null)return null;

            return query;
        }

        public List<string> ObterTodosNome()
        {
            var sql = $"SELECT name	AS Nome FROM SYS.DATABASES ORDER BY name";
            var query = _dapper.RetornarLista<string>(sql).ToList();
            if (query == null) return null;

            return query;
        }

        public Database ObterPorNome(string nome)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@nome",nome);    
            var sql = $"SELECT database_id	AS Id,name	AS Nome FROM SYS.DATABASES ORDER BY name";
            var query = _dapper.RetornarObjeto<Database>(sql,parameter);
            if (query == null) return null;

            return query;
        }
    }
}
