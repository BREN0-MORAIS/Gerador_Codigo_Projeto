namespace Gerador_Codigo.Data.Services
{
    public static class ConnectionAdoCreateFactory
    {
        public static ConnectionAdo CreateSqlServerInstancie()
        {
            return new ConnectionAdoSqlServer();
        }
       
        public static ConnectionAdo CreatePostgresInstancie()
        {
            return new ConnectionAdoPostgres();
        }

        public static ConnectionAdo CreateMySqlInstancie()
        {
            return new ConnectionAdoMySql();
        }
    }
}
