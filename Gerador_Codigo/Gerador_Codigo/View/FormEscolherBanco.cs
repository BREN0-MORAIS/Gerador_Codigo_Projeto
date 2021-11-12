using Gerador_Codigo.Controller;
using Gerador_Codigo.Data.Services;
using System;
using System.Windows.Forms;

namespace Gerador_Codigo
{
    public partial class FormEscolherBanco : Form
    {
        private readonly DatabaseController _controllerDatabase;
        private readonly TableController _controllerTable;
        private readonly IRepositoryDapper _dapper;
        public FormEscolherBanco()
        {
            InitializeComponent();
            _dapper = new RepositorySqlServerDapper();
            _controllerDatabase = new DatabaseController(_dapper);
            _controllerTable = new TableController(_dapper);
        }

        private void FormEscolherBanco_Load(object sender, EventArgs e)
        {

        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            clbDatabase.DataSource = null;
            var query = _controllerDatabase.ObterTodosNome();
            if (query == null) return;

            clbDatabase.DataSource = query;
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            string database = "Geo_GauchaNorte_2021";
            clbTable.DataSource = null;
            var query = _controllerTable.ObterTodosNomeTabela(database);
            if (query == null) return;

            clbTable.DataSource = query;
        }

        private void btnCarregarColunas_Click(object sender, EventArgs e)
        {
            string database = "Geo_GauchaNorte_2021";
            string table = "App_Fea";
            dgvResultado.DataSource = null;
            var query = _controllerTable.ObterTodosNomeColunasTabela(database, table);
            if (query == null) return;

            dgvResultado.DataSource = query;
            dgvResultado.Columns["Id"].Visible = false;
            dgvResultado.Columns["NomeDaTabela"].Visible = false;
        }
    }
}
