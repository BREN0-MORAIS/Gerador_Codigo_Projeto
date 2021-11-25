using System.Collections.Generic;
using System.Text.Json;

namespace Gerador_Codigo.Services
{
    public class GeradorModelService : GeradorService
    {
        public List<string> Imports { get; set; }
        public string table { get; set; }
        public string classe { get; set; }
        public List<string> Atribut { get; set; }
        public List<string> AtributObj { get; set; }
        public List<string> AtributList { get; set; }

        public GeradorModelService()
        {
            Imports = new List<string>();
            Atribut = new List<string>();
            AtributObj = new List<string>();
            AtributList = new List<string>();
            table = string.Empty;
            classe = string.Empty;
        }

        public string ObterDadosTemplate()
        {
            var template = new GeradorModelService();

            var result = JsonSerializer.Serialize(template);
            return result;
        }

        public bool GerarModel()
        {
            var template = ObterTemplate();
            var data = ObterDadosTemplate();
            var result = GerarTemplate(data, template);
            return true;
        }

        private string ObterTemplate()
        {
            var template = @"/*******************************************************************************
                            Title: Gerador de Código 1.0                                                               
                            Description: Model relacionado à tabela [{{table}}] 
                            Copyright: Copyright (C) 2021                           
                            @author Edielson Silverio (edielson.silverio@gmail.com)                    
                            @version 1.0.0
                            *******************************************************************************/
                            {{#imports}}
                            {{{.}}}
                            {{/imports}}

                            namespace Business.Models
                            {
                                public class {{classe}}
                                {
                                    {{#atribut}}
		                            {{{.}}}
                                    {{/atribut}}
                                    {{#atributObj}}
		                            {{{.}}}
                                    {{/atributObj}}
                                    {{#atributList}}
		                            {{{.}}}
                                    {{/atributList}}
                                 }
                            }
                    ";

            return template;
        }
    }
}
