//using ImageLib;
using Gerador_Codigo.Configuration;
using Gerador_Codigo.Data.Services;
using Ninject;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace View
{
    public partial class FrmConexao : Form
    {
 
        private IXmlOperation _objXml;
        private ICryptography _objCrypto;
        private string _stringConection;
        private string _stringConectionImg;
        private string _stringConectionAnalise;
        private ConnectionAdo _conn;
        [Inject]
        public FrmConexao(ICryptography objCrypto, IXmlOperation objXml)
        {
            InitializeComponent();
            this._objXml = objXml;
            this._objCrypto = objCrypto;
            _conn = ConnectionAdoCreateFactory.CreateSqlServerInstancie();
        }

        private void FrmConexao_Load(object sender, EventArgs e)
        {
            //var builder = new DbConnectionStringBuilder();
            txtDatasource.Text = _objCrypto.OpCrypto(_objXml.loadFromConfig("datasource"), false, 2);
            txtDatabase.Text = _objCrypto.OpCrypto(_objXml.loadFromConfig("database"), false, 2);
            txtUser.Text = _objCrypto.OpCrypto(_objXml.loadFromConfig("user"), false, 2);
            txtPassword.Text = _objCrypto.OpCrypto(_objXml.loadFromConfig("password"), false, 2);
            CarregarImagem();
        }

        private void CarregarImagem()
        {
            //ImageLib.img im = new ImageLib.img();
            //btnConectar.Image = im.ImageList1.Images["BotaoAtualizar"];
            //btnSalvar.Image = im.ImageList1.Images["BotaoSalvar"];
            //btnSair.Image = im.ImageList1.Images["BotaoFechar"];
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_stringConection)) return;

            _objXml.SaveSetting("connDb", _objCrypto.OpCrypto(_stringConection, true, 2));
            _objXml.SaveSetting("connDbImagem", _objCrypto.OpCrypto(_stringConectionImg, true, 2));
            _objXml.SaveSetting("connDbAnalise", _objCrypto.OpCrypto(_stringConectionAnalise, true, 2));

            _objXml.SaveSetting("datasource", _objCrypto.OpCrypto(txtDatasource.Text, true, 2));
            _objXml.SaveSetting("database", _objCrypto.OpCrypto(txtDatabase.Text, true, 2));
            _objXml.SaveSetting("user", _objCrypto.OpCrypto(txtUser.Text, true, 2));
            _objXml.SaveSetting("password", _objCrypto.OpCrypto(txtPassword.Text, true, 2));
            
            Close();
            System.Windows.Forms.Application.Exit();
            var startInfo = new ProcessStartInfo(System.Windows.Forms.Application.StartupPath+ $"\\{Commun.SD.NOME_DA_APLICACAO}");
            startInfo.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(startInfo);
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
           // _stringConection = $@"Server={txtDatasource.Text};Database={txtDatabase.Text};Uid={txtUser.Text};Pwd={txtPassword.Text};";
            _stringConection = $"Server={txtDatasource.Text};Database={txtDatabase.Text};Uid={txtUser.Text};Pwd={txtPassword.Text};";
            _stringConectionImg = $"Server={txtDatasource.Text};Database={txtDatabase.Text}_Imagem;Uid={txtUser.Text};Pwd={txtPassword.Text};";
            _stringConectionAnalise = $"Server={txtDatasource.Text};Database={txtDatabase.Text}_Analise;Uid={txtUser.Text};Pwd={txtPassword.Text};";
  
            if (_conn.VerificarConexao(_stringConection))
            {
                btnSalvar.Enabled = true;
                btnConectar.Enabled = false;
                MessageBox.Show("Banco de dados conectado com sucesso.", "Conexão Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnSalvar.Enabled = false;
                btnConectar.Enabled = true;
                MessageBox.Show("Erro ao conectar com o banco de dados.", "Conexão Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        //#region Função para carregar os banco de dados de acordo com a conexão escolhida
        //private List<string> CarregaConexaoInicial()
        //{
        //    try
        //    { //TODO: TERMINAR DE FAZER A TELA DE CONEXÃO.
        //        var sqlTable = @"SELECT NAME FROM SYS.databases WHERE name NOT LIKE '%IMAGEM%'
        //                         AND NAME NOT LIKE '%ReportServer%'
        //                         AND NAME NOT IN ('master','model','msdb')
        //                         ORDER BY NAME";
        //        Console.WriteLine(sqlTable);
        //        //var lista = (SqlDataReader)_conn.ExecuteReader(commandType: CommandType.Text, sqlTable);

        //        //var listaRetorno = new List<string>();
        //        //foreach (var item in lista)
        //        //    listaRetorno.Add(Convert.ToString(item));

        //        //return listaRetorno;
        //        return null;
        //    }
        //    catch
        //    {
        //        return null;
        //    }
        //}
        //#endregion Função para carregar os banco de dados de acordo com a conexão escolhida
    }
}
