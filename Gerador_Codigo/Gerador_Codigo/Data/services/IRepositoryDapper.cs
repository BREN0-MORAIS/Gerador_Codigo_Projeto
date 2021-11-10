using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Gerador_Codigo.Data.Services
{
    public interface IRepositoryDapper : IDisposable
    {
        string ObterNomeBanco();
        string ObterNomeServidor();
        string ObterStringConexao();
        IEnumerable<T> RetornarLista<T>(string procedureName, DynamicParameters param = null, CommandType commandType = CommandType.Text);

        void ExecutarSemRetorno(string procedureName, DynamicParameters param = null, CommandType commandType = CommandType.Text);
        T RetornarObjeto<T>(string procedureName, DynamicParameters param = null, CommandType commandType = CommandType.Text);

        Task<bool> ExecuteWithoutReturnAsync(string procedureName, DynamicParameters param = null,
            CommandType commandType = CommandType.Text);
    }
}