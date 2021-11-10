namespace Gerador_Codigo.Configuration
{
    public interface ICryptography
    {
        string OpCrypto(string texto, bool operacao, int chave);
        string ConvertHexa(string asciiString);
    }
}
