using Gerador_Codigo.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Gerador_Codigo.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        private readonly ICryptography _cryptography;
        private readonly IXmlOperation _xmlOperation;

        public ApplicationDbContext() { }

        public ApplicationDbContext(IXmlOperation xmlOperation, ICryptography cryptography)
        {
            _cryptography = cryptography;
            _xmlOperation = xmlOperation;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfiguration(new ColetaConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn;
                conn = _cryptography.OpCrypto(_xmlOperation.loadFromConfig("connDb"), false, 2);

            //conn = "Server=192.168.0.21,1533;Database=Geo_Aripuana_2021_Analise;User=dev;Password=a";
            //conn = "Server=192.168.0.21,1533;Database=Geo_CampoNovo_2021_Analise;User=dev;Password=a";
            optionsBuilder.UseSqlServer(conn);
        }
    }
}
