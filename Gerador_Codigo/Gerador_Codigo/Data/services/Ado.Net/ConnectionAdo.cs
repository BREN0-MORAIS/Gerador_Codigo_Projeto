using System.Data;

namespace Gerador_Codigo.Data.Services
{
    public abstract class ConnectionAdo
    {
        protected string ConnectionString;
        protected string  ConnectionStringImage;
        protected IDataParameterCollection ParamCollection;
        public abstract IDbConnection CriarConexao();
        public abstract bool VerificarConexao(string connectionString);
        public abstract string ObterStringConexao();
        public abstract void LimparParamentros();
        public abstract void AdicionarParametros(string name, object value);
        public abstract DataTable ExecutarConsultaComRetorno(CommandType commandType, string textSql);
        public abstract IDataReader ExecuteReader(CommandType commandType, string textSql);
        public abstract object ExecuteScalar(CommandType commandType, string textSql);
        public abstract void BancoConectado();
    }
}
