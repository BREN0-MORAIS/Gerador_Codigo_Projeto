using HandlebarsDotNet;

namespace Gerador_Codigo.Services
{
    public abstract class GeradorService
    {
        protected string GerarTemplate<T>(T data, string template)
        {
            var compile = Handlebars.Compile(template);
            var result = compile(data);
            return result;
        }
    }
}
