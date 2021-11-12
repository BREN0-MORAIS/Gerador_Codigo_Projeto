using Dapper;
using Gerador_Codigo.Data.Services;
using Gerador_Codigo.Models;
using System.Collections.Generic;
using System.Linq;

namespace Gerador_Codigo.Controller
{
    public class TableController
    {
        private readonly IRepositoryDapper _dapper;

        public TableController(IRepositoryDapper dapper)
        {
            _dapper = dapper;
        }

        public List<Table> ObterTodosTabela(string nomeBanco)
        {
            var sql = $"{ObterConsultaTabela()} WHERE WHERE TABLE_CATALOG ='{nomeBanco}'";
            var query = _dapper.RetornarLista<Table>(sql).ToList();
            if (query == null) return null;

            return query;
        }

        public List<string> ObterTodosNomeTabela(string nomeBanco)
        {
            var sql = $"{ObterConsultaTabela()} WHERE TABLE_CATALOG ='{nomeBanco}'";
            var query = _dapper.RetornarLista<Table>(sql)
                                .OrderBy(c=> c.NomeDaTabela)
                                .Select(x => x.NomeDaTabela)
                                .Distinct().ToList();

            if (query == null) return null;

            return query;
        }

        public List<Table> ObterTodosNomeColunasTabela(string nomeBanco,string nomeTabela)
        {
            var sql = $"{ObterConsultaTabela()} WHERE TABLE_CATALOG ='{nomeBanco}' AND TABLE_NAME = '{nomeTabela}' ";
            var query = _dapper.RetornarLista<Table>(sql)
                                .OrderBy(c => c.NomeDaColuna)
                                //.Select(x => x.NomeDaTabela)
                                .Distinct().ToList();
            if (query == null) return null;

            return query;
        }

        public Database ObterPorNome(string nome)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@nome", nome);
            var sql = $"SELECT database_id	AS Id,name	AS Nome FROM SYS.DATABASES ORDER BY name";
            var query = _dapper.RetornarObjeto<Database>(sql, parameter);
            if (query == null) return null;

            return query;
        }



        private string ObterConsultaTabela()
        {
            return @$"SELECT 
            '0' AS Id
            ,TABLE_CATALOG AS NomeDoBanco
	        ,TABLE_NAME AS NomeDaTabela
	        ,COLUMN_NAME AS NomeDaColuna
	        ,CASE
                WHEN(DATA_TYPE = 'nvarchar' OR DATA_TYPE = 'varchar') THEN 'varchar(' + CONVERT(VARCHAR, CHARACTER_MAXIMUM_LENGTH) + ')'
                WHEN(DATA_TYPE = 'numeric' OR DATA_TYPE = 'money' OR DATA_TYPE = 'real') THEN 'numeric(' + CONVERT(VARCHAR, NUMERIC_PRECISION) + ',' + CONVERT(VARCHAR, NUMERIC_PRECISION_RADIX) + ')'
                WHEN DATA_TYPE = 'int'                               THEN 'int'
                WHEN DATA_TYPE = 'float'                             THEN 'float'
                WHEN DATA_TYPE = 'geometry'                          THEN 'geometry'
                WHEN DATA_TYPE = 'image'                             THEN 'image'
                WHEN DATA_TYPE = 'smallint'                          THEN 'smallint'
            END AS TipoDaColuna
	        ,CASE
                WHEN(DATA_TYPE = 'nvarchar' OR DATA_TYPE = 'varchar') THEN 'string'
                WHEN(DATA_TYPE = 'numeric' OR DATA_TYPE = 'money' OR DATA_TYPE = 'real') THEN 'decimal?'
                WHEN DATA_TYPE = 'int'                               THEN 'int'
                WHEN DATA_TYPE = 'float'                             THEN 'double'
                WHEN DATA_TYPE = 'geometry'                          THEN 'geometry'
                WHEN DATA_TYPE = 'image'                             THEN 'byte[]'
                WHEN DATA_TYPE = 'smallint'                          THEN 'int?'
            END AS TipoDaColunaCSharp
            ,CASE
                WHEN(DATA_TYPE = 'nvarchar' OR DATA_TYPE = 'varchar') THEN  CONVERT(VARCHAR, CHARACTER_MAXIMUM_LENGTH) 
                WHEN(DATA_TYPE = 'numeric' OR DATA_TYPE = 'money' OR DATA_TYPE = 'real') THEN CONVERT(VARCHAR, NUMERIC_PRECISION) + ',' + CONVERT(VARCHAR, 2)
                WHEN DATA_TYPE = 'int'                               THEN '0'
                WHEN DATA_TYPE = 'float'                             THEN '0'
                WHEN DATA_TYPE = 'geometry'                          THEN '0'
                WHEN DATA_TYPE = 'image'                             THEN '0'
                WHEN DATA_TYPE = 'smallint'                          THEN '0'
            END AS TipoDaColunaMappingMaxLength
        FROM INFORMATION_SCHEMA.COLUMNS ";
        }

    }
}
