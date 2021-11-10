using Ninject;
using Ninject.Modules;
using Ninject.Parameters;

namespace Gerador_Codigo.Services
{
    public class FormResolve
    {
        private static IKernel _ninjectKernel;

        public static void Wire(INinjectModule module)
        {
            _ninjectKernel = new StandardKernel(module);
        }

        public static T Resolve<T>()
        {
            return _ninjectKernel.Get<T>();
        }

        public static T Resolve<T>(string nameParam, object param)
        {
            return _ninjectKernel.Get<T>(new ConstructorArgument(nameParam, param));
        }
    }
}
