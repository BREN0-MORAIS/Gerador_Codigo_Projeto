using Gerador_Codigo.Configuration;
using Gerador_Codigo.Data.Context;
using Gerador_Codigo.Data.Services;
using Ninject.Modules;
using System.Windows.Forms;

namespace Gerador_Codigo.Services
{
    public class FormModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IXmlOperation>().To<XmlOperation>();
            Bind<ICryptography>().To<Cryptography>();

            try
            {
                //Bind<ApplicationDbContext>().To<ApplicationDbContext>(); ;
                Bind<IRepositoryDapper>().To<RepositorySqlServerDapper>(); ;

            }
            catch
            {
                //Application.Run(FormResolve.Resolve<FrmConexao>());
            }

        }

        public static FormModule Create()
        {
            return new FormModule();
        }
    }
}
