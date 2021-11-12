namespace Gerador_Codigo.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string NomeDaTabela { get; set; }
        public string NomeDaColuna { get; set; }
        public string TipoDaColuna { get; set; }
        public string TipoDaColunaCSharp { get; set; }
        public string TipoDaColunaMappingMaxLength { get; set; }
    }
}
